using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class CoffeeDoubleMilk : MenuItem
    {
        public CoffeeDoubleMilk()
        {
            Description += "Coffee with two milk";
            BaseCost += 2.20M;
        }

        public override string ToString()
        {
            return $"Item Name: Coffee Double Milk, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
