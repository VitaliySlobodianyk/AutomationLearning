using System;

namespace VSHomework9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4; //task01
            Console.WriteLine($"{num} number");
            num.Square();
            Console.WriteLine($"{num} number");

            string str = "str"; //task 02
            string reversed = str.Reverse();
            Console.WriteLine($"{str} - reversed: {reversed}");

            string num1 = "213";
            string num2 = "213.56abc";
            string num3 = "2147483648";

            //Console.WriteLine($"{num1} - {num1.ConvertToInt()}");
           // Console.WriteLine($"{num2} - {num2.ConvertToInt()}");
              Console.WriteLine($"{num3} - {num3.ConvertToInt()}");
        }
    }
}
