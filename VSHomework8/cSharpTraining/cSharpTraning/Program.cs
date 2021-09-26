using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharpTraning
{
    class Program
    {
        private static Person[] persons;
        static void Main(string[] args)
        {
            persons = new Person[]
            {
                new Person
                {
                    Year = 1988,
                    Name = "Vasia",
                    Cars = new Car[]
                    {
                        new Car { Year = 2010, Name = "BMW", Color = "yellow" },
                        new Car { Year = 1990, Name = "BMW", Color = "blue" },
                    }
                },
                new Person
                {
                    Year = 2020,
                    Name = "Kostia",
                    Cars = new Car[]
                    {
                        new Car { Year = 2021, Name = "Toyota", Color = "black" },
                        new Car { Year = 2001, Name = "BMW", Color = "blue" },
                        new Car { Year = 2021, Name = "Mazda", Color = "white" },
                        new Car { Year = 2019, Name = "Mazda", Color = "white" }
                    },
                },
                new Person
                {
                    Year = 2005,
                    Name = "Kate",
                    Cars = new Car[]
                    {
                        new Car { Year = 2021, Name = "Toyota", Color = "black" },
                        new Car { Year = 2001, Name = "BMW", Color = "white" },
                        new Car { Year = 1999, Name = "Toyota", Color = "black" },
                        new Car { Year = 2010, Name = "BMW", Color = "blue" },
                        new Car { Year = 2005, Name = "Mazda", Color = "white" }
                    },
                },
            };

            Task5();
        }

        private static void Task1()
        {
            // Select Person Name (dont need to write in console)
            // Where Year>2000 And Name contain "t"
            List<string> result = persons
                .Where(person => person.Year > 2000 && person.Name.Contains("t"))
                .Select(person => person.Name)
                .ToList();
        }

        private static void Task2()
        {
            // Select Person.Name (dont need to write in console)
            // Where Any Car.Year less then Person.Year
            List<string> result = persons
                .Where(person => person.Cars.ToList().Any(car => car.Year < person.Year))
                .Select(person => person.Name)
                .ToList();
        }

        private static void Task3()
        {
            // Select Person (dont need to write in console)
            // Where Cars count (with the same collor) > 1   
            List<Person> result = persons.ToList()
                .Where(person => person.Cars
                                            .GroupBy(car => car.Color)
                                            .Any(carGroupedList => carGroupedList.Count()>1))
                .ToList();
        }

        private static void Task4()
        {
            // Select Person (dont need to write in console)
            // Where new Cars count (Year>2016) > 1
            List<Person> result = persons.ToList()
               .Where(person => person.Cars
                                           .Where(car => car.Year > 2016).ToList().Count > 1)
               .ToList();
        }

        private static void Task5()
        {
            // !!! Increased complexity !!! - it is not necessar
            // Create method to check that Cars almost Equal (2 parameters the same (Year, Collor, Name))
            // Select Person (dont need to write in console)
            // With this car.
            // Hint: You can use the extension method, Equal method. (But we will study them later.)            
            List<Person> result = persons
              .Where(person => person.Cars
                    .Where((carToCompare, index) => person.Cars.ToList().GetRange(index + 1, person.Cars.Length - index - 1)
                            .Any(car => carToCompare.Equal(car)))
                    .ToList().Count>=1)
              .ToList();

            result.ForEach(person => Console.WriteLine(person.Name));
        }
    }
}
