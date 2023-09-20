using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner
{
    public class CustomerData
    {
        public Int32 ID { get; set; }

        public String Customer_Name { get; set; }

        public String Customer_Address { get; set; }

        public String Customer_Phone { get; set; }


        public override string ToString()
        {
            return $"{Customer_Name}";
        }
        // public virtual BookingData BookDetails { get; set; }
    }
}
