using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class SandwichWithEggSalad : MenuItem
    {
        public SandwichWithEggSalad()
        {
            Description += "White bread sendwitch with egg salad";
            BaseCost += 4M;
        }

        public override string ToString()
        {
            return $"Item Name: Sandwitch With Egg Salad, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
