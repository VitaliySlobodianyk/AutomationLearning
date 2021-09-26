using System;
using System.IO;

namespace VSHomework6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task01();
            //Task02();
        }

        public static void Task01() {

            DateTime date = DateTime.Now;
            date = date.AddDays(5);
            Console.WriteLine(date.ToLongDateString());
        }

        public static void Task02() {
            DateTime date = DateTime.Parse("26.01.1993 18:24:00");        
            date = DateTime.Parse( $"01.{date.Month}.{date.Year}");
            Console.WriteLine(date.ToShortDateString());
        }

        public static void Task03() {
            string path = "";
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine(lines[3]);
            Console.WriteLine(lines[3][5]);
        }
    }
}
