using System;  
using System.Diagnostics;  
using System.Reflection;  

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]  
public class LogExecutionTimeAttribute : Attribute  
{  
}  

public class PerformanceTester  
{  
    [LogExecutionTime]  
    public void FastMethod()  
    {  
        for (int i = 0; i < 100000; i++) { }
    }  

    [LogExecutionTime]  
    public void SlowMethod()  
    {  
        for (int i = 0; i < 500000; i++) { }
    }  
}  

public class Test8  
{  
    public static void Print()  
    {  
        Type type = typeof(PerformanceTester);  
        object instance = Activator.CreateInstance(type);  
        MethodInfo[] methods = type.GetMethods();  
        foreach (MethodInfo method in methods)  
        {  
            if (method.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) != null)  
            {  
                Stopwatch stopwatch = Stopwatch.StartNew();  
                method.Invoke(instance, null); // Execute method  
                stopwatch.Stop();  
                Console.WriteLine($"Method {method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");  
            }  
        }  
    }  
}
