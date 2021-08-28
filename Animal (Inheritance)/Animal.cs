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

            //cemu sluzi ova provera? sta se desi ako stavis da zivotinja ima nula godina. Testiraj!!!
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

        //ToString je metoda koja se nasledjuje iz Object klase, treba da koristis override
        public virtual string ToString()
        {
            //jel ove zagrade treba da se ispisu na konzoli? Proveri da li se ispisuju i koji se format trazi
            return name + ( age + " year ");
        }
    }

    class Cat:Animal
    {
        public Cat(string name):base(name)
        {
            //ovo se vec desava u konstruktoru parent klase. Proveri sta ce se desiti ako ovo izbacis
            //stavi breakpoint i na konstuktor parent klase i ovde pa kreiraj macku bez godina i vidi sta se desava pa zakljuci da li ti treba
            age = 1;
        }
        public Cat(string name,int age) : base(name,age)
        {

        }

        //Obzirom da se ova metoda sa istim nazivom i parametrima koristi u parent klasi treba da radis override
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
            //ovo se vec desava u konstruktoru parent klase. Proveri sta ce se desiti ako ovo izbacis
            //stavi breakpoint i na konstuktor parent klase i ovde pa kreiraj psa bez godina i vidi sta se desava pa zakljuci da li ti treba
            age = 1;
        }
        public Dog(string name, int age) : base(name, age)
        {

        }

        //Obzirom da se ova metoda sa istim nazivom i parametrima koristi u parent klasi treba da radis override
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
            //ovo se vec desava u konstruktoru parent klase. Proveri sta ce se desiti ako ovo izbacis
            //stavi breakpoint i na konstuktor parent klase i ovde pa kreiraj psa bez godina i vidi sta se desava pa zakljuci da li ti treba
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
