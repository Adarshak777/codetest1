using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetest1
{
    class PassengerExpection : Exception
    {
        public PassengerExpection(string msg) : base(msg)
        {

        }
    }
    class Passenger
    {
        int Age;
        string Name;
        string dateoftravel;
        int no_of_tickets;


        public Passenger(int age, string name, string date_travel)
        {
            this.Age = age;
            this.Name = name;
            this.no_of_tickets = no_of_tickets;
            this.dateoftravel = date_travel;

        }

        public void TicketBooking(int no_of_Tickets)

        {
            this.no_of_tickets = no_of_Tickets;
            Console.WriteLine($"The passenger details is Age {Age}, Name is {Name}, Date of travel is {dateoftravel}, no.of tickets is {no_of_Tickets}");
            if (no_of_Tickets > 5)
            {
                throw (new PassengerExpection("Can't book more than 5 tickets"));
            }
            else
            {
                Console.WriteLine("Tickets booked successfully");
            }
        }
    }
    internal class TestClass
    {
        static void Main(string[] args)
        {

            Passenger pss1 = new Passenger(23, "adarsh", "16/06/2021");

            try
            {
                pss1.TicketBooking(4);
            }
            catch (PassengerExpection pe)
            {
                Console.WriteLine(pe.Message);
            }

            Console.Read();
        }
    }
















}
