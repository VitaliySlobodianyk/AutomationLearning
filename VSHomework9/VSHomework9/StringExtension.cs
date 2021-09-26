using System;
using System.Collections.Generic;
using System.Text;

namespace VSHomework9
{
   public static class StringExtension
    {
        public static string Reverse(this string value) {
           char[] symbols = value.ToCharArray();
            for (int i = 0; i < symbols.Length/2; i++)
            {
                char temp = symbols[i];
                symbols[i] = symbols[symbols.Length - i - 1];
                symbols[symbols.Length - i - 1] = temp;
            }
           return new String(symbols);

        }
    }

}
