Task.tasks = new List<Task>();

while (true)
{
    Console.WriteLine("What will you do");
    Console.WriteLine("1: Look at the tasks");
    Console.WriteLine("2: Add task");
    Console.WriteLine("3: Quit");

    string input = Console.ReadLine() ?? "";
    if (input == "1")
    {
        Console.WriteLine("\nPress the number of the task or any key to go back");
        LookingAtTasks();
        input = Console.ReadLine() ?? "";
        int inputAsInt;
        int.TryParse(input, out inputAsInt);
        Console.WriteLine("");
        if (1 <= inputAsInt && inputAsInt <= Task.tasks.Count)
        {
            Console.WriteLine("Do you want to complete(c) or delete(d) this task? Press any key to cancel");
            Task.WriteTask(Task.tasks[inputAsInt - 1]);

            input = Console.ReadLine() ?? "";
            if (input.ToUpper() == "C")
            {
                Console.WriteLine("Completed well done");
                Console.Beep();
                Task.tasks.RemoveAt(inputAsInt - 1);
            }
            else if (input.ToUpper() == "D")
            {
                Console.WriteLine("Deleted");
                Task.tasks.RemoveAt(inputAsInt - 1);
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
        else continue;

    }
    else if (input == "2")
    {
        Task.tasks.Add(Task.AddTask());
    }
    else if (input == "3")
    {
        Console.Clear();
        return;
    }
    else
    {
        Console.WriteLine("That is not an option");
        Console.Clear();
    }

}

void LookingAtTasks()
{
    Task.WriteOutAllTasks();
}






