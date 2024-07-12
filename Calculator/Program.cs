Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string userInputFirst = Console.ReadLine();
//in solution used var instead of string and int
// var userInputFirst = Console.Readline();
// var numberFirst =int.Parse(userInputFirst);
// method parse converts string to different type in this case integer
int numberFirst = int.Parse(userInputFirst);
Console.WriteLine("Input the second number:");
string userInputSecond = Console.ReadLine();
// method parse converts string to different type in this case integer
int numberSecond = int.Parse(userInputSecond);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var userChoice = Console.ReadLine();

//method to print the final equation
void PrintFinalEquation(
    int numberFirst, int numberSecond, int result, string @operator
    )
{
    Console.WriteLine($"{numberFirst} {@operator} {numberSecond} = {result}");
}

// method to check the string - put the input to upper case 

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

//if (userChoice == "A" || userChoice == "a")
if (EqualsCaseInsensitive(userChoice, "A"))
{
    var additionResult = numberFirst + numberSecond;
    PrintFinalEquation(numberFirst, numberSecond, additionResult, "+");
}
//else if (userChoice == "S" || userChoice == "s")
else if (EqualsCaseInsensitive(userChoice, "S"))
{
    var subtractionResult = numberFirst - numberSecond;
    // Console.WriteLine($"{userInputFirst} - {userInputSecond} = {subtractionResult}");
    PrintFinalEquation(numberFirst, numberSecond, subtractionResult, "-");
}
//else if (userChoice == "M" || userChoice == "m")
else if (EqualsCaseInsensitive(userChoice, "M"))
{
    var multipliedResult = numberFirst * numberSecond;
    //Console.WriteLine($"{userInputFirst} * {userInputSecond} = {multipliedResult}");
    PrintFinalEquation(numberFirst, numberSecond, multipliedResult, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}

//press any key to exit programme
Console.WriteLine("Press any key to close");
Console.ReadKey();

