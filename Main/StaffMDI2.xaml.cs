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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WeddingPlanner;

namespace Main
{
    /// <summary>
    /// Interaction logic for StaffMDI2.xaml
    /// </summary>
    public partial class StaffMDI2 : Window
    {
        Context context = new Context();
        NotifyIcon notifyIcon = new NotifyIcon();


        List<string> list = new List<string>()
        {
            "Male",
            "Female"
        };

        private string name;
        private DispatcherTimer timer;
    
        public StaffMDI2(StaffData Staff)
        {
            InitializeComponent();
            name = Staff.S_Name;
            lblName.Content = $"{name}";

        }

       

        public void Reset()
        {
            StName.Text = string.Empty;
            StPhone.Text = string.Empty;
            StGender.SelectedItem = null;
            StPass.Text = string.Empty;
        }
        public void Notificaion()
        {
            notifyIcon.Icon = new Icon("wedding-planner.ico");
            notifyIcon.Visible = true;
        }

        public void StaffListItemSource()
        {
            StaffList.ItemsSource = null;
            context.SaveChanges();
            StaffList.ItemsSource = context.Staffs.ToList();
        }

        private void LogOut(object sender, RoutedEventArgs e)
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

        private void Reset_Button(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void Add_Button(object sender, RoutedEventArgs e)
        {
            StaffData staff = new StaffData();
            string St_Name = StName.Text;
            string St_Phone = StPhone.Text;
            string St_Gender = StGender.Text;
            string St_Password = StPass.Text;
            int num;
            long num2;

            if (string.IsNullOrEmpty(St_Name) || string.IsNullOrEmpty(St_Phone) || string.IsNullOrEmpty(St_Gender) || string.IsNullOrEmpty(St_Password))
            {
                System.Windows.MessageBox.Show("Please Enter Staff Data");
            }
            else if ((string.IsNullOrEmpty(St_Name) || St_Name.Length < 3 || !Regex.IsMatch(St_Name, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(St_Phone) || St_Phone.Length != 11 || !long.TryParse(St_Phone, out num2)) && (string.IsNullOrEmpty(St_Password) || St_Password.Length < 6 || !int.TryParse(St_Password, out num)))
            {
                System.Windows.MessageBox.Show("Staff Name, Staff Phone and Staff Password are not Valid");
            }
            else if ((string.IsNullOrEmpty(St_Name) || St_Name.Length < 3 || !Regex.IsMatch(St_Name, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(St_Phone) || St_Phone.Length != 11 || !long.TryParse(St_Phone, out num2)))
            {
                System.Windows.MessageBox.Show("Staff Name and Staff Phone are not Valid");
            }
            else if ((string.IsNullOrEmpty(St_Name) || St_Name.Length < 3 || !Regex.IsMatch(St_Name, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(St_Password) || St_Password.Length < 6 || !int.TryParse(St_Password, out num)))
            {
                System.Windows.MessageBox.Show("Staff Name and Staff Password are not Valid");
            }
            else if ((string.IsNullOrEmpty(St_Phone) || St_Phone.Length != 11 || !long.TryParse(St_Phone, out num2)) && (string.IsNullOrEmpty(St_Password) || St_Password.Length < 6 || !int.TryParse(St_Password, out num)))
            {
                System.Windows.MessageBox.Show("Staff Phone and Staff Password are not Valid");
            }
            else if (string.IsNullOrEmpty(St_Name) || St_Name.Length < 3 || !Regex.IsMatch(St_Name, @"^[a-zA-Z]+$"))
            {
                System.Windows.MessageBox.Show("Please Enter Valid Staff Name");
            }
            else if (string.IsNullOrEmpty(St_Phone) || St_Phone.Length != 11 || !long.TryParse(St_Phone, out num2))
            {
                System.Windows.MessageBox.Show("Please Enter Valid Staff Phone Number");
            }
            else if (string.IsNullOrEmpty(St_Password) || St_Password.Length < 6 || !int.TryParse(St_Password, out num))
            {
                System.Windows.MessageBox.Show("Please Enter Valid Staff Password");
            }
            else
            {
                staff.S_Name = StName.Text;
                staff.S_Phone = StPhone.Text;
                staff.S_Gender = StGender.SelectedItem.ToString();
                staff.S_Passward = StPass.Text;
                context.Staffs.Add(staff);
                StaffListItemSource();
                Reset();
                //System.Windows.MessageBox.Show("Data has been added successfully");

                Notificaion();
                notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Staff Data has been added successfully",
                ToolTipIcon.Info);

            }
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            MessageBoxResult MessageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (MessageBoxResult == MessageBoxResult.Yes)
            {
                context.Staffs.Remove((StaffData)StaffList.SelectedItem);
                Reset();
                StaffListItemSource();
                //System.Windows.MessageBox.Show("Data has been deleted successfully");

                Notificaion();
                notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Staff Data has been deleted successfully",
                ToolTipIcon.Info);
            }
            else
                return;
        }

        private void Edit_Button(object sender, RoutedEventArgs e)
        {
            var item = (StaffData)StaffList.SelectedItem;

            if (item != null)
            {
                int num;
                long num2;

                if (string.IsNullOrEmpty(StName.Text) || string.IsNullOrEmpty(StPhone.Text) || string.IsNullOrEmpty(StGender.SelectedItem.ToString()) || string.IsNullOrEmpty(StPass.Text))
                {
                    System.Windows.MessageBox.Show("Please Enter Staff Data");
                }
                else if ((string.IsNullOrEmpty(StName.Text) || StName.Text.Length < 3 || !Regex.IsMatch(StName.Text, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(StPhone.Text) || StPhone.Text.Length != 11 || !long.TryParse(StPhone.Text, out num2)) && string.IsNullOrEmpty(StPass.Text) || StPass.Text.Length < 6 || !int.TryParse(StPass.Text, out num))
                {
                    System.Windows.MessageBox.Show("Staff Name, Staff Phone and Staff Password are not Valid");
                }
                else if ((string.IsNullOrEmpty(StName.Text) || StName.Text.Length < 3 || !Regex.IsMatch(StName.Text, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(StPhone.Text) || StPhone.Text.Length != 11 || !long.TryParse(StPhone.Text, out num2)))
                {
                    System.Windows.MessageBox.Show("Staff Name and Staff Phone are not Valid");
                }
                else if ((string.IsNullOrEmpty(StName.Text) || StName.Text.Length < 3 || !Regex.IsMatch(StName.Text, @"^[a-zA-Z]+$")) && (string.IsNullOrEmpty(StPass.Text) || StPass.Text.Length < 6 || !int.TryParse(StPass.Text, out num)))
                {
                    System.Windows.MessageBox.Show("Staff Name and Staff Password are not Valid");
                }
                else if ((string.IsNullOrEmpty(StPhone.Text) || StPhone.Text.Length != 11 || !long.TryParse(StPhone.Text, out num2)) && (string.IsNullOrEmpty(StPass.Text) || StPass.Text.Length < 6 || !int.TryParse(StPass.Text, out num)))
                {
                    System.Windows.MessageBox.Show("Staff Phone and Staff Password are not Valid");
                }
                else if (string.IsNullOrEmpty(StName.Text) || StName.Text.Length < 3 || !Regex.IsMatch(StName.Text, @"^[a-zA-Z]+$"))
                {
                    System.Windows.MessageBox.Show("Please Enter Valid Staff Name");
                }
                else if (string.IsNullOrEmpty(StPhone.Text) || StPhone.Text.Length != 11 || !long.TryParse(StPhone.Text, out num2))
                {
                    System.Windows.MessageBox.Show("Please Enter Valid Staff Phone Number");
                }
               
                else if (string.IsNullOrEmpty(StPass.Text) || StPass.Text.Length < 6 || !int.TryParse(StPass.Text, out num))
                {
                    System.Windows.MessageBox.Show("Please Enter Valid Staff Password");
                }
                else
                {
                    item.S_Name = StName.Text;
                    item.S_Phone = StPhone.Text;
                    item.S_Gender = StGender.SelectedItem.ToString();
                    StGender.SelectedItem = StGender.SelectedItem.ToString();
                    item.S_Passward = StPass.Text;
                    Reset();
                    StaffListItemSource();
                    Notificaion();
                    notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Staff Data has been updated successfully",
                    ToolTipIcon.Info);
                }
            }



        }

        private void StaffList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StaffData st = StaffList.SelectedItem as StaffData;
            if (st != null)
            {
                StName.Text = st.S_Name;
                StPhone.Text = st.S_Phone;
                if (st.S_Gender == "Male")
                {
                    StGender.SelectedItem = list[0];
                    StGender.Text = StGender.SelectedItem.ToString();

                }
                else if (st.S_Gender == "Female")
                {
                    StGender.SelectedItem = list[1];
                    StGender.Text = StGender.SelectedItem.ToString();

                }
                StPass.Text = st.S_Passward;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StGender.ItemsSource = list;
            StaffList.ItemsSource = context.Staffs.ToList();



         
       
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void StName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
