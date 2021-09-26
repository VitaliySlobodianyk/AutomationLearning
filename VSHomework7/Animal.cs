using System;
using System.Collections.Generic;
using System.Text;

namespace VSHomework7
{
    public interface ILivingCreature
    {
        public void Die();

    }

    interface ISwimable
    {
        public void Swim();
    }
    interface IRunnable
    {
        public void Run();
    }

    interface IClimbable
    {
        public void Climb();
    }


    public abstract class Animal : ILivingCreature
    {
        protected static List<Animal> Population= new List<Animal>();


        public string Name { private set; get; }

        public int Age { private set; get; }

        public abstract ILivingCreature Birth();
       

        public void Die()
        {
            Console.WriteLine("Died");
        }

        public abstract void Eat();

    }

    public class Cat : Animal, IRunnable, IClimbable
    {
        private static new List<Cat> Population = new List<Cat>();

        public override ILivingCreature Birth()
        {
            
            Cat newborn = new Cat();
            Animal.Population.Add(newborn);
            Population.Add(newborn);
            return newborn;
        }

        public void Climb()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Dog : Animal, IRunnable, IClimbable, ISwimable
    {
        private static new List<Dog> Population = new List<Dog>();

        public override ILivingCreature Birth()
        {
            Dog newborn = new Dog();
            Animal.Population.Add(newborn);
            Population.Add(newborn);
            return newborn;
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Climb()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }





}
