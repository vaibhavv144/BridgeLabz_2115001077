using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
    public int Severity { get; set; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }
}

class Test13
{
    public static void Triage(List<Patient> patients)
    {
        SortedDictionary<int, Queue<Patient>> priorityQueue = new SortedDictionary<int, Queue<Patient>>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach (var patient in patients)
        {
            if (!priorityQueue.ContainsKey(patient.Severity))
            {
                priorityQueue[patient.Severity] = new Queue<Patient>();
            }
            priorityQueue[patient.Severity].Enqueue(patient);
        }

        foreach (var severity in priorityQueue.Keys)
        {
            while (priorityQueue[severity].Count > 0)
            {
                var patient = priorityQueue[severity].Dequeue();
                Console.WriteLine(patient.Name);
            }
        }
    }

    public static void Print()
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient("John", 3),
            new Patient("Alice", 5),
            new Patient("Bob", 2)
        };

        Triage(patients); // Output: Alice, John, Bob
    }
}
