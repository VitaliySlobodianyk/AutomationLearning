using System;
using System.Collections.Generic;

namespace VSHomework4._2
{
    class Program
    {
       
      
        static void Main(string[] args)
        {
            //Task01();
            //Task02();
            //Task03();
            //Task04();
            Task05();
        }

        // 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
        public static void Task01()
        {
            int lowerBound = 0;
            int upperBound = 100;
            int numberToFindDivisibles = 3;
            int divisibleCount = 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (i % numberToFindDivisibles == 0)
                {
                    divisibleCount++;
                }
            }

            Console.WriteLine($"Number of divisible by {numberToFindDivisibles} elements in range {lowerBound}-{upperBound} = {divisibleCount}");

        }


        // 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
        public static void Task02()
        {
            string command;

            double summ = 0;

            do
            {
                Console.WriteLine("Enter a number: (\"ok\" to exit)");
                command = Console.ReadLine();
                try
                {
                    if (command != "ok")
                    {
                        summ += Double.Parse(command);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Entered wrng number!");
                }
            } while (command != "ok");

            Console.WriteLine($"Sum of numbers: {summ}");

        }

        //Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void Task03()
        {

            long factorialResult = 1;

            Console.WriteLine("Enter a number for factorial calculation:");

            int factorialBase;
            Int32.TryParse(Console.ReadLine(), out factorialBase);
            if (factorialBase != 0)
            {
                for (int i = 2; i <= factorialBase; i++)
                {
                    factorialResult *= i;
                }

                Console.WriteLine($"Factorial Result: {factorialResult}");
            }
            else
            {
                Console.WriteLine("Entered wrong base of factorial!");
            }
        }

        // 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        public static void Task04()
        {
            Random random = new Random();
            int minValue = 1;
            int maxValue = 10;
            int chancesAmount = 4;

            int score = 0;
            int tries = 0;
            string exit;

            do
            {
                int randomizedNumber = random.Next(minValue, maxValue + 1);
                bool numbersAreEqual = false;
                Console.Clear();
                Console.WriteLine($"Randomized number: {randomizedNumber}");
                for (int i = 0; i < chancesAmount && !numbersAreEqual; i++)
                {

                    Console.WriteLine($"Tries Left: {chancesAmount - i}");
                    try
                    {
                        Console.WriteLine($"Guess number between ({minValue} - {maxValue})");
                        numbersAreEqual = Int32.Parse(Console.ReadLine()) == randomizedNumber;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Entered invalid value! -1 try!");

                    }

                }

                tries++;
                if (numbersAreEqual)
                {
                    score++;
                    Console.WriteLine($"You Won!\n Guessed number: {randomizedNumber}");

                }
                else
                {
                    Console.WriteLine($"You Lost!\n Guessed number: {randomizedNumber}");
                }

                Console.WriteLine($"Score:{score} \n Tries: {tries}");

                Console.WriteLine("Exit game? (yes for exit)");
                exit = Console.ReadLine();
            } while (exit != "yes");

            Console.WriteLine("Game Finished");
        }

        // 5- Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8. 
        public static void Task05()
        {

            string str = "1,2,3,33,45,65";

            int index = 0;

            List<int> numbers = new List<int>();

            int maxNumber = Int32.MinValue;

            while (index < str.Length)
            {

                string parsedNumber = "";
                while (  index < str.Length && Char.IsNumber(str[index]) )
                {
                    parsedNumber += str[index];
                    index++;
                }

                if (parsedNumber != String.Empty)
                {
                    numbers.Add(Int32.Parse(parsedNumber));
                }
                else
                {
                    index++;
                }


            }

            numbers.ForEach(number => Console.Write(number + " "));

        }

    }
}
