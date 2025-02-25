using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
 
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Property | AttributeTargets.Field)]
public class InjectAttribute : Attribute
{
}
 
public class DependencyInjectionContainer
{
	private readonly Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();
 
	public void Register<TypeInterface, TypeImplementation>() where TypeImplementation : TypeInterface
	{
    	Type interfaceType = typeof(TypeInterface);
    	Type implementationType = typeof(TypeImplementation);
    	_registrations[interfaceType] = implementationType;
	}
 
	public TypeObject Resolve<TypeObject>()
	{
    	Type requestedType = typeof(TypeObject);
    	return (TypeObject)Resolve(requestedType);
	}
 
	private object Resolve(Type type)
	{
    	if (!_registrations.ContainsKey(type))
    	{
        	throw new Exception("Type " + type.Name + " is not registered.");
    	}
 
    	Type implementationType = _registrations[type];
 
    	ConstructorInfo[] constructors = implementationType.GetConstructors();
    	ConstructorInfo constructorWithInjectAttribute = null;
    	foreach (ConstructorInfo constructor in constructors)
    	{
        	if (constructor.GetCustomAttribute<InjectAttribute>() != null)
            {
                constructorWithInjectAttribute = constructor;
                break;
            }
    	}
 
    	ConstructorInfo selectedConstructor = constructorWithInjectAttribute ?? constructors.First();
 
    	ParameterInfo[] constructorParameters = selectedConstructor.GetParameters();
    	object[] resolvedConstructorArguments = new object[constructorParameters.Length];
 
    	for (int i = 0; i < constructorParameters.Length; i++)
    	{
        	resolvedConstructorArguments[i] = Resolve(constructorParameters[i].ParameterType);
    	}
 
    	object instance = Activator.CreateInstance(implementationType, resolvedConstructorArguments);
 
    	FieldInfo[] fields = implementationType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
    	foreach (FieldInfo field in fields)
    	{
        	InjectAttribute attribute = field.GetCustomAttribute<InjectAttribute>();
        	if (attribute != null)
            {
                object fieldDependency = Resolve(field.FieldType);
                field.SetValue(instance, fieldDependency);
            }
    	}
 
    	PropertyInfo[] properties = implementationType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
    	foreach (PropertyInfo property in properties)
    	{
        	InjectAttribute attribute = property.GetCustomAttribute<InjectAttribute>();
        	if (attribute != null)
            {
                object propertyDependency = Resolve(property.PropertyType);
                property.SetValue(instance, propertyDependency);
            }
    	}
 
    	return instance;
	}
}
 
public interface IService
{
	void Serve();
}
 
public class Service : IService
{
	public void Serve()
	{
    	Console.WriteLine("Service is running...");
	}
}
 
public class Client
{
	[Inject]
	private IService _service;
 
	public void Run()
	{
    	_service.Serve();
	}
}
 
// Main program
class Test11{
	public static void Print(){
    	DependencyInjectionContainer container = new DependencyInjectionContainer();
    	container.Register<IService, Service>();
    	container.Register<Client, Client>();
 
    	Client client = container.Resolve<Client>();
    	client.Run();
	}
}