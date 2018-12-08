using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{


    class Visitors
    {
        Random random = new Random();
        public int Amount { get; private set; }
        TerritoryType TerritoryInZoo { get => TerritoryInZoo; set => TerritoryInZoo = value; }
        public Visitors(TerritoryType territoryInZoo)
        {
            TerritoryInZoo = territoryInZoo;     
        }
        
        public void GenerateVisitors()
        {
            int CountOfVisitorsAtCurrentDay;
            
            DateTime dateT = DateTime.Now;

            if (dateT.DayOfWeek == DayOfWeek.Saturday && dateT.DayOfWeek == DayOfWeek.Sunday)
            {
                CountOfVisitorsAtCurrentDay = GenerateAmountOfVisitorsOnFreeDays();
                Amount = CountOfVisitorsAtCurrentDay;
            }
            else
            {
                CountOfVisitorsAtCurrentDay = GenerateAmountOfVisitorsOnWorkingDays();
                Amount = CountOfVisitorsAtCurrentDay;
            }


        }
        
        private int GenerateAmountOfVisitorsOnWorkingDays()
        {
            return random.Next(250, 500);
        }
        private int GenerateAmountOfVisitorsOnFreeDays()
        {
            return random.Next(750,1500);
        }
        private int GenerateAmountOfVisitorsOnHolidays()
        {
            return random.Next(1250,1750);
        }



        public Visitors()
        {
            GenerateVisitors();
        }
    }
}
