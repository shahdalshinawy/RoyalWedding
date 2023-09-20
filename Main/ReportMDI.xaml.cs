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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WeddingPlanner;

namespace Main
{
    /// <summary>
    /// Interaction logic for ReportMDI.xaml
    /// </summary>
    public partial class ReportMDI : Window
    {
        BookingData book;
        public ReportMDI(BookingData Bookreport)
        {
            InitializeComponent();
            book = Bookreport;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerName.Text = book.Customer.ToString();
            HallName.Text = book.Hall.ToString();      //null object hall eeror
            numofpeople.Text = book.Hall.NumOfPeople.ToString();
            payment.Text = book.B_GrdTotal.ToString();
            advance.Text = book.B_Advance.ToString();
            date.Text = book.B_Date.ToString();
            balance.Text = book.B_Balance.ToString();
            StaffName.Text = book.StaffBooking.S_Name;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
