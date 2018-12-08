using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zoo
{
    class Zoo
    {
        public List<TerritoryType> Territory { get; private set; } 
        public Visitors Visitors { get; private set; }


        public Zoo()
        {
            Territory = new List<TerritoryType>();
            Visitors = new Visitors();
        }

    }
    
}
        