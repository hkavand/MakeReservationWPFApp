using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using mvvmtest.Models;
using mvvmtest.Exceptions;
using mvvmtest.ViewModels;
using mvvmtest.Stores;
using mvvmtest.Services;

namespace mvvmtest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("hk corp");
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = createReservationListingViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private MakeReservationViewModel createMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel, new NavigationService(_navigationStore, createReservationListingViewModel));
        }

        private ReservationListingViewModel createReservationListingViewModel()
        {
            return new ReservationListingViewModel(_hotel, new NavigationService(_navigationStore, createMakeReservationViewModel));
        }
    }
}
