using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Visitors visitors = new Visitors();
            Console.WriteLine("Visitors at this day were: " + visitors.Amount);
            

             
         


        }
    }
}
