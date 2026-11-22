using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Using a for loop to print numbers from 0 to 9
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// Using a for loop to print numbers from 10 to 0
            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //// Using a for loop to print numbers from 0 to 9, incrementing by 3
            //for (int i = 0; i < 10; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //// Using a for loop to print numbers from 0 to 9, but breaking the loop when i equals 7
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 7) break;
            //}

            //// Using a for loop to print names in reverse order
            //string[] names = { "Alex", "Eddie", "David", "Michael" };
            //for (int i = names.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //// Using a foreach loop to print names
            //for (int i = 0; i < names.Length; i++)
            //    if (names[i] == "David") names[i] = "Sammy";

            //foreach (var name in names) Console.WriteLine(name);

            //// using a loop for fizzbuzz
            //for(int i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //        Console.WriteLine("FizzBuzz");
            //    else if (i % 3 == 0)
            //        Console.WriteLine("Fizz");
            //    else if (i % 5 == 0)
            //        Console.WriteLine("Buzz");
            //    else
            //        Console.WriteLine(i);

            //}

            // Using a do-while loop to print random numbers until 7 is generated
            //Random random = new Random();
            //int current = 0;

            //do
            //{
            //    current = random.Next(1, 11);
            //    Console.WriteLine(current);
            //} while (current != 7);

            //Random random = new Random();
            //int current = random.Next(1, 11);

            //while (current >= 3)
            //{
            //    Console.WriteLine(current);
            //    current = random.Next(1, 11);
            //}
            //Console.WriteLine($"Last number: {current}");

            //do
            //{
            //    current = random.Next(1, 11);

            //    if (current >= 8) continue;

            //    Console.WriteLine(current);
            //} while (current != 7);

            //int hero = 10;
            //int monster = 10;

            //Random dice = new Random();

            //do
            //{
            //    int roll = dice.Next(1, 11);
            //    monster -= roll;
            //    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

            //    if (monster <= 0) continue;

            //    roll = dice.Next(1, 11);
            //    hero -= roll;
            //    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            //} while (hero > 0 && monster > 0);

            //Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

            //string? readResult;
            //bool validEntry = false;

            //// capture user input in a string variable named readResult
            //Console.WriteLine("Enter a string containing at least three characters:");
            //do
            //{
            //    readResult = Console.ReadLine();

            //    int numericValue = 0;
            //    bool validNumber = false;
            //    validNumber = int.TryParse(readResult, out numericValue);

            //    if (readResult != null)
            //    {
            //        if (readResult.Length >= 3)
            //        {
            //            validEntry = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your input is invalid, please try again.");
            //        }
            //    }
            //} while (validEntry == false);

            // Project 1 Code Challenge: Create a program that prompts the user to enter an integer value between 5 and 10. If the user enters a value
            // outside of this range, the program should display an error message and prompt the user to try again.
            // The program should continue to prompt the user until a valid input is received.
            string? readResult;
            string valueEntered = "";
            int numValue = 0;
            bool validNumber = false;

            Console.WriteLine("Enter an integer value between 5 and 10");

            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    valueEntered = readResult;
                }

                validNumber = int.TryParse(valueEntered, out numValue);

                if (validNumber == true)
                {
                    if (numValue <= 5 || numValue >= 10)
                    {
                        validNumber = false;
                        Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                }
            } while (validNumber == false);

            Console.WriteLine($"Your input value ({numValue}) has been accepted.");

            readResult = Console.ReadLine();

            // Project 2

            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for (int i = 0; i < stringsCount; i++)
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf(".");

                string mySentence;

                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {

                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);

                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);

                    // remove any leading white-space from myString
                    myString = myString.TrimStart();

                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");

                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }
        }
    }
}
