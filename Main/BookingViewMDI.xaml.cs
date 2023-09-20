using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeddingPlanner;

namespace Main
{
    /// <summary>
    /// Interaction logic for BookingViewMDI.xaml
    /// </summary>
    public partial class BookingViewMDI : System.Windows.Controls.UserControl
    {
        public BookingViewMDI()
        {
            InitializeComponent();
        }

        public static BookingData BookingReportReset = new BookingData();
        Context context = new Context();

        NotifyIcon notifyIcon = new NotifyIcon();
        public void Notificaion()
        {
            notifyIcon.Icon = new Icon("wedding-planner.ico");
            notifyIcon.Visible = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult MessageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (MessageBoxResult == MessageBoxResult.Yes)
            {
                context.Bookings.Remove((BookingData)BookingListDg.SelectedItem);
                BookingListDg.ItemsSource = null;
                context.SaveChanges();
                BookingListDg.ItemsSource = context.Bookings.ToList();

                Notificaion();
                notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Booking Data has been deleted successfully",
                ToolTipIcon.Info);
            }
            else
                return;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            BookingListDg.ItemsSource = null;
            BookingListDg.ItemsSource = context.Bookings.Include(s => s.StaffBooking).Include(c => c.Customer).Include(h=>h.Hall).ToList();
        }
        private void BookingListDg_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            BookingReportReset = (BookingData)BookingListDg.SelectedItem;
            ReportMDI win =new ReportMDI(BookingReportReset);
            win.Show();
         

        }
    }
}
