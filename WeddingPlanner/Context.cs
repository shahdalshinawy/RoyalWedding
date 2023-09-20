using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner
{
    public class Context : DbContext
    {


        public DbSet<StaffData> Staffs { get; set; }
        public DbSet<B_Drinks> Drinks { get; set; }
        public DbSet<B_Dishes> Dishes { get; set; }
        public DbSet<CustomerData> Customers { get; set; }
        public DbSet<BookingData> Bookings { get; set; }
        public DbSet<Hall> Halls { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.
        UseSqlServer(@"Data Source=DESKTOP-C91LV05\SQL19;Initial Catalog=WeddingPlannerDB; Integrated Security=True; trust server certificate = true");
            // .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffData>().HasData(new[]
            {
                  new StaffData() {

                  ID=1,
                S_Name = "Nour",
                S_Phone = "01234567891",
                S_Passward = "1234567",
                S_Gender = "Female",
                IsManager = true,

            },new StaffData()
            {
                ID=2,
                S_Name = "Nada",
                S_Phone = "01019658193",
                S_Passward = "1234567",
                S_Gender = "Female",
                IsManager = true,

            }

        }); ;
            modelBuilder.Entity<CustomerData>().HasData(new[]
            {

                new CustomerData()
            {
                    ID=1,
                Customer_Name = "Fareed",
                Customer_Address = "Egypt-Cairo-Giza",
                Customer_Phone = "01234567896",

            },
                      new CustomerData()
            {
                          ID=2,
                Customer_Name = "Fareed",
                Customer_Address = "Egypt-Cairo-Giza",
                Customer_Phone = "01234567896",

            }
            }

             );
            modelBuilder.Entity<B_Dishes>().HasData(new[]
            {
                new B_Dishes()
                {
                    ID=1,
                    Name="Meat",
                    Quantity=0,
                    Price=90
                },

                new B_Dishes()
                {
                    ID=2,
                    Name="Fish",
                    Quantity=0,
                    Price=100
                },


                new B_Dishes()
                {
                    ID=3,
                    Name="Chicken",
                    Quantity=0,
                    Price=80
                },


            });
            modelBuilder.Entity<B_Drinks>().HasData(new[]
            {
                new B_Drinks()
                {
                    ID=1,
                    Name="Soda",
                    Quantity=0,
                    Price=20
                },

                new B_Drinks()
                {
                    ID=2,
                    Name="Water",
                    Quantity=0,
                    Price=10
                },


                new B_Drinks()
                {
                    ID=3,
                    Name="Juice",
                    Quantity=0,
                    Price=15
                },


            });
            modelBuilder.Entity<Hall>().HasData(new[]
           {
                new Hall()
                {
                    Id=1,
                    Name="Royal I",
                    NumOfPeople=100,
                    Price=19000
                },
                 new Hall()
                {
                    Id=2,
                    Name="Royal II",
                    NumOfPeople=150,
                    Price=25000
                },
                  new Hall()
                {
                    Id=3,
                    Name="Royal III",
                    NumOfPeople=200,
                    Price=40000
                },
                       new Hall()
                {
                    Id=4,
                    Name="Royal IV",
                    NumOfPeople=300,
                    Price=50000
                },


            });



        }

    }
}
