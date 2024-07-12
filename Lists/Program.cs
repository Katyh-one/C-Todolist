//Check if a word is uppercase in a list

//public List<string> GetOnlyUpperCaseWords(List<string> words)
//{
//    var result = new List<string>();
//    //loops through and if any of the letters are not uppercase it will not add the word to the result collection
//    foreach(var word in words)
//    {
//        if (result.Contains(word))
//        {
//            continue;
//        }
//        if(IsUpperCase(word))
//        {
//            result.Add(word);
//        }
//        return result;
//    }
//}
////method to check if a word is uppercase
//bool IsUpperCase(string word)
//{
//    foreach(char letter in word)
//    {
//        if(!char.IsUpper(letter))
//        {
//            return false;   
//        }
//        return true;
//    }
//}

// declare what times of elements are stored in the list <>
//// list is generic type
//// list is empty
//using System.ComponentModel;

//var words = new List<string>
//{
//    "one",
//    "two",
//};
////List<string> words = new List<string>();
//Console.WriteLine("Count of elements is" + words.Count);
//// adding to a list
////words.Add("hello");
//Console.WriteLine("Removing an item:");
////words.Remove("one");
////words.RemoveAt(0);
////takes collection as a parameter and adds to list
//var moreWords = new[] { "three", "four", "five" };
//words.AddRange(moreWords);
//Console.WriteLine("INDEX OF ELEMENT IS" + words.IndexOf("one"));
//Console.WriteLine("Contains" + words.Contains("one");
////CLEARS EVERYTHING FROM A LIST
//words.Clear();

//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}


//Console.ReadKey();

//var words = new[] { "one", "two", "three", "four" };

//foreach(var word in words)
//{
//    Console.WriteLine(word);
//};
//Console.ReadLine();

//using System;
//using System.Collections.Generic;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Coding.Exercise
//{
//    public class Exercise
//    {   //The FindMax method takes a 2D array of integers called numbers as input.
//        //It checks the dimensions of the array(height and width) and returns -1 if either dimension is zero.
//        //Otherwise, it initializes a variable max with the value at the first element of the array.
//        //It then iterates through all elements in the array, comparing each value with the current max.
//        //If an element value is greater than the current max, it updates the max value.
//        //Finally, the method returns the final max value, representing the largest number in the array.
//        // Method to find the maximum value in a 2D array of integers
//        public static int FindMax(int[,] numbers)
//        {
//            int height = numbers.GetLength(0);
//            if (height == 0)
//            {
//                // Return -1 if the array is empty (no rows)
//                return -1;
//            }

//            int width = numbers.GetLength(1);
//            if (width == 0)
//            {
//                return -1;
//            }
//            // Initialize max with the first element
//            int max = numbers[0, 0];

//            //Now, in a loop, we want to iterate through all elements in this array.If any of the numbers is larger than the max variable, it means the max variable must be updated,
//            //and this larger number should overwrite the old value.
//            //After the loops are finished, the max variable will carry the largest number from this array.
//            // Iterate through all elements in the array
//            for (var i = 0; i < height; ++i)
//            {
//                for (var j = 0; j < width; ++j)
//                {
//                    var number = numbers[i, j];
//                    if (number > max)
//                    {
//                        // Update max if a larger number is found
//                        max = number;
//                    }
//                }
//            }
//            // Return the largest number in the array
//            return max;
//        }
//    }
//}

//char[,] letters = new char[2, 3];

//letters[0, 0] = 'A';
//letters[0, 1] = 'B';
//letters[0, 2] = 'C';
//letters[1, 0] = 'D';
//letters[1, 1] = 'E';
//letters[1, 2] = 'F';

//// outer loop then inner loop needed with two dimensional array
//// get length method used 
//var height = letters.GetLength(0);
//var width = letters.GetLength(1);

//Console.WriteLine($"Height is {height}");
//Console.WriteLine($"Height is {width}");

//for (var i = 0; i < height; i++)
//{
//    Console.WriteLine("i is " + i);

//    for (var j = 0; j < width; j++)
//    {
//        Console.WriteLine("j is" + j);
//        Console.WriteLine("element is" + letters[i, j]);
//    }
//}
//var letters2 = new char[,]
//{
//    {'A', 'B', 'C' },
//    {'D','E', 'F'},
//};

////create an object of a class using new
//int[] numbers = new int[] { 1, 2, 3, 4, 5 };

//var sum = 0;
//for (var i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];

//}

//Console.WriteLine($"sum of elements is {sum}");

////numbers[0] = 5;
////numbers[1] = 6;
////numbers[2] = 7;
////numbers[3] = 8;
////numbers[4] = 9;

//var firstFromEnd = numbers[^1];
//var secondFromEnd = numbers[^2];
//Console.WriteLine($"First from end: {firstFromEnd}");
//Console.WriteLine($"Second from end: {secondFromEnd}");

//Console.WriteLine($"Element at index 0 is  {numbers[0]}");
////Console.WriteLine($"Element at index 0 is  {numbers[1]}");
//Console.WriteLine($"Element at index 0 is  {numbers[2]}");

Console.ReadKey();
