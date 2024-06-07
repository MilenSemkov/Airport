using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public abstract class Letishte:IDateOfTheFlight
    {
        public string Name { get; set; }
        public string DateOfTheFlight { get; set; }
        protected Letishte(string name, string date)
        {
            Name = name;
            DateOfTheFlight = date;
        }
        public abstract double AverageSoldTickets();

    }
}
