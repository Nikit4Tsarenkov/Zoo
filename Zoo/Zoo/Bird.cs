using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public enum ExistingTypesOfBirds
    {
        eagle,
        parrot,
        owl
    }

    internal class Bird : Animal

    {
        ExistingTypesOfBirds TypeBirds { get => TypeBirds; set => TypeBirds = value; }
        public Bird(string name, int age, int weight, string colour, bool isTheAnimalFeeded, ExistingTypesOfBirds typeBirds) : base(name, age, weight, colour, isTheAnimalFeeded)
        {
            TypeBirds = typeBirds;
        }
        public override string ToString()
    
        {
            return base.ToString() + $" ";
        }
    }
}
