using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner
{
    public class BookingData
    {
            public Int32 ID { get; set; }

            public DateTime B_Date { get; set; }

            public virtual List<B_Dishes> Dishes { get; set; }
            public virtual List<B_Drinks> Drinks { get; set; }
   
            public int B_GrdTotal { get; set; }  //total

            public int B_Advance { get; set; }  //paid

            public int B_Balance { get; set; }//total-advane
            public double Profit { get; set; }
            public virtual Hall Hall { get; set; }

           public virtual StaffData? StaffBooking { get; set; } // staff which make a book
           public virtual CustomerData Customer { get; set; }  //Customer Who Make book
           public override string ToString()
            {
                return base.ToString();
            }


    }
}
