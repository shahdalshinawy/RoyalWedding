using Microsoft.EntityFrameworkCore;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeddingPlanner;

namespace Main
{
    /// <summary>
    /// Interaction logic for ProfitMDI.xaml
    /// </summary>
    public partial class ProfitMDI : UserControl
    {
        Context context = new Context();
        public ProfitMDI()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            GridProfit.ItemsSource = context.Bookings.Include(h=>h.Hall).Include(s=>s.StaffBooking).Include(c=>c.Customer).ToList();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
