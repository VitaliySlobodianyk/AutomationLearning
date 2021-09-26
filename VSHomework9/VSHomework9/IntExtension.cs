using System;
using System.Collections.Generic;
using System.Text;

namespace VSHomework9
{
    public static class IntExtension
    {
        public static void Square(this ref int i) {
            i *= i;
        }

    }
}
