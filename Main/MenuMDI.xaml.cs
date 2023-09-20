using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WeddingPlanner;

namespace Main
{
    /// <summary>
    /// Interaction logic for MenuMDI.xaml
    /// </summary>
    public partial class MenuMDI : Window
    {
        private string name;
        private DispatcherTimer timer;
        public static StaffData StaffMakeBook;
        public MenuMDI(StaffData staff)
        {
            InitializeComponent();
            StaffMakeBook = staff;
            name = staff.S_Name;
            lblName.Content = $"Welcome {name}..";
        }

        
        private void GoToCustomerList(object sender, RoutedEventArgs e)
        {
            MainMenu.Content = "";
            MainMenu.Content = new CustomerMDI();

        }

        private void ToLogOut(object sender, RoutedEventArgs e)
        {

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Logout Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                MainWindow win = new MainWindow();
                win.Show();
                this.Close();

            }
            else
                return;
          
           
        }

        private void GoToBookingForm(object sender, RoutedEventArgs e)
        {

            MainMenu.Content = "";
            MainMenu.Content = new BookingMDI(StaffMakeBook);

        }

        private void GoToViewBooking(object sender, RoutedEventArgs e)
        {
            MainMenu.Content = "";
            MainMenu.Content  = new BookingViewMDI();
           
        }

        private void MainMenu_Loaded(object sender, RoutedEventArgs e)
        {
            MainMenu.Content=new StartWindow();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
             
            Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Show_Profit(object sender, RoutedEventArgs e)
        {
            
            MainMenu.Content = "";
            MainMenu.Content = new ProfitMDI();
        }
    }
}
