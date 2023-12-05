using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

public class Task
{
    public static List<Task> tasks;

    public string taskName { get; set; }
    public string taskBody { get; set; }
    public DateTime timeToBeDone { get; set; }
    public Task(string taskName, string taskBody, DateTime timeToBeDone)
    {
        this.taskName = taskName;
        this.taskBody = taskBody;
        this.timeToBeDone = timeToBeDone;
    }

    public static void WriteOutAllTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine(tasks[i].taskName);
        }
    }


    public static void WriteTask(Task task)
    {
        Console.WriteLine(task.taskName + ":");
        Console.WriteLine("     " + task.taskBody);
        Console.WriteLine("     " + task.timeToBeDone);
    }

}