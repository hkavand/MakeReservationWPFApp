using mvvmtest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvmtest.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public ICommand MakeReservationCommand { get; }
        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "hkstefan", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 2), "hk", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 4), "joe rogan", DateTime.Now, DateTime.Now)));
        }
    }
}
