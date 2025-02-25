using System;
using System.Diagnostics;
using System.Reflection;
public class MethodTimer
{
	public static void MeasureExecutionTime(object instance, string methodName, object[] parameters)
	{
    	Type type = instance.GetType();
    	MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
 
    	if (method == null)
    	{
        	Console.WriteLine("Method " + methodName + " not found in class " + type.Name);
        	return;
    	}
 
    	Stopwatch stopwatch = new Stopwatch();
    	stopwatch.Start();
 
    	object result = method.Invoke(instance, parameters);
 
    	stopwatch.Stop();
 
    	Console.WriteLine("Execution time for method " + methodName + ": " + stopwatch.ElapsedMilliseconds + " ms");
 
    	if (method.ReturnType != typeof(void))
    	{
        	Console.WriteLine("Method result: " + result);
    	}
	}
}
 
public class SampleClasss
{
	public void FastMethod()
	{
    	Console.WriteLine("Executing FastMethod...");
	}
 
	private int SlowMethod(int number)
	{
    	Console.WriteLine("Executing SlowMethod...");
    	System.Threading.Thread.Sleep(1000);
    	return number * 2;
	}
}
 
// Main program
class Test12
{
	public static void Print()
	{
    	SampleClasss sampleInstance = new SampleClasss();
 
    	MethodTimer.MeasureExecutionTime(sampleInstance, "FastMethod", new object[] { });
 
    	MethodTimer.MeasureExecutionTime(sampleInstance, "SlowMethod", new object[] { 10 });
	}
}
