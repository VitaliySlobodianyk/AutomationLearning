using System;

namespace VSHomework7
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculatorCLI.Start();


            Dog dog1 = new Dog();

            Cat cat1 = new Cat();
            Cat cat2 = (Cat)cat1.Birth();

            Console.ReadKey();
        }
    }
}
