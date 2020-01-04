using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class CoffeeWithMilk : MenuItem
    {
        public CoffeeWithMilk()
        {
            Description += "Coffee with one milk";
            BaseCost += 2.10M;
        }

        public override string ToString()
        {
            return $"Item Name: Coffee with Milk, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
