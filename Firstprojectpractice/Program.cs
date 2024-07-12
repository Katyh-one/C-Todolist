bool isParsingSuccessful;
// ask user for an input as long as boolean is false 
do
{
    Console.WriteLine("Enter a number:");
    var userInput = Console.ReadLine();

    isParsingSuccessful = int.TryParse(
    userInput, out int number);

    if (isParsingSuccessful)
    {
        Console.WriteLine("Parsing worked, number is " + number);
    }
    else
    {
        Console.WriteLine("Parsing was not successful5");
    }
}
while (!isParsingSuccessful);

Console.ReadKey();



////var number = 0;
////while (number < 10)
////{
////    number ++;
////    Console.WriteLine($"Number is: {number}");
////}
////Console.WriteLine("The loops is finished"
//Console.WriteLine("Enter a word");
//var userInput = Console.ReadLine();

//while (userInput.Length < 15)
//{
//    userInput += 'a';
//    Console.WriteLine(userInput);
//}

//Console.WriteLine("The loop is finished");

//string word;
//do
//{
//    Console.WriteLine("Enter a word longer than 10 letters");
//    word = Console.ReadLine();
//}
//while (word.Length <= 10);

//for (int i = 0; i < 10; i += 2)
//{
//    Console.WriteLine("Loop run" + i);
//}
//Console.WriteLine("The loop is finished");

////must use double quotes
////string userInput = "A";
////Console.WriteLine(userInput);
////type fixed when first specified
//// declaration 
////int number = 2;
////initialization
////number = 7;
////Console.WriteLine(number);

//////bool isLong = IsLong(userChoice);

//////bool IsLong(string input)
//////{
//////    return input.Length > 10;
//////}
///////int Add(int a, int b)
////{
////    return a + b;
////}

//////var result = Add(10, 5);
//////Console.WriteLine("10+5 = " + result);
/////
////char ConvertPointsToGrade(int points)
////{
////    switch (points)
////    {
////        case 10:
////        case 9:
////            return 'A';
////        case 8:
////        case 7:
////        case 6:
////            return 'B';
////        case 5:
////        case 4:
////        case 3:
////            return 'C';
////        case 2:
////            return 'D';
////        case 1:
////            return 'E';
////        default:
////            return '!';

////    }
////}

////Console.WriteLine("Hello!");
////Console.WriteLine("[S]ee all TODOs!");
////Console.WriteLine("[A]dd a TODO!");
////Console.WriteLine("[R]emove a TODO!");
////Console.WriteLine("[E]xit!");

////Console.WriteLine("Provide a number:");
////string userInput = Console.ReadLine();
////// method parse converts string to different type in this case integer
////int number = int.Parse(userInput);
////Console.WriteLine(number);



////var userChoice = Console.ReadLine();
////Console.WriteLine("User input:" + userChoice);

//////create method
////void PrintSelectedOption(string selectedOption)
////{
////    Console.WriteLine($"Selected option: {selectedOption}");
////}

////switch (userChoice)
////{
////    case "s":
////    case "S":
////        PrintSelectedOption("See all TODO");
////        break;
////    case "a":
////    case "A":
////        PrintSelectedOption("Add a TODO");
////        break;
////    case "r":
////    case "R":
////        PrintSelectedOption("Remove a TODO");
////        break;
////    case "e":
////    case "E":
////        PrintSelectedOption("Exit");
////        break;
////    default:
////        Console.WriteLine("Invalid choice");
////        break;

////}

////if (userChoice == "S")
////{
////    PrintSelectedOption("See all TODO");
////}
////else if (userChoice == "A")
////{
////    PrintSelectedOption("Add a TODO");
////}
////else if (userChoice == "R")
////{
////    PrintSelectedOption("Remove a TODO");
////}
////else if (userChoice == "E")
////{
////    PrintSelectedOption("Exit");
////}

////press any key to exit programme
//Console.ReadKey();





