using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public abstract string MakeSound();
        public abstract string AnimalDetails();

        public virtual string Eat()
        {
            return "Animal is eating.";
        }

    }

    public class GenericAnimal : Animal
    {
        public override string MakeSound()
        {
            return "Generic animal sound";
        }

        public override string AnimalDetails()
        {
            return $"{Name}, {Age} years old, {Breed}";
        }
    }


    public class Dog : Animal
    {

        public override string MakeSound()
        {

            return "Woof!";
        }

        public override string AnimalDetails()
        {

            return $"Name: {Name}, Age: {Age}, Breed: {Breed}";
        }

    }
}

public class Cat : Animal
{

    public override string MakeSound()
    {

        return "Meow!";
    }

    public override string AnimalDetails()
    {

        return $"Name: {Name}, Age: {Age}, Breed: {Breed}";
    }
}

public class Mammal : Animal
{
    public string GiveBirth()
    {
        return "Mammal is giving birth.";
    }

    public override string MakeSound()
    {

        return "Woof";
    }

    public override string AnimalDetails()
    {

        return $"Name: {Name}, Age: {Age}, Breed: {Breed}";
    }
}


public class Human : Mammal
{
    public string Talk()
    {
        return "Human is talking.";
    }
}


