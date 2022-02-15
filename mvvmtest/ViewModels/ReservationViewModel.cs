using mvvmtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmtest.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        public readonly Reservation _reservation;
        public string RoomID => "R:" +_reservation.RoomID?.RoomNumber.ToString() + " F:" + _reservation.RoomID?.FloorNumber.ToString();
        public string UserName => _reservation.UserName;
        public string StartDate => _reservation.StartTime.Date.ToString("d");
        public string EndDate => _reservation.EndTime.Date.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
