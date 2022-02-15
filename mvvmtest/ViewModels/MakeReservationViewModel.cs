using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvmtest.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                onPropertyChanged(nameof(UserName));
            }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                onPropertyChanged(nameof(RoomNumber));
            }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                _floorNumber = value;
                onPropertyChanged(nameof(FloorNumber));
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                onPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                onPropertyChanged(nameof(EndDate));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel()
        {

        }
    }
}
