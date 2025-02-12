using System;

class Process
{
    public int ProcessID;
    public int BurstTime;
    public int RemainingTime;
    public int WaitingTime;
    public int TurnaroundTime;
    public Process Next;

    public Process(int processID, int burstTime)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        WaitingTime = 0;
        TurnaroundTime = 0;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private Process last;
    private int timeQuantum;

    public RoundRobinScheduler(int quantum)
    {
        last = null;
        timeQuantum = quantum;
    }

    public void AddProcess(int processID, int burstTime)
    {
        Process newProcess = new Process(processID, burstTime);

        if (last == null)
        {
            last = newProcess;
            last.Next = last;
        }
        else
        {
            newProcess.Next = last.Next;
            last.Next = newProcess;
            last = newProcess;
        }

        Console.WriteLine($"Process {processID} added with Burst Time {burstTime}.");
    }

    public void RemoveProcess(int processID)
    {
        if (last == null)
        {
            Console.WriteLine("No processes available.");
            return;
        }

        Process current = last.Next, prev = last;

        do
        {
            if (current.ProcessID == processID)
            {
                if (current == last && current.Next == last) // Single node case
                {
                    last = null;
                }
                else
                {
                    prev.Next = current.Next;
                    if (current == last)
                        last = prev;
                }
                Console.WriteLine($"Process {processID} removed.");
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != last.Next);

        Console.WriteLine("Process not found.");
    }

    public void DisplayProcesses()
    {
        if (last == null)
        {
            Console.WriteLine("No processes in queue.");
            return;
        }

        Process temp = last.Next;
        Console.WriteLine("Current Process Queue:");
        do
        {
            Console.WriteLine($"Process {temp.ProcessID} - Burst Time: {temp.BurstTime}, Remaining Time: {temp.RemainingTime}");
            temp = temp.Next;
        } while (temp != last.Next);
    }

    public void SimulateScheduling()
    {
        if (last == null)
        {
            Console.WriteLine("No processes to schedule.");
            return;
        }

        int timeElapsed = 0;
        Process temp = last.Next;

        Console.WriteLine("\nStarting Round Robin Scheduling...");
        while (true)
        {
            bool allCompleted = true;
            Process process = temp;

            do
            {
                if (process.RemainingTime > 0)
                {
                    allCompleted = false;
                    int executionTime = Math.Min(timeQuantum, process.RemainingTime);
                    timeElapsed += executionTime;
                    process.RemainingTime -= executionTime;

                    Console.WriteLine($"Process {process.ProcessID} executed for {executionTime} units. Remaining Time: {process.RemainingTime}");

                    if (process.RemainingTime == 0)
                    {
                        process.TurnaroundTime = timeElapsed;
                        process.WaitingTime = process.TurnaroundTime - process.BurstTime;
                        Console.WriteLine($"Process {process.ProcessID} completed. Turnaround Time: {process.TurnaroundTime}, Waiting Time: {process.WaitingTime}");
                    }
                }
                process = process.Next;
            } while (process != temp);

            if (allCompleted)
                break;
        }

        CalculateAverages();
    }

    private void CalculateAverages()
    {
        if (last == null)
            return;

        int totalProcesses = 0, totalWaitingTime = 0, totalTurnaroundTime = 0;
        Process temp = last.Next;

        do
        {
            totalProcesses++;
            totalWaitingTime += temp.WaitingTime;
            totalTurnaroundTime += temp.TurnaroundTime;
            temp = temp.Next;
        } while (temp != last.Next);

        Console.WriteLine($"\nAverage Waiting Time: {(double)totalWaitingTime / totalProcesses:F2}");
        Console.WriteLine($"Average Turnaround Time: {(double)totalTurnaroundTime / totalProcesses:F2}");
    }
}

class Ques6
{
    public static void Print()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(4); // Time quantum = 4

        scheduler.AddProcess(1, 8);
        scheduler.AddProcess(2, 4);
        scheduler.AddProcess(3, 9);
        scheduler.AddProcess(4, 5);

        Console.WriteLine("\nDisplaying Processes:");
        scheduler.DisplayProcesses();

        Console.WriteLine("\nSimulating Scheduling:");
        scheduler.SimulateScheduling();
    }
}
