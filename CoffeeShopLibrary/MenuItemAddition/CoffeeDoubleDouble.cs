using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class CoffeeDoubleDouble : MenuItem
    {
        public CoffeeDoubleDouble()
        {
            Description += "Coffee with two sugars and two milk";
            BaseCost += 2.30M;
        }

        public override string ToString()
        {
            return $"Item Name: Coffee Double Double, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
