using System;
using System.Collections;
public class Test3 {
    public static void Print()     {
#pragma warning disable CS8600  
        ArrayList list = new ArrayList();

        list.Add(10);  
        list.Add("Hello");
        list.Add(3.14);  

#pragma warning restore CS8600

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

