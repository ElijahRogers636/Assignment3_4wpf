using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4wpf
{
    class MockData
    {
        public static List<Coffee> Coffees { get; set; }

        public static List<Coffee> CreateData()
        {
            Coffees = new List<Coffee>()
            {
                new Coffee() { Type = "Coffee" ,Name = "Mocha Latte", SizeInOunces = 16, CompanyName = "BlackRifle", InStock = true, BrewStrength = "Mild", Roast = Roast.light, Creamer = "Half&Half", Flavoring = "None"},
                new Coffee() { Type = "Coffee" ,Name = "Americano", SizeInOunces = 12, CompanyName = "Columbia", InStock = true, BrewStrength = "Strong", Roast = Roast.medium, Creamer = "Whole Milk", Flavoring = "Brown Sugar"},
                new Coffee() { Type = "Coffee" ,Name = "Cappuccino", SizeInOunces = 8, CompanyName = "BlackRifle", InStock = true, BrewStrength = "Medium", Roast = Roast.medium, Creamer = "Almond Milk", Flavoring = "None"},
                new Coffee() { Type = "Coffee" ,Name = "Espresso", SizeInOunces = 4, CompanyName = "Coffe Co", InStock = true, BrewStrength = "Strong", Roast = Roast.dark, Creamer = "None", Flavoring = "None"},
                new Coffee() { Type = "Coffee" ,Name = "Vanilla Latte", SizeInOunces = 16, CompanyName = "Folgers", InStock = false, BrewStrength = "Mild", Roast = Roast.light, Creamer = "Half&Half", Flavoring = "Caramel"},
            };
            return Coffees;
        }
    }
}
