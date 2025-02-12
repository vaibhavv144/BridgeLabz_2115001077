using System;

class Task{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public Task Next;
    public Task(int taskID, string taskName, int priority, DateTime dueDate){
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler{
    private Task head;
    public void AddTaskAtBeginning(int taskID, string taskName, int priority, DateTime dueDate){
        Task newTask = new Task(taskID, taskName, priority, dueDate);
        if (head == null){
            head = newTask;
            head.Next = head;
            return;
        }
        Task temp = head;
        while (temp.Next != head){
            temp = temp.Next;
        }
        newTask.Next = head;
        temp.Next = newTask;
        head = newTask;
    }

    public void AddTaskAtEnd(int taskID, string taskName, int priority, DateTime dueDate){
        Task newTask = new Task(taskID, taskName, priority, dueDate);
        if (head == null){
            head = newTask;
            head.Next = head;
            return;
        }
        Task temp = head;
        while (temp.Next != head){
            temp = temp.Next;
        }
        temp.Next = newTask;
        newTask.Next = head;
    }

    public void RemoveTaskByID(int taskID){
        if (head == null){
            Console.WriteLine("No tasks available");
            return;
        }
        Task temp = head, prev = null;
        do{
            if (temp.TaskID == taskID){
                if (temp == head){
                    Task last = head;
                    while (last.Next != head){
                        last = last.Next;
                    }
                    head = head.Next;
                    last.Next = head;
                }else{
                    prev.Next = temp.Next;
                }
                Console.WriteLine("Task removed");
                return;
            }
            prev = temp;
            temp = temp.Next;
        }while (temp != head);
        Console.WriteLine("Task not found");
    }

    public void ViewCurrentTask(){
        if (head == null){
            Console.WriteLine("No tasks available");
            return;
        }
        Console.WriteLine($"TaskID: {head.TaskID}, \nTask Name: {head.TaskName}, \nPriority: {head.Priority}, \nDue Date: {head.DueDate}\n");
        head = head.Next;
    }

    public void DisplayAllTasks(){
        if (head == null){
            Console.WriteLine("No tasks available");
            return;
        }
        Task temp = head;
        do{
            Console.WriteLine($"TaskID: {temp.TaskID}, \nTask Name: {temp.TaskName}, \nPriority: {temp.Priority}, \nDue Date: {temp.DueDate}\n");
            temp = temp.Next;
        }while (temp != head);
    }

    public void SearchTaskByPriority(int priority){
        if (head == null){
            Console.WriteLine("No tasks available");
            return;
        }
        Task temp = head;
        bool found = false;
        do{
            if (temp.Priority == priority){
                Console.WriteLine($"TaskID: {temp.TaskID}, \nTask Name: {temp.TaskName}, \nDue Date: {temp.DueDate}\n");
                found = true;
            }
            temp = temp.Next;
        }while (temp != head);
        if (!found){
            Console.WriteLine("No tasks found with given priority");
        }
    }
}

class Ques3{
    public static void Print(){
        TaskScheduler scheduler = new TaskScheduler();
        scheduler.AddTaskAtEnd(1, "Complete Assignment", 2, DateTime.Parse("2025-02-15"));
        scheduler.AddTaskAtEnd(2, "Project Submission", 1, DateTime.Parse("2025-02-20"));
        scheduler.AddTaskAtBeginning(3, "Team Meeting", 3, DateTime.Parse("2025-02-10"));
        
        Console.WriteLine("===All Tasks===");
        scheduler.DisplayAllTasks();
        
        Console.WriteLine("\n===Viewing Current Task and Moving to Next===");
        scheduler.ViewCurrentTask();
        
        Console.WriteLine("\n===Searching for Tasks with Priority 2===");
        scheduler.SearchTaskByPriority(2);
        
        Console.WriteLine("\n===Removing Task with ID 1===");
        scheduler.RemoveTaskByID(1);
        
        Console.WriteLine("\n===All Tasks After Deletion===");
        scheduler.DisplayAllTasks();
    }
}