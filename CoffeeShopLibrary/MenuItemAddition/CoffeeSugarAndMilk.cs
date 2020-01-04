using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class CoffeeSugarAndMilk : MenuItem
    {
        public CoffeeSugarAndMilk()
        {
            Description += "Coffee with single sugar and single milk";
            BaseCost += 2.15M;
        }

        public override string ToString()
        {
            return $"Item Name: Coffee Sugar And Milk, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
