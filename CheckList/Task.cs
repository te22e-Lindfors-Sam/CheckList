using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

public class Task
{
    public static List<Task> tasks;

    public string taskName { get; set; }
    public string taskBody { get; set; }
    public Task(string taskName, string taskBody)
    {
        this.taskName = taskName;
        this.taskBody = taskBody;
    }
    public Task() { }

    public static Task AddTask()
    {
        Task task = new Task();
        while (true)
        {
            Console.WriteLine("What is the title of the task");
            string input = Console.ReadLine() ?? "";
            if (input.Length < 3)
            {
                Console.WriteLine("To short");
            }
            else if (input.Length > 20)
            {
                Console.WriteLine("To Long");
            }
            else
            {
                task.taskName = input;
                break;
            }
        }
        Console.WriteLine("What is the body of the task");
        task.taskBody = Console.ReadLine() ?? "";
        
        Console.WriteLine("Task is added");
        Thread.Sleep(2000);
        Console.Clear();

        return task;

    }

    public static void WriteOutAllTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine((i+1).ToString() + ": " + tasks[i].taskName);
        }
    }
    public static void WriteTask(Task task)
    {
        Console.WriteLine(task.taskName + ":");
        Console.WriteLine("     " + task.taskBody);
    }

}