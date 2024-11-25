using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4wpf
{
    public enum Roast { light, medium, dark }
    public class Coffee : Beverage
    {
        public string BrewStrength { get; set; }
        public Roast Roast { get; set; }
        public string Creamer { get; set; }
        public string Flavoring { get; set; }
    }
}
