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
            //done

            if (age == 0)
            { 
                    this.age = age +1;
            }
            else
                this.age = age;
        }
        public virtual void CelebrateBirthday()
        {
            if (age < 100)
                age++;
        }

        //ToString je metoda koja se nasledjuje iz Object klase, treba da koristis override
        //done

        public override string ToString()
        {
            //jel ove zagrade treba da se ispisu na konzoli? Proveri da li se ispisuju i koji se format trazi
            //done
            return name + " ( "+ age + " year )";
        }
    }

    class Cat:Animal
    {
        public Cat(string name):base(name)
        {
            //ovo se vec desava u konstruktoru parent klase. Proveri sta ce se desiti ako ovo izbacis
            //stavi breakpoint i na konstuktor parent klase i ovde pa kreiraj macku bez godina i vidi sta se desava pa zakljuci da li ti treba
            //done

        }
        public Cat(string name,int age) : base(name,age)
        {
            this.name = name;
            this.age = base.age;
        }

        //Obzirom da se ova metoda sa istim nazivom i parametrima koristi u parent klasi treba da radis override
        //done

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
            //ovo se vec desava u konstruktoru parent klase. Proveri sta ce se desiti ako ovo izbacis
            //stavi breakpoint i na konstuktor parent klase i ovde pa kreiraj psa bez godina i vidi sta se desava pa zakljuci da li ti treba
            //done

        }
        public Dog(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = base.age;
        }

        //Obzirom da se ova metoda sa istim nazivom i parametrima koristi u parent klasi treba da radis override
        //done

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
            //ovo se vec desava u konstruktoru parent klase. Proveri sta ce se desiti ako ovo izbacis
            //stavi breakpoint i na konstuktor parent klase i ovde pa kreiraj psa bez godina i vidi sta se desava pa zakljuci da li ti treba
            //done
            
        }
        public Turtle(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = base.age;
        }
        public override string ToString()
        {
            return "Turtle: " + base.ToString();
        }
    }
}
