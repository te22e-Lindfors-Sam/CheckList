//Skapar ny lista där alla tasks spelas
Task.tasks = new List<Task>();

while (true)
{

    Console.WriteLine("What will you do");
    Console.WriteLine("1: Look at the tasks");
    Console.WriteLine("2: Add task");
    Console.WriteLine("3: Quit");
    
    //Checking for input
    string input = Console.ReadLine() ?? "";
    if (input == "1")
    {
        //if numbe one is selected print out all takss
        Console.WriteLine("\nPress the number of the task or any key to go back");
        Task.WriteOutAllTasks();
        //take new input for what task the user choose
        input = Console.ReadLine() ?? "";
        int inputAsInt;
        int.TryParse(input, out inputAsInt);
        Console.WriteLine("");
        //if the tasks exsist either complete the task, delete it or quit.
        if (1 <= inputAsInt && inputAsInt <= Task.tasks.Count)
        {
            Console.WriteLine("Do you want to complete(c) or delete(d) this task? Press any key to cancel");
            Task.WriteTask(Task.tasks[inputAsInt - 1]);

            input = Console.ReadLine() ?? "";
            if (input.ToUpper() == "C")
            {
                Console.WriteLine("Completed well done");
                //playign a sound cause its very important the user gets a super mega duper hit of dophamine
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
    //Calls the method to add a new task
    else if (input == "2")
    {
        Task.tasks.Add(Task.AddTask());
    }
    //Quit the aplication
    else if (input == "3")
    {
        Console.Clear();
        return;
    }
    else
    {
        //Didint choose anything u can choose
        Console.WriteLine("That is not an option");
        Console.Clear();
    }

}








