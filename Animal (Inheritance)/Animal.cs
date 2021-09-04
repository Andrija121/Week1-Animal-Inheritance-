using System;
using System.Collections.Generic;
using System.Text;

namespace Animal__Inheritance_
{
   abstract class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name)
        {
            this.name = name;
            age = 1;
        }
        public Animal(string name,int age)
        {
            
            this.name = name;

            
            if (age == 0)
                this.age = age +1;
            else
                this.age = age;
        }
        public abstract string Speak();
        public virtual void CelebrateBirthday()
        {
            if (age < 100)
                age++;
        }

        
        public override string ToString()
        {
            return name + " ( "+ age + " year )";
        }
    }

    class Cat:Animal
    {
        public Cat(string name):base(name)
        {
            
        }
        public Cat(string name,int age) : base(name,age)
        {
            this.name = name;
            this.age = base.age;
        }
        public override string Speak()
        {
            return "Meow";
        }



        public override void CelebrateBirthday() 
        {
            if(age<25)
            base.CelebrateBirthday();
        }
        public override string ToString()
        {
            return "Cat: " + base.ToString();
        }

    }

    class Dog  :Animal
    {
        public Dog(string name) : base(name)
        {
            
        }
        public Dog(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = base.age;
        }
        public override string Speak()
        {
            return "Wuf";
        }
        public override void CelebrateBirthday()
        {
            if (age < 20)
                base.CelebrateBirthday();
        }
        public override string ToString()
        {
            return "Dog: "+ base.ToString();
        }

    }

    class Turtle :Animal
    {
        public Turtle(string name) : base(name)
        {
            
        }
        public Turtle(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = base.age;
        }
        public override string Speak()
        {
            return "Pf";
        }
        public override string ToString()
        {
            return "Turtle: " + base.ToString();
        }
        public override void CelebrateBirthday()
        {
            if (age < 200)
                base.CelebrateBirthday();

        }
    }
}
