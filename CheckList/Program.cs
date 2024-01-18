//Skapar ny lista där alla tasks spelas
List<Task> tasks = new List<Task>();
//Om man vill göra ett save system skulle man inte göra detta utan troligtvisst kalla någon method 

while (true)
{
    //Check for input
    Console.WriteLine("What will you do");
    Console.WriteLine("1: Look at the tasks");
    Console.WriteLine("2: Add task");
    Console.WriteLine("3: Quit");

    //Checking for input
    string input = Console.ReadLine() ?? "";
    if (input == "") input = "nothing";
    if (input == "1")
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No Tasks Exists, Try adding a new one");
            Thread.Sleep(1000);
            Console.Clear();
            continue;
        }
        //if numbe one is selected print out all takss
        Console.WriteLine("\nPress the number of the task or any key to go back");
        Task.WriteOutAllTasks(tasks);
        //take new input for what task the user choose
        input = Console.ReadLine() ?? "";
        int inputAsInt;
        int.TryParse(input, out inputAsInt);
        Console.WriteLine("");
        //if the tasks exsist either complete the task, delete it or quit.
        if (1 <= inputAsInt && inputAsInt <= tasks.Count)
        {
            Console.WriteLine("Do you want to complete(c) or delete(d) this task? Press any key to cancel");
            Task.WriteTask(tasks[inputAsInt - 1]);

            input = Console.ReadLine() ?? "";
            if (input.ToUpper() == "C")
            {
                Console.WriteLine("Completed well done");
                //playign a sound cause its very important the user gets a super mega duper hit of dophamine
                Console.Beep();
                tasks.RemoveAt(inputAsInt - 1);
            }
            else if (input.ToUpper() == "D")
            {
                Console.WriteLine("Deleted");
                tasks.RemoveAt(inputAsInt - 1);
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
        else continue;

    }
    //Calls the method to add a new task
    else if (input == "2")
    {
        tasks.Add(Task.AddTask());
    }
    //Quit the aplication
    else if (input == "3")
    {
        Console.Clear();
        return;
    }
    else if (input[0] == '-')
    {
        //Take away the - and then call the method if it still an int, if it is a Palindromic then say it other wise say it
        input = input.Remove(0, 1);
        int inputAsInt;
        if (int.TryParse(input, out inputAsInt))
        {
            bool isPalindromic = IsPalindromic(inputAsInt, input);
            if (isPalindromic)
            {
                Console.WriteLine("It is");
            }
            else
            {
                Console.WriteLine("It is not");
            }
        }
        else
        {
            Console.WriteLine("Thats not an number");
        }
        Thread.Sleep(1000);
        Console.Clear();
    }
    else
    {
        //Didint choose anything u can choose
        Console.WriteLine("That is not an option");
        Console.Clear();
    }

}

//This is a sected method just included for the lore
bool IsPalindromic(int number, string numbString)
{
    //Loops though each number to see if the figrue at the opposite end is the same, if its not break;
    //the varible number isent really in the scope as it just can use numbString.Lenght but to get all the points on the test i need to take in 2 inputs
    for (int i = 0; i < number.ToString().Length; i++)
    {
        if (numbString[i] != numbString[numbString.Length - 1 - i])
        {
            return false;
        }
    }

    return true;
}








