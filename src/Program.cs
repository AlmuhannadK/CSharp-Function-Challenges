using System;

using System.Text;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            // Console.WriteLine("Challenge 1: String and Number Processor");

            // dynamic test = "hello";

            // //Console.WriteLine($"Type of this variable is: {}");
            // if (typeof(test) is string)
            // {

            //     Console.WriteLine("string");
            // }

            // static dynamic StringNumberProcessor(params dynamic[] something)
            // {
            //     if (typeof(something) is string)
            //     {
            //         StringBuilder sb = new StringBuilder();
            //         for (int i = 0; i < something.Length; i++)
            //         {
            //             sb.Append(something[i]);
            //             string resultString = sb.ToString();
            //             return resultString;
            //         }
            //     }
            //     else if (typeof(something) is int)
            //     {
            //         int total = 0;
            //         for (int i = 0; i < something.Length; i++)
            //         {
            //             total += something[i];
            //         }
            //         return total;
            //     }
            //     else
            //     {
            //         return null;
            //     }
            // }









            /*
            /// Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            int num1 = 25, num2 = 30;
            int num 3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";
            

                          
            SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            SwapObjects(str3, str4); // Error: Length must be more than 5

            SwapObjects(true, false); // Error: Upsupported data type
            SwapObjects(ref num1, str1); // Error: Objects must be of same types

            Console.WriteLine($"Numbers: {num1}, {num2}");
            Console.WriteLine($"Strings: {str1}, {str2}");
            */


            /// Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game");

            void GuessingGame()
            {
                Random random = new Random();
                bool playAgain = true;
                int min = 1;
                int max = 50;
                int guess;
                int number;
                int attempts;

                while (playAgain)
                {
                    guess = 0;
                    attempts = 0;
                    number = random.Next(min, max + 1);

                    while (guess != number)
                    {
                        Console.WriteLine("Please enter a number between 1 - 100 :");
                        guess = int.Parse(Console.ReadLine());
                        Console.WriteLine($"You guesses: {guess}");
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
                            playAgain = false;
                        }
                    }



                }
            }

            GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`



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
