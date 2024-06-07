using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class DateComparer:IComparer<Flight>
    {
        public int Compare(Flight flight1, Flight flight2)
        {
            if (flight1==null||flight2==null)
            {
                throw new ArgumentNullException("Objects being compared canno be null");
            }
            return string.Compare(flight1.DateOfTheFlight, flight2.DateOfTheFlight);
        }
    }
}
