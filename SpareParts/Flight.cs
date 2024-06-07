using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Flight : Letishte
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (id == null) throw new ArgumentNullException("ID cannot be null!");
                id = value;
            }
        }
        private int countAvalableSeats;
        public int CountAvalableSeats
        {
            get { return countAvalableSeats; }
            set
            {
                if (countAvalableSeats < 0) throw new ArgumentOutOfRangeException("Count of the available seats cannot be below 0!");
                if (id == null) throw new ArgumentNullException("Seats cannot be null!");
                countAvalableSeats = value;
            }
        }
        private int countSoldTickets;
        public int CountSoldTickets
        {
            get { return countSoldTickets; }
            set
            {
                if (countSoldTickets < 0 || countSoldTickets > 400) throw new ArgumentOutOfRangeException("Sold tickets cannot be below 0 or over 400!");
                if (id == null) throw new ArgumentNullException("Tickets cannot be null!");
                countSoldTickets = value;
            }
        }
        public Flight(string name, string date, int id, int seats, int tickets) : base(name, date)
        {
            Id = id;
            CountAvalableSeats = seats;
            CountSoldTickets = tickets;
        }
        public override string ToString()
        {
            return $"Name AirPort: {Name}\nDate ot Flight: {DateOfTheFlight}\nID of the Flight: {Id}\nCount of the avelable seats: {CountAvalableSeats}\nCount of the sold tickets: {CountSoldTickets}";
        }
        public override double AverageSoldTickets()
        {
            return CountSoldTickets;
        }
    }
}
