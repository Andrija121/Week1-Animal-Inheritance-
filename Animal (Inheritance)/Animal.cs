using System;
using System.Collections.Generic;
using System.Text;

namespace Animal__Inheritance_
{
    class Animal
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
                age = 1;
            else
            this.age = age;
        }
        public void CelebrateBirthday()
        {
            if (age < 100)
                age++;
        }
        public virtual string ToString()
        {
            return name + ( age + " year ");
        }
    }

    class Cat:Animal
    {
        public Cat(string name):base(name)
        {
            age = 1;
        }
        public Cat(string name,int age) : base(name,age)
        {

        }
        public void CelebrateBirthday()
        {
            if (age < 25)
                age++;
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
            age = 1;
        }
        public Dog(string name, int age) : base(name, age)
        {

        }
        public void CelebrateBirthday()
        {
            if (age < 20)
                age++;
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
            age = 1;
        }
        public Turtle(string name, int age) : base(name, age)
        {

        }
        public override string ToString()
        {
            return "Turtle: " + base.ToString();
        }
    }
}
