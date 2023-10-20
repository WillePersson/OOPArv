using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    class Animal //baseclass
    {
        //Fields
        public string _name;
        public string _color;
        public int _legs;
        public int _weight;
        public int _age;

        public Animal(string name, string color, int legs, int weight, int age)//constructor
        {
            _name = name;
            _color = color;
            _legs = legs;
            _weight = weight;
            _age = age;
        }
        public void tryEscape() //Method
        {
            Console.WriteLine(_name + " försöker fly, det gick inte bra");
        }
        public void sleep() //Method
        {
            Console.WriteLine(_name + " sover");
        }
        public void awake() //Method
        {
            Console.WriteLine(_name + " vaknade");
        }
        public virtual void makeSound() //method
        {
            Console.WriteLine(_name + " låter på någe viss");
        }
        public virtual void AddInfo()
        {
            Console.WriteLine(_name +
                $" Färg: {_color} " +
                $"Antal Ben: {_legs} " +
                $"Vikt: {_weight} " +
                $"Ålder: {_age}");
        }
    }
    class Elephant : Animal //inheritance class from Animal
    {
        //Fields
        public int _horns;

        public Elephant(string name = "elefanten Dumbo", string color = "grå", int legs = 4,//cosntructor
        int weight = 500, int age = 20, int horns = 2) : base(name, color, legs, weight, age)
        {
            _horns = horns;
        }

        public virtual void waveTrunk() //Method
        {
            Console.WriteLine("Elefanten svingar på snabbeln");
        }
        public override void makeSound() //overiding method
        {
            Console.WriteLine("Elefanten låter genom snabbeln");
        }
        public override void AddInfo()
        {
            Console.WriteLine(_name +
                $" Färg: {_color} " +
                $"Antal Ben: {_legs} " +
                $"Vikt: {_weight} " +
                $"Ålder: {_age} " +
                $"Horn: {_horns}" );
        }
    }
    class Lion : Animal //inheritance class from Animal
    {
        //Fields
        public int _teeth;

        public Lion(string name = "Lejonet Tyr", string color = "Orange/bersh", int legs = 4,//constructor
            int weight = 60, int age = 7, int teeth = 22) : base(name, color, legs, weight, age)
        {
            _teeth = teeth;
        }

        public void Hungry() //Methods
        {
            Console.WriteLine("Lejonet är hungrig");
        }
        public override void makeSound() //overiding method
        {
            Console.WriteLine("Lejonet ryter");
        }
        public override void AddInfo()
        {
            Console.WriteLine(_name +
                $" Färg: {_color} " +
                $"Antal Ben: {_legs} " +
                $"Vikt: {_weight} " +
                $"Ålder: {_age} " +
                $"Tänder: {_teeth} ");


        }
    }
    class Zebra : Animal //inheritance class from Animal
    {
        //Fields
        public int _blackStripes;

        public Zebra(string name = "Zebran Doris", string color = "vit/svart", int legs = 4,
            int weight = 40, int age = 10, int blackStripes = 15) : base(name, color, legs, weight, age)
        {
            _blackStripes = blackStripes;
        }

        public void hide() //Methods
        {
            Console.WriteLine("Zebran tror inte han/hon syns längre");
        }
        public override void makeSound() //overiding method
        {
            Console.WriteLine("Zebran är sjuk så den låter inte så mycket");
        }
        public override void AddInfo()
        {
            Console.WriteLine(_name +
                $" Färg: {_color} " +
                $"Antal Ben: {_legs} " +
                $"Vikt: {_weight} " +
                $"Ålder: {_age} " +
                $"Svarta ränder: {_blackStripes}");
        }

    }
    class AfricanSavannahElephant : Elephant //inheritance class from Elephant
    {
        public double _lenghtofTrunk;//field

        public AfricanSavannahElephant(double lenghtofTrunk = 1.5, int horns = 2)
        {
            _lenghtofTrunk = lenghtofTrunk;
        }

        public override void waveTrunk() //Method
        {
            Console.WriteLine("Savana Elefanten svingar på snabbeln fort");
        }
        public override void makeSound() //Method
        {
            Console.WriteLine("Savana elefanten låter högt");
        }
        public override void AddInfo()
        {
            Console.WriteLine($"längd på snabbel:{_lenghtofTrunk}" +
                $" Antal horn: {_horns} ");
        }


    }
    class AfricanForestElephant : Elephant //inheritance class from Elephant
    {
        public int _lenght;//field

        public AfricanForestElephant(int lenght = 4, int horns = 2)
        {
            _lenght = lenght;
        }

        public override void waveTrunk() //Method
        {
            Console.WriteLine("Skogs Elefanten svingar på snabbeln sakta");
        }
        public override void makeSound() //Method
        {
            Console.WriteLine("Skogs elefanten låter inte så högt");
        }
        public override void AddInfo()
        {
            Console.WriteLine($"längd:{_lenght}" +
                $" Antal horn: {_horns} ");
        }

    }
}

