using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal
    {
        string Name { get=> Name; set => Name = value; }
        int Age { get => Age; set => Age = value; }
        int Weight { get => Weight; set => Weight = value; }
        string Colour { get => Colour; set => Colour = value; }
        public bool IsTheAnimalFeeded { get => IsTheAnimalFeeded; set => IsTheAnimalFeeded = value; }

        public Animal(string name, int age, int weight, string colour, bool isTheAnimalFeeded)
        {

            Name = name;
            Age = age;
            Weight = weight;
            Colour = colour;
            IsTheAnimalFeeded = isTheAnimalFeeded;         
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Weight} " +
                   $"{Colour}" +
                   $"{IsTheAnimalFeeded}";
                   
        }


    }
}

