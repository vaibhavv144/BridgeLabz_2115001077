
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
 
public interface IGreeting
{
	void SayHello(string name);
	void SayGoodbye();
}
 
public class Greeting : IGreeting
{
	public void SayHello(string name)
	{
    	Console.WriteLine($"Hello, {name}!");
	}
 
	public void SayGoodbye()
	{
    	Console.WriteLine("Goodbye!");
	}
}
 
public class LoggingProxy<T> : DispatchProxy
{
	private T _instance;
 
	public static T Create(T instance)
	{
    	object proxy = Create<T, LoggingProxy<T>>();
    	((LoggingProxy<T>)proxy)._instance = instance;
    	return (T)proxy;
	}
 
	protected override object Invoke(MethodInfo targetMethod, object[] args)
	{
    	Console.WriteLine($"[LOG] Calling method: {targetMethod.Name}");
 
    	object result = targetMethod.Invoke(_instance, args);
 
    	Console.WriteLine($"[LOG] Method {targetMethod.Name} executed successfully.");
    	return result;
	}
}
 
class Test10
{
	public static void Print()
	{
    	IGreeting greetingProxy = LoggingProxy<IGreeting>.Create(new Greeting());
 
    	greetingProxy.SayHello("Vaibhav");
    	greetingProxy.SayGoodbye();
	}
}

