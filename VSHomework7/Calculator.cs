using System;
using System.Collections.Generic;
using System.Text;

namespace VSHomework7
{

    class Calculator
    {
        private static Calculator Instance;

        public double Memory {  get; private set; }

        private Calculator() { } // Block calling out constructor - needed for proper singleton implementation

        public static Calculator GetInstance() {
            if (Instance == null) {
                Instance = new Calculator();
            }

            return Instance;
        }

        public double ExecuteAction(string action, double var1, double var2 = 0, bool useMemory = false) {

            switch (action)
            {
                case "+":
                    return Add(var1, var2, useMemory);
                case "-":
                    return Substract(var1, var2, useMemory);
                case "*":
                    return Multipy(var1, var2, useMemory);
                case "/":
                    return Divide(var1, var2, useMemory);
                default:
                    return 0;
                    
            }

        }

        public void Clear() {
            Memory = 0;
        }

        public double Add(double var1, double var2=0, bool useMemory=false) {
            if (useMemory)
            {
                Memory += var1;
            }
            else {
                Memory = var1 + var2;
            }

            return Memory;

        }

        public double Substract(double var1, double var2 = 0, bool useMemory = false)
        {
            if (useMemory)
            {
                Memory -= var1;
            }
            else
            {
                Memory = var1 - var2;
            }

            return Memory;

        }

        public double Multipy(double var1, double var2 = 0, bool useMemory = false)
        {
            if (useMemory)
            {
                Memory *= var1;
            }
            else
            {
                Memory = var1 * var2;
            }

            return Memory;

        }

        public double Divide(double var1=0, double var2 = 0, bool useMemory = false)
        {
            if (useMemory)
            {
                Memory /= var2;
            }
            else
            {
                Memory = var1 / var2;
            }

            return Memory;

        }

    }


    static class CalculatorCLI {

        public static void Start()
        {
            Calculator calculator = Calculator.GetInstance();
            
            bool stopFlag;
            bool usePreviousValue = false;

            do
            {
                double number1;
                Console.WriteLine("Enter number1:");
                Double.TryParse(Console.ReadLine(), out number1);
                
                
                string operand;
               
                Console.WriteLine("Enter operand (+|-|*|/)");
                operand = Console.ReadLine();

                double number2 = 0;
                if (!usePreviousValue)
                {
                Console.WriteLine("Enter number2:");
                Double.TryParse(Console.ReadLine(), out number2); 
                }

                Console.WriteLine($"Result is: {calculator.ExecuteAction(operand,number1,number2,usePreviousValue)}");

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
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong Symbol!");
                    stopFlag = true;                    
                }

            } while (stopFlag);
        }
    }

    }

