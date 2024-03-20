using System;
using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");

            StringNumberProcessor("Almuhannad", 44, "Khalid", 500, 8000, "Almhari", 10000);

            static void StringNumberProcessor(params object[] args)
            {
                StringBuilder sb = new StringBuilder();
                int totalAmount = 0;

                foreach (var arg in args)
                {
                    if (arg is string str)
                    {
                        sb.Append(str);
                        sb.Append(" ");
                    }
                    if (arg is int number)
                    {
                        totalAmount += (int)number;
                    }
                }
                Console.WriteLine($"{sb}; {totalAmount}");
            }
            */

            /// Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            int num1 = 25, num2 = 30;
            int num3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";

            // testing boolean arguments
            bool test1 = true, test2 = false;
            SwapObjects(ref test1, ref test2); // Error: Upsupported data type

            //SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            //SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            //SwapObjects(ref str1, ref str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            //SwapObjects(ref str3, ref str4); // Error: Length must be more than 5

            //SwapObjects(ref num1, ref str1); // Error: Objects must be of same types

            //SwapObjects(ref str1, ref str3);

            static void SwapObjects<T>(ref T value1, ref T value2)
            {
                if (value1 is string str1 && value2 is string str2)
                {
                    if (str1.Length > 5 && str2.Length > 5)
                    {
                        Console.WriteLine($"Before swap: value1 -> {str1}, value2 -> {str2}");
                        string temp = str1;
                        str1 = str2;
                        str2 = temp;
                        Console.WriteLine($"After swap: value1 -> {str1}, value2 -> {str2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Length must be more than 5");
                    }
                }
                else if (value1 is int num1 && value2 is int num2)
                {
                    if (num1 > 18 && num2 > 18)
                    {
                        Console.WriteLine($"Before swap: value1 -> {num1}, value2 -> {num2}");
                        int temp = num1;
                        num1 = num2;
                        num2 = temp;
                        Console.WriteLine($"After swap: value1 -> {num1}, value2 -> {num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Value must be more than 18");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Unsuported type");
                }
            }


            /// Challenge 3: Guessing Game

            /*
                        Console.WriteLine("\nChallenge 3: Guessing Game");

                        void GuessingGame()
                        {
                            Random random = new Random();
                            string? input = "";
                            const int MIN = 1;
                            const int MAX = 100;
                            int guess;
                            int number;
                            int attempts;

                            while (true)
                            {
                                if (input.ToLower() == "quit")
                                {
                                    break;
                                }
                                number = random.Next(MIN, MAX + 1);
                                Console.WriteLine("Welcome to the Guessing Game!");
                                guess = 0;
                                attempts = 0;
                                while (guess != number)
                                {
                                    Console.WriteLine("Please enter a number between 1 - 100 :");
                                    guess = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Your guess is: {guess}");
                                    if (guess > number)
                                    {
                                        Console.WriteLine($"{guess} is ABOVE the number");
                                        attempts++;

                                    }
                                    else if (guess < number)
                                    {
                                        Console.WriteLine($"{guess} is BELOW the number");
                                        attempts++;
                                    }
                                    if (guess == number)
                                    {
                                        Console.WriteLine($"Wow you guessed it right! the number was {number}. Attempts made: {attempts}");
                                        Console.WriteLine($"Wanna play again? (or type \"Quit\" to exit.)");
                                        input = Console.ReadLine();
                                    }
                                }
                            }
                        }
                        GuessingGame();
            */


            /*
            /// Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
            */
        }
    }
}
