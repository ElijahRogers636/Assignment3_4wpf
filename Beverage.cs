using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4wpf
{
    public abstract class Beverage
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double SizeInOunces { get; set; }
        public string CompanyName { get; set; }
        public bool InStock { get; set; }

    }
}
