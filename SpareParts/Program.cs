using System.Collections.Generic;

namespace Airport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.Write("How many flight you are going to input: ");
                int nOfFLight = int.Parse(Console.ReadLine());
                List<Flight> listOfFLight = new List<Flight>();
                for (int i = 0; i < nOfFLight; i++)
                {
                    Console.Write("Name of the Airport: ");
                    string name = Console.ReadLine();
                    Console.Write("Date of the FLight: ");
                    string date = Console.ReadLine();
                    Console.Write("ID of the Flight: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Count if the available seats: ");
                    int seat = int.Parse(Console.ReadLine());
                    Console.Write("COunt of the sold tickets: ");
                    int tickets = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Flight flight = new Flight(name, date, id, seat, tickets);

                    listOfFLight.Add(flight);
                }
                double sum = 0.0;
                foreach (var item in listOfFLight)
                {
                    sum = item.AverageSoldTickets() + sum;
                }
               
                Console.WriteLine("Average sum of the sold tickets is: " + sum / listOfFLight.Count);
                Console.WriteLine(" ");
                Console.WriteLine("Flight with availble seats: ");
                foreach (var item in listOfFLight)
                {
                    if (item.CountAvalableSeats > 0)
                    {
                        Console.WriteLine(item.ToString());
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine("All flights");
                foreach (var item in listOfFLight)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Lowes sold of the tickets: "+listOfFLight.Min(x => x.CountSoldTickets).ToString());
                Console.WriteLine(" ");
                Console.WriteLine("Sorted flights: ");
                listOfFLight.Sort(new DateComparer());
                foreach (var item in listOfFLight)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine(" ");
                }
                using (StreamWriter streamWriter = new StreamWriter("Poleti.txt"))
                {
                    streamWriter.WriteLine("Danni:");
                    listOfFLight.ForEach(x => streamWriter.WriteLine(x.ToString()));
                }
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
