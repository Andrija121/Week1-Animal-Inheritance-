using System;

namespace Animal__Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Garfield ", 20);
            Dog dog = new Dog("Lesie ", 30);
            Turtle turtle = new Turtle("niki ");

            cat.CelebrateBirthday();
            dog.CelebrateBirthday();
            
            Console.WriteLine(cat.ToString());
            Console.ReadLine();
            Console.WriteLine(dog.ToString());
            Console.ReadLine();
            Console.WriteLine(turtle.ToString());
            Console.ReadLine();
        }
    }
}
