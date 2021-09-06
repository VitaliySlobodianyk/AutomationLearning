using System;
using System.Collections.Generic;

namespace VSHomework04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task01();
            //Task02();
            //Task03();
              Task04();
        }

        public static void Task01()
        {
            int arrayLength = 7;
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                try
                {
                    Console.WriteLine("Enter a  number");
                    array[i] = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Number is incorrect");
                }
            }
            Console.WriteLine(PrintArray(array));

        }

        public static void Task02()
        {

            int arrayLength = 5;
            int[] array = new int[arrayLength];
            int currentIndex = 0;
            while (currentIndex < array.Length)
            {
                try
                {
                    Console.WriteLine($"Enter a {currentIndex + 1} number of array");
                    int numberToInsert = Int32.Parse(Console.ReadLine());
                    if (Array.IndexOf(array, numberToInsert) == -1)
                    {
                        array[currentIndex] = numberToInsert;
                        currentIndex++;
                    }
                    else
                    {
                        Console.WriteLine("Entered number already exists in the array");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Number is incorrect");

                }
            }
            Array.Sort(array);
            Console.WriteLine(PrintArray(array));

        }


        public static void Task03()
        {
            List<int> list = new List<int>();
            string enteredCommand;
            do
            {

                Console.WriteLine($"Enter a number to insert to the list (\"exit\" - for exit):");
                enteredCommand = Console.ReadLine();
                if (enteredCommand != "exit")
                {
                    try
                    {
                        int numberToInsert = Int32.Parse(enteredCommand);
                        list.Add(numberToInsert);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Entered data is incorrect");
                    }
                }
            } while (enteredCommand != "exit");

            List<int> uniqueNumbers = new List<int>();

            list.ForEach((int element) => { if (!uniqueNumbers.Contains(element)) { uniqueNumbers.Add(element); } });
            Console.WriteLine(PrintArray(uniqueNumbers.ToArray()));

        }

        public static void Task04() {
            List<int> list = new List<int>() {1,3,5,7,3,45,7,54,57,4,0,5,7,7,4,3,2 };
            Console.WriteLine(PrintArray(list.ToArray()));
            Console.WriteLine($"Length is: {list.Count}");

            list.RemoveAt(4);
            list.Insert(4, 38);
            Console.WriteLine(PrintArray(list.ToArray()));

            Console.WriteLine(list[6]);

            list.Add(12);
            Console.WriteLine(PrintArray(list.ToArray()));

            list.AddRange( new int[]{ 1,8,16} );
            Console.WriteLine(PrintArray(list.ToArray()));

            list.Reverse();
            Console.WriteLine(PrintArray(list.ToArray()));

            Console.WriteLine(" List contains 38:" + list.Contains(38));

            Console.WriteLine("First Index of 7:" + list.IndexOf(7));
            Console.WriteLine(PrintArray(list.ToArray()));

            list.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(PrintArray(list.ToArray()));

            list.Sort();
            Console.WriteLine(PrintArray(list.ToArray()));
        }


        public static string PrintArray<T>(T[] array)
        {
            string result = "";
            if (array.Length > 0) {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    result += array[i] + ", ";
                }
                result += array[array.Length - 1] + ".";
            }
            return result;
        }
    }
}
