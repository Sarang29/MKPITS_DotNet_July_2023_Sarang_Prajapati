using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Animal_Machine_Test
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Sound()
        {

        }
    }
    public class Mammal:Animal
    {
        public Mammal(string name, int age):base(name,age)
        {
           
        }
    }

    public class Reptile:Animal
    {
        public Reptile(string name,int age):base(name,age)
        {
        }
    }

    public class Bird : Animal
    {
        public Bird(string name, int age):base(name,age)
        {
        }
    }

    public class Lion : Mammal
    {
        public Lion(string name,int age):base(name,age)
        { 
        }
        public override void Sound()
        {
            Console.WriteLine("Sound : Roar");
        }
    }

    public class Snake : Reptile
    {
        public Snake(string name,int age):base(name,age)
        {

        }
        public override void Sound()
        {
            Console.WriteLine("Sound : Phiss");
        }
    }

    public class Eagle : Bird
    {
        public Eagle(string name,int age):base(name,age)
        {

        }
        public override void Sound()
        {
            Console.WriteLine("Sound : Kuuuu");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Akash", 5);
            Snake snake = new Snake("Shivani", 6);
            Eagle eagle = new Eagle("Divya", 4);

            Animal[] animals = {lion,snake, eagle};

            foreach(var animal in animals)
            {
                Console.WriteLine($"Animal Name : {animal.Name},Age : {animal.Age}");
                animal.Sound();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
