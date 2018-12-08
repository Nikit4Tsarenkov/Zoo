using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public enum ExistingTypesOfReptiles
    {
        alligator,
        snake,
        Lizard        
    }
    internal class Reptile : Animal
    {
        ExistingTypesOfReptiles TypeReptiles { get => TypeReptiles; set => TypeReptiles = value; }
        
        public Reptile(string name, int age, int weight, string colour, bool isTheAnimalFeeded, ExistingTypesOfReptiles typeReptiles) : base(name, age, weight, colour, isTheAnimalFeeded)
        {
            TypeReptiles = typeReptiles;
        }
        public override string ToString()
        {
            return base.ToString() + $"" ;
        }
    }
}
