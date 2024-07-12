// application starts - prints all options
Console.WriteLine("Hello!");
List<string> toDoList = new List<string>();
while (true)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();
    // method to check the string - put the input to upper case 

    bool EqualsCaseInsensitive(string left, string right)
    {
        return left.ToUpper() == right.ToUpper();
    }

    // S - See all todos - all todos are printed with their index however it starts at 1 not 0
    // One to do list is printed it should reask what to do
    // if no todos then mesage printed and options regiven


    if (EqualsCaseInsensitive(userChoice, "S"))
    {
        if (toDoList.Count != 0)
        {
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {toDoList[i]}");
            }
        }
        else
            Console.WriteLine("No TODOs have been added yet.");
    }

    // A - Add a todo - asked for todo description and then confirms if successfully added
    // if description is empty - error
    // if description is duplicate of existing description - error
    else if (EqualsCaseInsensitive(userChoice, "A"))
    {
        Console.WriteLine("Enter the TODO description:");
        var userResponse = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userResponse))
        {
            Console.WriteLine("The description cannot be empty");
        }
        else
        {
            if (toDoList.Contains(userResponse))
            {
                Console.WriteLine("The description must be unique");
            }
            else
            {
                toDoList.Add(userResponse);
                var lastItemAdded = toDoList.Last();
                Console.WriteLine($"TODO Successfully added: {lastItemAdded}");
            }
        }

    }


    // R - Remove todo - select index of todo to remove and lists all todos
    // if user has no todos print message
    // user selects index number to remove
    // confirmation shown of description of todo thats been removed
    // all options then presented again
    else if (EqualsCaseInsensitive(userChoice, "R"))
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        if (toDoList.Count != 0)
        {
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {toDoList[i]}");
            }
            var userIndexChoice = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userIndexChoice))
            {
                Console.WriteLine("Selected index cannot be empty.");
            }
            else
            {
                int userIntChoice = int.Parse(userIndexChoice);


                if (userIntChoice <= toDoList.Count)
                {
                    var userSelection = toDoList[userIntChoice - 1];
                    toDoList.RemoveAt(userIntChoice - 1);
                    Console.WriteLine($"TO DO removed: {userSelection}");
                }
                else
                {
                    Console.WriteLine("The given index is not valid");
                }
            }
        }
        else
        {
            Console.WriteLine("No TODOs have been added yet.");
        }

    }

    // E - Exit - just exits the application
    else if (EqualsCaseInsensitive(userChoice, "E"))
    {
        Console.WriteLine("Press any key to exit the program");
        Console.ReadKey();
        break;
    }
    //user incorrectly enters not expected response, they receive message confirming this
    else
    {
        Console.WriteLine("Invalid choice!");
    }
}












