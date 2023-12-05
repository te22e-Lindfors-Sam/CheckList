

Task.tasks = new List<Task>();
Task.tasks.Add(new Task("task1", "", DateTime.Now));
Task.tasks.Add(new Task("task2", "", DateTime.Now));
Task.tasks.Add(new Task("task3", "", DateTime.Now));
Task.tasks.Add(new Task("task4", "", DateTime.Now));
Task.tasks.Add(new Task("task5", "", DateTime.Now));
Task.tasks.Add(new Task("task6", "", DateTime.Now));
Task.tasks.Add(new Task("task7", "", DateTime.Now));
Task.tasks.Add(new Task("task8", "", DateTime.Now));
Task.tasks.Add(new Task("task9", "", DateTime.Now));
Task.tasks.Add(new Task("task10", "", DateTime.Now));
Task.tasks.Add(new Task("task11", "", DateTime.Now));
Task.tasks.Add(new Task("task12", "", DateTime.Now));
Task.tasks.Add(new Task("task13", "", DateTime.Now));
Task.tasks.Add(new Task("task14", "", DateTime.Now));
Task.tasks.Add(new Task("task15", "", DateTime.Now));
Task.tasks.Add(new Task("task16", "", DateTime.Now));
Task.tasks.Add(new Task("task17", "", DateTime.Now));

while (true)
{
    Console.WriteLine("What will you do");
    Console.WriteLine("1: Look at the tasks");
    Console.WriteLine("2: Add task");
    Console.WriteLine("3: Quit");

    string input = Console.ReadLine() ?? "";
    if (input == "1")
    {

    }
    else if (input == "2")
    {

    }
    else if (input == "3")
    {
        return;
    }
    else 
        Console.WriteLine("That is not an option");

    Console.Clear();
}





