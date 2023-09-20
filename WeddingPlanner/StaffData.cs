using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner
{
    public class StaffData
    {
        public Int32 ID { get; set; }
        public String S_Name { get; set; }
        public String S_Phone { get; set; }
       
        public String S_Passward { get; set; }
        public String S_Gender { get; set; }
        public bool IsManager { get; set; }
        public override string ToString()
        {
            return $"{S_Name}";
        }
    }
}
