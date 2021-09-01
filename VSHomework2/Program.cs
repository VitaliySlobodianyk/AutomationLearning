using System;

namespace VSHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool stopFlag;
            bool usePreviousValue = false;
            double prevoiusValue = 0;

            do
            {
                double number1;

                if (!usePreviousValue)
                {
                    Console.WriteLine("Enter number1:");
                    Double.TryParse(Console.ReadLine(), out number1);
                }
                else
                {
                    number1 = prevoiusValue;
                }

                string operand;
                Console.WriteLine("Enter operand (+|-|*|:)");
                operand = Console.ReadLine();

                double number2 = 0;
                Console.WriteLine("Enter number2:");
                Double.TryParse(Console.ReadLine(), out number2);

                double result = 0;

                switch (operand)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case ":":
                        result = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("Wrong Operation");
                        break;
                }

                Console.WriteLine($"Result is: {result}");

                Console.WriteLine("Continue to caclulate (1/0)?");
                try
                {
                    stopFlag = Convert.ToBoolean(Int32.Parse(Console.ReadLine()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong Symbol!");
                    stopFlag = true;
                }

                Console.WriteLine("Save result for next operation (1/0)?");
                try
                {
                    usePreviousValue = Convert.ToBoolean(Int32.Parse(Console.ReadLine()));

                    if (usePreviousValue)
                    {
                        prevoiusValue = result;
                    }
                    else
                    {
                        prevoiusValue = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong Symbol!");
                    stopFlag = true;
                    prevoiusValue = 0;
                }

            } while (stopFlag);
        }
    }
}
