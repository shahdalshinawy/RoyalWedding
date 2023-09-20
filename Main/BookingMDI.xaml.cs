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
    /// Interaction logic for BookingMDI.xaml
    /// </summary>
    public partial class BookingMDI : System.Windows.Controls.UserControl
    {
        StaffData StaffMakeBook;
                 public BookingMDI(StaffData StaffMakeBok)
        {
            StaffMakeBook = StaffMakeBok;
            InitializeComponent();
        }

        public Context context = new Context();

        NotifyIcon notifyIcon = new NotifyIcon();

        public void Notificaion()
        {
            notifyIcon.Icon = new Icon("wedding-planner.ico");
            notifyIcon.Visible = true;
        }


        public BookingData currentBook = new BookingData();

        B_Drinks soda;
        B_Drinks water;
        B_Drinks juice;
        B_Dishes meat;
        B_Dishes fish;
        B_Dishes chicken;
        int dishesTotal = 0;
        int DrinkTotal = 0;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            soda = context.Drinks.First();
            water = context.Drinks.Where(d => d.ID == 2).FirstOrDefault();
            juice = context.Drinks.Where(d => d.ID == 3).FirstOrDefault();

            SodaPrice.Text = soda.Price.ToString();
            WaterPrice.Text = water.Price.ToString();
            JuicePrice.Text = juice.Price.ToString();

            meat = context.Dishes.First();
            fish = context.Dishes.Where(d => d.ID == 2).FirstOrDefault();
            chicken = context.Dishes.Where(d => d.ID == 3).FirstOrDefault();

            MeatPrice.Text = meat.Price.ToString();
            FishPrice.Text = fish.Price.ToString();
            ChickenPrice.Text = chicken.Price.ToString();

        }


        private void BackToMenu(object sender, RoutedEventArgs e)
        {
            //Menu win = new Menu();
            //win.Show();
            //this.Close();
        }


        private void DatePickerr_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            currentBook.B_Date = DatePickerr.SelectedDate.Value;
        }


        private void SodaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SodaQuantity.IsEnabled = true;


            try
            {
                if (!Regex.IsMatch(SodaQuantity.Text, "^[0-9]+$") && SodaQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    SodaQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(SodaQuantity.Text))
                {
                    soda.Quantity = Int32.Parse(SodaQuantity.Text);
                }
            }
            catch
            { }

        }

        private void WaterCheckBox_Checked(object sender, RoutedEventArgs e)
        {

            WaterQuantity.IsEnabled = true;

            try
            {
                if (!Regex.IsMatch(WaterQuantity.Text, "^[0-9]+$") && WaterQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    WaterQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(WaterQuantity.Text))
                {
                    water.Quantity = Int32.Parse(WaterQuantity.Text);
                }
            }
            catch
            { }

        }

        private void JuiceCheckBox_Checked(object sender, RoutedEventArgs e)
        {

            JuiceQuantity.IsEnabled = true;

            try
            {
                if (!Regex.IsMatch(JuiceQuantity.Text, "^[0-9]+$") && JuiceQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    JuiceQuantity.Text = "";
                }

                else
                {
                    juice.Quantity = Int32.Parse(JuiceQuantity.Text);
                }
            }
            catch
            { }

        }

        private void BeverageCalcBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SodaQuantity.Text == "")
            {
                SodaQuantity.Text = "0";
            }
            soda.Quantity = Int32.Parse(SodaQuantity.Text);


            int total_Soda = 0;
            if (soda.Quantity > 0)
            {
                total_Soda = soda.Price * soda.Quantity;
            }

            if (WaterQuantity.Text == "")
            {
                WaterQuantity.Text = "0";
            }
            water.Quantity = Int32.Parse(WaterQuantity.Text);

            int total_Water = 0;
            if (water.Quantity > 0)
            {
                total_Water = water.Price * water.Quantity;

            }

            if (JuiceQuantity.Text == "")
            {
                JuiceQuantity.Text = "0";
            }

            juice.Quantity = Int32.Parse(JuiceQuantity.Text);

            int total_Juice = 0;

            if (juice.Quantity > 0)
            {
                total_Juice = juice.Price * juice.Quantity;
            }



            DrinkTotal = total_Juice + total_Soda + total_Water;
            totalDrink.Text = DrinkTotal.ToString();
            currentBook.B_GrdTotal = dishesTotal + DrinkTotal;
            payment();
        }

        private void ChickenCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ChickenQuantity.IsEnabled = true;
            try
            {
                if (!Regex.IsMatch(ChickenQuantity.Text, "^[0-9]+$") && ChickenQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    ChickenQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(ChickenQuantity.Text))
                {
                    chicken.Quantity = Int32.Parse(ChickenQuantity.Text);
                }
            }
            catch
            { }
        }

        private void MeatCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MeatQuantity.IsEnabled = true;
            try
            {
                if (!Regex.IsMatch(MeatQuantity.Text, "^[0-9]+$") && MeatQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    MeatQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(MeatQuantity.Text))
                {
                    meat.Quantity = Int32.Parse(MeatQuantity.Text);
                }
            }
            catch
            { }
        }

        private void FishCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            FishQuantity.IsEnabled = true;
            try
            {
                if (!Regex.IsMatch(FishQuantity.Text, "^[0-9]+$") && FishQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    FishQuantity.Text = "";
                }

                else
                {
                    fish.Quantity = Int32.Parse(FishQuantity.Text);
                }
            }
            catch
            { }
        }

        private void DishesCalcBtn_Click(object sender, RoutedEventArgs e)
        {
            chicken.Quantity = Int32.Parse(ChickenQuantity.Text);
            int total_Chicken = 0;
            if (chicken.Quantity > 0)
            {
                total_Chicken = chicken.Price * chicken.Quantity;
            }

            meat.Quantity = Int32.Parse(MeatQuantity.Text);
            int total_Meat = 0;
            if (meat.Quantity > 0)
            {
                total_Meat = meat.Price * meat.Quantity;
            }

            fish.Quantity = Int32.Parse(FishQuantity.Text);
            int total_Fish = 0;
            if (fish.Quantity > 0)
            {
                total_Fish = fish.Price * fish.Quantity;
            }

            dishesTotal = total_Fish + total_Chicken + total_Meat;
            TotalDish.Text = dishesTotal.ToString();
            currentBook.B_GrdTotal = dishesTotal + DrinkTotal;
            payment();
        }

        private void payment()
        {
            int AD = currentBook.B_Advance;
            int BA = currentBook.B_Balance;
        
                int.TryParse(AdvancesTextBox.Text, out AD);
                currentBook.B_Balance = ((dishesTotal + DrinkTotal + currentBook.Hall.Price) - AD); ;
                currentBook.B_Advance = AD;
                GrdTotalTextBox.Text = (currentBook.B_GrdTotal + int.Parse(HallPrice.Text)).ToString();
                BalanceTextBox.Text = currentBook.B_Balance.ToString();

                context.SaveChanges();
            
            
        }


        private double ProfitCalc()
        {
            double ProfitofFood = dishesTotal + DrinkTotal * (0.40);//deal 40% from Drinks and Dishes
            return currentBook.Hall.Price + ProfitofFood;

        }

        private void AdvancesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (AdvancesTextBox.Text == "")
            {
                AdvancesTextBox.Text = "0";
            }

            
        if(   int.Parse(AdvancesTextBox.Text) > int.Parse(GrdTotalTextBox.Text))
            {
                System.Windows.MessageBox.Show("You Pay More Than Required");
            }
            else { payment(); }
        
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            SodaCheckBox.IsChecked = false;
            JuiceCheckBox.IsChecked = false;
            WaterCheckBox.IsChecked = false;
            ChickenCheckBox.IsChecked = false;
            MeatCheckBox.IsChecked = false;
            FishCheckBox.IsChecked = false;
            DatePickerr.SelectedDate = DateTime.Now;
            cbCustomer.Text = string.Empty;
        
            SodaQuantity.Text = "0";
            WaterQuantity.Text = "0";
            JuiceQuantity.Text = "0";
            MeatQuantity.Text = "0";
            ChickenQuantity.Text = "0";
               AdvancesTextBox.Text = "0";
            BalanceTextBox.Text = "0";
            GrdTotalTextBox.Text = string.Empty;
            HallPrice.Text = "0";
      
          
        }

        private void WaterCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DisableDrink(WaterPrice, WaterQuantity);
        }

        private void SodaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DisableDrink(SodaPrice, SodaQuantity);
        }

        private void JuiceCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DisableDrink(JuicePrice, JuiceQuantity);
        }

        private void ChickenCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DisableDish(ChickenPrice, ChickenQuantity);
        }

        private void MeatCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DisableDish(MeatPrice, MeatQuantity);
        }

        private void FishCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DisableDish(FishPrice, FishQuantity);
        }
        private void minsDishes(string price, string Quantity)
        {
            if(Quantity== "") 
            {
                Quantity = "0";
            }
            dishesTotal -= (int.Parse(price) * int.Parse(Quantity));
            currentBook.B_GrdTotal = dishesTotal + DrinkTotal;
            TotalDish.Text = dishesTotal.ToString();
            payment();
        }
        private void minsDrinks(string price, string Quantity)
        {
            if (Quantity == "")
            {
                Quantity = "0";
            }
            DrinkTotal -= (int.Parse(price) * int.Parse(Quantity));
            currentBook.B_GrdTotal = DrinkTotal + dishesTotal;
            totalDrink.Text = DrinkTotal.ToString();
            payment();
        }
        private void DisableDish(System.Windows.Controls.TextBox price, System.Windows.Controls.TextBox Quantity)
        {
            minsDishes(price.Text, Quantity.Text); //mins from total sum unchecked

            Quantity.IsEnabled = false;
            Quantity.Text = 0.ToString();

        }
        private void DisableDrink(System.Windows.Controls.TextBox price, System.Windows.Controls.TextBox Quantity)
        {

            minsDrinks(price.Text, Quantity.Text);

            Quantity.IsEnabled = false;
            Quantity.Text = 0.ToString();

        }

        private void cbCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            currentBook.Customer = cbCustomer.SelectedItem as CustomerData;
        }

        private void ChickenQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChickenQuantity.IsEnabled = true;

            try
            {
                if (!Regex.IsMatch(ChickenQuantity.Text, "^[0-9]+$") && ChickenQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Number Of people");
                    ChickenQuantity.Text = "";
                }
                else if (string.IsNullOrEmpty(ChickenQuantity.Text))
                {
                    chicken.Quantity = int.Parse((ChickenQuantity.Text).ToString());
                }
            }
            catch
            { }
        }

        private void SodaQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            SodaQuantity.IsEnabled = true;

            try
            {
                if (!Regex.IsMatch(SodaQuantity.Text, "^[0-9]+$") && SodaQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    SodaQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(SodaQuantity.Text))
                {
                    soda.Quantity = Int32.Parse(SodaQuantity.Text);
                }
            }
            catch
            { }
        }

        private void WaterQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            WaterQuantity.IsEnabled = true;
            try
            {
                if (!Regex.IsMatch(WaterQuantity.Text, "^[0-9]+$") && WaterQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    WaterQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(WaterQuantity.Text))
                {
                    water.Quantity = Int32.Parse(WaterQuantity.Text);
                }
            }
            catch
            { }
        }

        private void JuiceQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            JuiceQuantity.IsEnabled = true;
            try
            {
                if (!Regex.IsMatch(JuiceQuantity.Text, "^[0-9]+$") && JuiceQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    JuiceQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(JuiceQuantity.Text))
                {
                    juice.Quantity = Int32.Parse(JuiceQuantity.Text);
                }
            }
            catch
            { }
        }

        private void MeatQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            MeatQuantity.IsEnabled = true;
            try
            {
                if (!Regex.IsMatch(MeatQuantity.Text, "^[0-9]+$") && MeatQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    MeatQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(MeatQuantity.Text))
                {
                    meat.Quantity = Int32.Parse(MeatQuantity.Text);
                }
            }
            catch
            { }
        }

        private void FishQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            FishQuantity.IsEnabled = true;
            try
            {
                if (!Regex.IsMatch(FishQuantity.Text, "^[0-9]+$") && FishQuantity.Text != "")
                {
                    System.Windows.MessageBox.Show("Please Enter Numerical Quantity");
                    FishQuantity.Text = "";
                }

                else if (string.IsNullOrEmpty(FishQuantity.Text))
                {
                    fish.Quantity = Int32.Parse(FishQuantity.Text);
                }
            }
            catch
            { }
        }

        private void CbHall_DropDownOpened(object sender, EventArgs e)
        {
            CbHall.ItemsSource = context.Halls.ToList();
        }

        private void cbCustomer_DropDownOpened(object sender, EventArgs e)
        {
            cbCustomer.ItemsSource = context.Customers.ToList();
        }

        private void CbHall_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Hall HallSelect = CbHall.SelectedItem as Hall;
            if (context.Bookings.FirstOrDefault(b => b.Hall.Name == HallSelect.Name && b.B_Date == currentBook.B_Date) != null)
            {
                Notificaion();
                notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Hall  has been Taken At this Date Change Date or Hall",
                ToolTipIcon.Info);

            }
            else
            {
                Addbtn.IsEnabled = true;
                currentBook.Hall = HallSelect;
                HallPrice.Text = HallSelect.Price.ToString();
            }

        }
        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            
            var query = context.Staffs.FirstOrDefault(s => s.S_Name == StaffMakeBook.S_Name);
            currentBook.StaffBooking = query;
            currentBook.Customer = (CustomerData)cbCustomer.SelectedItem;
      
            context.Bookings.Add(currentBook);
            currentBook.Profit = ProfitCalc();
            context.SaveChanges();


            Notificaion();
            notifyIcon.ShowBalloonTip(30000, "Wedding Planner", "Booking Data has been added successfully",
            ToolTipIcon.Info);
        }
    }
}
