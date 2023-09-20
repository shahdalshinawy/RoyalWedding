using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Windows.Forms.AxHost;

namespace Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Context context = new Context();
        public static StaffData StaffMakeBook = new StaffData();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void windo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            bool isValidUsername = Regex.IsMatch(username, "^[a-zA-Z]+$");
            bool isValidPassword = Regex.IsMatch(password, "^[0-9]+$");
            StaffMakeBook = context.Staffs.FirstOrDefault(s => s.S_Name.ToLower() == username.ToLower() && s.S_Passward == password);

            foreach (StaffData employee in context.Staffs)
            {

                if (username == "" && password == "")
                {
                    lblMessage.Content = " Please Enter your name and password.";

                }
                else if (username == "")
                {
                    lblMessage.Content = " Login failed. Please Enter Your Name";
                }
                else if (password == "")
                {
                    lblMessage.Content = " Login failed. Please Enter Your Password";
                }
                else if (!isValidPassword)
                {
                    lblMessage.Content = "Invalid password. Please try again.";
                }
                else if (!isValidUsername)
                {
                    lblMessage.Content = "Invalid username. Please try again.";
                }
                else if (username.ToLower() == employee.S_Name.ToLower() && password == employee.S_Passward)
                {

                    if (employee.IsManager == false)
                    {
                        lblMessage.Content = " ";
                        MenuMDI win = new MenuMDI(StaffMakeBook);
                        win.Show();
                        this.Close();
                        break;
                    }
                    else if (employee.IsManager == true)
                    {
                        lblMessage.Content = " ";
                        MenuMDI win = new MenuMDI(StaffMakeBook);
                        win.Show();
                        this.Close();
                        break;
                    }
                

                }
                else
                {
                    lblMessage.Content = "Login failed. Please try again.";
                }
            }

        }
        private void GoToStaffForm(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            bool isValidUsername = Regex.IsMatch(username, "^[a-zA-Z]+$");
            bool isValidPassword = Regex.IsMatch(password, "^[0-9]+$");
            StaffMakeBook = context.Staffs.FirstOrDefault(s => s.S_Name.ToLower() == username.ToLower() && s.S_Passward == password);

            foreach (StaffData employee in context.Staffs)
            {
                if (username == "" && password == "")
                {
                    lblMessage.Content = " Please Enter your name and password.";

                }
                else if (username == "")
                {
                    lblMessage.Content = " Login failed. Please Enter Your Name";
                }
                else if (password == "")
                {
                    lblMessage.Content = " Login failed. Please Enter Your Password";
                }
                else if (!isValidPassword)
                {
                    lblMessage.Content = "Invalid password. Please try again.";
                }
                else if (!isValidUsername)
                {
                    lblMessage.Content = "Invalid username. Please try again.";
                }

                else if (username.ToLower() == employee.S_Name.ToLower() && password == employee.S_Passward)
                {

                    if (employee.IsManager == true)
                    {
                        lblMessage.Content = " ";
                        StaffMDI2 win = new StaffMDI2(StaffMakeBook);
                        win.Show();
                        this.Close();
                        break;
                    }
                    else
                    {
                        lblMessage.Content = "Login failed. Please try again.";
                    }
                }
                else
                {
                    lblMessage.Content = "Login failed. Please try again.";
                }
            }
        }

    }
}
