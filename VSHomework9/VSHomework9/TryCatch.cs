using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VSHomework9
{
    public static class TryCatch
    {
        public static int ConvertToInt(this string str) {

            try
            {
                return Int32.Parse(str);

            }
            catch(Exception ex)
            {
                if (ex is FormatException)
                {
                    Console.WriteLine("Given string has wrong format");
                }
                else if (ex is OverflowException) {
                    Console.WriteLine("Given number is bigger than it's possible to convert!");
                }

                Thread.Sleep(3000);
                throw new Exception("Conversion failed");

            }
                  
        } 

    }
}
