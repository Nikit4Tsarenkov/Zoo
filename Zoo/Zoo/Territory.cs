using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public enum TerritoryType
    {
        stable,
        primateHouse,
        terrarium
    }

    class Territory
    {
        public TerritoryType Type { get; private set; }
        public Visitors Visitors { get; private set; }

        public Territory()
        {
            Visitors.GenerateVisitors();
        }


    }
}
