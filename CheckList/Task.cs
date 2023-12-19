public class Task
{
    public static List<Task> tasks;
    public string taskName;
    public string taskBody;
    public Task() { }


    public static Task AddTask()
    {
        Task task = new Task();
        //taking in the lenght of the name of the task making sure its is long enought
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
        //Makes the user be able to make whatever body they want
        Console.WriteLine("What is the body of the task");
        task.taskBody = Console.ReadLine() ?? "";
        
        Console.WriteLine("Task is added");
        Thread.Sleep(2000);
        Console.Clear();

        return task;

    }

    //Writes out all tasks
    public static void WriteOutAllTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine((i+1).ToString() + ": " + tasks[i].taskName);
        }
    }
    //Writes out an individual task
    public static void WriteTask(Task task)
    {
        Console.WriteLine(task.taskName + ":");
        Console.WriteLine("     " + task.taskBody);
    }

}