using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for CustomerMDI.xaml
    /// </summary>
    public partial class CustomerMDI : System.Windows.Controls.UserControl
    {
        Context context = new Context();
        NotifyIcon notifyIcon = new NotifyIcon();
        public CustomerMDI()
        {
            InitializeComponent();
        }
        public void Notificaion()
        {
            notifyIcon.Icon = new Icon("wedding-planner.ico");
            notifyIcon.Visible = true;
        }
        public void CustomerListItemSource()
        {
            CustomerList.ItemsSource = null;
            context.SaveChanges();
            CustomerList.ItemsSource = context.Customers.ToList();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerList.ItemsSource = context.Customers.ToList();
        }

        public void Reset()
        {
            CutName.Text = string.Empty;
            CutAdd.Text = string.Empty;
            CutPhone.Text = string.Empty;
            // CutID.Text = string.Empty;
        }
       

        private void ToLogOut(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Logout Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                MainWindow win = new MainWindow();
                win.Show();
              
            }
            else
                return;
        }



        private void Add_Button(object sender, RoutedEventArgs e)
        {
            CustomerData cust = new CustomerData();
            string Cust_Name = CutName.Text;
            string Cust_Phone = CutPhone.Text;
            string Cust_Address = CutAdd.Text;

            long num2;

            if (string.IsNullOrEmpty(Cust_Name) || string.IsNullOrEmpty(Cust_Phone) || string.IsNullOrEmpty(Cust_Address))
            {
                System.Windows.MessageBox.Show("Please Enter Customer Data");
            }
            else if ((string.IsNullOrEmpty(Cust_Name) || Cust_Name.Length < 3 || !Regex.IsMatch(Cust_Name, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(Cust_Phone) || Cust_Phone.Length != 11 || !long.TryParse(Cust_Phone, out num2)) && (string.IsNullOrEmpty(Cust_Address) || Cust_Address.Length < 3 || !Regex.IsMatch(Cust_Address, @"^[a-zA-Z-]+$")))
            {
                System.Windows.MessageBox.Show("Customer Name, Customer Address and Customer Phone are not Valid");
            }
            else if ((string.IsNullOrEmpty(Cust_Name) || Cust_Name.Length < 3 || !Regex.IsMatch(Cust_Name, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(Cust_Phone) || Cust_Phone.Length != 11 || !long.TryParse(Cust_Phone, out num2)))
            {
                System.Windows.MessageBox.Show("Customer Name and Customer Phone are not Valid");
            }
            else if ((string.IsNullOrEmpty(Cust_Name) || Cust_Name.Length < 3 || !Regex.IsMatch(Cust_Name, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(Cust_Address) || Cust_Address.Length < 3 || !Regex.IsMatch(Cust_Address, @"^[a-zA-Z-]+$")))
            {
                System.Windows.MessageBox.Show("Customer Name and Customer Address are not Valid");
            }
            else if ((string.IsNullOrEmpty(Cust_Phone) || Cust_Phone.Length != 11 || !long.TryParse(Cust_Phone, out num2)) && (string.IsNullOrEmpty(Cust_Address) || Cust_Address.Length < 3 || !Regex.IsMatch(Cust_Address, @"^[a-zA-Z-]+$")))
            {
                System.Windows.MessageBox.Show("Customer Phone and Customer Address are not Valid");
            }
            else if (string.IsNullOrEmpty(Cust_Name) || Cust_Name.Length < 3 || !Regex.IsMatch(Cust_Name, @"^[a-zA-Z]+$"))
            {
                System.Windows.MessageBox.Show("Please Enter Valid Customer Name");
            }
            else if (string.IsNullOrEmpty(Cust_Phone) || Cust_Phone.Length != 11 || !long.TryParse(Cust_Phone, out num2))
            {
                System.Windows.MessageBox.Show("Please Enter Valid Customer Phone Number");
            }
            else if (string.IsNullOrEmpty(Cust_Address) || Cust_Address.Length < 3 || !Regex.IsMatch(Cust_Address, @"^[a-zA-Z-]+$"))
            {
                System.Windows.MessageBox.Show("Please Enter Valid Customer Address");
            }
            else
            {
                cust.Customer_Phone = CutPhone.Text;
                cust.Customer_Address = CutAdd.Text;
                cust.Customer_Name = CutName.Text;
                context.Customers.Add(cust);
                CustomerListItemSource();
                Reset();

                Notificaion();
                notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Customer Data has been added successfully",
                ToolTipIcon.Info);
            }

           
        }
        private void DelCustomer(object sender, RoutedEventArgs e)
        {
            MessageBoxResult MessageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (MessageBoxResult == MessageBoxResult.Yes)
            {
                context.Customers.Remove((CustomerData)CustomerList.SelectedItem);
                Reset();
                CustomerListItemSource();

                Notificaion();
                notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Customer Data has been deleted successfully",
                ToolTipIcon.Info);
            }
            else
                return;
        }


        private void Edit_Button(object sender, RoutedEventArgs e)
        {
            var item = (CustomerData)CustomerList.SelectedItem;

            if (item != null)
            {
                long num2;

                if (string.IsNullOrEmpty(CutName.Text) || string.IsNullOrEmpty(CutPhone.Text) || string.IsNullOrEmpty(CutAdd.Text))
                {
                    System.Windows.MessageBox.Show("Please Enter Customer Data");
                }
                else if ((string.IsNullOrEmpty(CutName.Text) || CutName.Text.Length < 3 || !Regex.IsMatch(CutName.Text, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(CutPhone.Text) || CutPhone.Text.Length != 11 || !long.TryParse(CutPhone.Text, out num2)) && (string.IsNullOrEmpty(CutAdd.Text) || CutAdd.Text.Length < 3 || !Regex.IsMatch(CutAdd.Text, @"^[a-zA-Z-]+$")))
                {
                    System.Windows.MessageBox.Show("Customer Name, Customer Address and Customer Phone are not Valid");
                }
                else if ((string.IsNullOrEmpty(CutName.Text) || CutName.Text.Length < 3 || !Regex.IsMatch(CutName.Text, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(CutPhone.Text) || CutPhone.Text.Length != 11 || !long.TryParse(CutPhone.Text, out num2)))
                {
                    System.Windows.MessageBox.Show("Customer Name and Customer Phone are not Valid");
                }
                else if ((string.IsNullOrEmpty(CutName.Text) || CutName.Text.Length < 3 || !Regex.IsMatch(CutName.Text, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(CutAdd.Text) || CutAdd.Text.Length < 3 || !Regex.IsMatch(CutAdd.Text, @"^[a-zA-Z-]+$")))
                {
                    System.Windows.MessageBox.Show("Customer Name and Customer Address are not Valid");
                }
                else if ((string.IsNullOrEmpty(CutPhone.Text) || CutPhone.Text.Length != 11 || !long.TryParse(CutPhone.Text, out num2)) && (string.IsNullOrEmpty(CutAdd.Text) || CutAdd.Text.Length < 3 || !Regex.IsMatch(CutAdd.Text, @"^[a-zA-Z-]+$")))
                {
                    System.Windows.MessageBox.Show("Customer Phone and Customer Address are not Valid");
                }
                else if (string.IsNullOrEmpty(CutName.Text) || CutName.Text.Length < 3 || !Regex.IsMatch(CutName.Text, @"^[a-zA-Z]+$"))
                {
                    System.Windows.MessageBox.Show("Please Enter Valid Customer Name");
                }
                else if (string.IsNullOrEmpty(CutPhone.Text) || CutPhone.Text.Length != 11 || !long.TryParse(CutPhone.Text, out num2))
                {
                    System.Windows.MessageBox.Show("Please Enter Valid Customer Phone Number");
                }
                else if (string.IsNullOrEmpty(CutAdd.Text) || CutAdd.Text.Length < 3 || !Regex.IsMatch(CutAdd.Text, @"^[a-zA-Z-]+$"))
                {
                    System.Windows.MessageBox.Show("Please Enter Valid Customer Address");
                }
                else
                {
                    item.Customer_Name = CutName.Text;
                    item.Customer_Phone = CutPhone.Text;
                    item.Customer_Address = CutAdd.Text;
                    Reset();
                    CustomerListItemSource();
                    //System.Windows.MessageBox.Show("Data has been updated successfully");

                    Notificaion();
                    notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Customer Data has been updated successfully",
                    ToolTipIcon.Info);
                }
            }
        }


        private void RestCustomer(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void CustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CustomerData cut = CustomerList.SelectedItem as CustomerData;
            if (cut != null)
            {
                CutName.Text = cut.Customer_Name;
                CutPhone.Text = cut.Customer_Phone;
                CutAdd.Text = cut.Customer_Address;
            }
        }

      
    }
}
