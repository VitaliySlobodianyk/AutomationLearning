using System;

namespace VSHomework3
{
    // Class which helps with number range problems
    public class Range
    {
        public int min { get; private set; }
        public int max { get; private set; }

        public Range(int min, int max)
        {
            this.min = min;
            this.max = max;

        }

        public bool ISInRange(int number)
        {
            return number > min && number < max;
        }

    }
    class Program
    {
        public enum TypesOfPhoto
        {
            Landscape,
            Portrait,
            Square
        }


        static void Main(string[] args)
        {

            //Task1
            ISNumberInRange(new Range(1, 10));
            //Task2
            Compare2Numbers();
            //Task3
            GetTypeOfPhoto();
            //Task4
            SpeedCameraMonitor();


        }
       
        //Task1
        public static void ISNumberInRange(Range range)
        {
            int number;
            Console.WriteLine("Enter a Number:");
            Int32.TryParse(Console.ReadLine(), out number);

            if (range.ISInRange(number))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Inalid");
            }
        }

        // Task 2
        public static void Compare2Numbers()
        {
            int number1, number2;
            Console.WriteLine("Enter Number1:");
            Int32.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("Enter Number2:");
            Int32.TryParse(Console.ReadLine(), out number2);

            if (number1 != number2)
            {
                if (GetMaxNumber(number1, number2) == number1)
                {
                    Console.WriteLine($"{number1} is bigger.");
                }
                else
                {
                    Console.WriteLine($"{number2} is bigger.");
                }
            }
            else
            {
                Console.WriteLine("Numbers are Equal!");
            }

        }

        public static int GetMaxNumber(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }

        // Task 3 
        public static void GetTypeOfPhoto() {

            int width, height;
            Console.WriteLine("Enter width of photo:");
            Int32.TryParse(Console.ReadLine(), out width);

            Console.WriteLine("Enter height of photo:");
            Int32.TryParse(Console.ReadLine(), out height);

            Console.WriteLine($"Photo is {LandscapeOrPortrait(width, height)}");
        }

        // Task 3 
        public static TypesOfPhoto LandscapeOrPortrait(int width, int height) {
            if (width == height) {
                return TypesOfPhoto.Square;
            }
            else if (width>height) {
                return TypesOfPhoto.Landscape;
            }
            else {
                return TypesOfPhoto.Portrait;
            }                
        }

        //Task4
        public static void SpeedCameraMonitor() {
            int allowedSpeed, currentSpeed;
            Console.WriteLine("Enter allowed Speed:");
            Int32.TryParse(Console.ReadLine(), out allowedSpeed);

            Console.WriteLine("Enter cuurent speed of the car:");
            Int32.TryParse(Console.ReadLine(), out currentSpeed);


            int determinentPoints = GetDeterminentPoints(allowedSpeed, currentSpeed);
            Console.WriteLine(CameraCheck(determinentPoints));
            if (determinentPoints != 0) {
                Console.WriteLine($"Determinent points: {determinentPoints}");
            }

        }

        //Task4

        public static int GetDeterminentPoints(int allowedSpeed, int currentSpeed)
        {

            if (currentSpeed <= allowedSpeed)
            {
                // returning 0 because there is no speed limit violation
                return 0;
            }
            else {
                // returning determinent points
                return (currentSpeed - allowedSpeed) / 5;
            
            }
        }

        public static string CameraCheck(int determinentPoints) {


            if (determinentPoints == 0)
            {
                return "No Violation";
            }
            else if (determinentPoints < 12)
            {
                return "Speed limit violation.";
            }
            else {
                return "License Suspended";
            }

        }
        

    }
}
