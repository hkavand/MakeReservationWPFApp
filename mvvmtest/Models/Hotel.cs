using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmtest.Models
{
    class Hotel
    {
        private readonly ReservationBook _reservationBook;
        
        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public  IEnumerable<Reservation> GetReservations()
        {
            return _reservationBook.GetReservations(); 
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
