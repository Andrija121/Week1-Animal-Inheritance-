using System;

namespace Animal__Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Garfield ",0);
            Dog dog = new Dog("Lesie ", 30);
            Turtle turtle = new Turtle("niki ",0);


            //pitanje za razmisljanje. Da li kornjaca moze da slavi rodjendan?

            //Moze, jer joj parent klasa ima metodu CelebrateBirthday, ali ako pogledamo primer za klasu person, male i female
            //oni su imali metode koje samo jedna od te dve klase moze da izvrsi, a u zadatku ne kaze da kornjaca moze da slavi rodjendan

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
