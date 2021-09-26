using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpTraning
{
    public class Car 
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }

    public static class CarExtension {

        public static bool Equal(this Car car1, Car car2 ) {

       
            int similarParameters = 0;

            similarParameters += Convert.ToInt32(car1.Color == car2.Color);
            similarParameters += Convert.ToInt32(car1.Name == car2.Name);
            similarParameters += Convert.ToInt32(car1.Year == car2.Year);

            return similarParameters >= 2;
        }
    }
}
