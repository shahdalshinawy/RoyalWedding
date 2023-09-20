using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int NumOfPeople { get; set; }
        public override string ToString()
        {
            return $"{Name}({NumOfPeople})";
        }
    }
}
