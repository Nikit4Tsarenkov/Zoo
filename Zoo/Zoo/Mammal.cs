using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
        public enum ExistingTypesOfMammals
    {
        tiger,
        lynx,
        badger,
    }

    internal class Mammal : Animal
        
    {
        ExistingTypesOfMammals TypeMammals { get => TypeMammals; set => TypeMammals = value; } 

        public Mammal(string name, int age, int weight, string colour, bool isTheAnimalFeeded, ExistingTypesOfMammals typeMammals) : base(name, age, weight, colour, isTheAnimalFeeded)
        {
            TypeMammals = typeMammals;   
        }
        public override string ToString()
        {
            return base.ToString() + $" ";
        }
    }
}
