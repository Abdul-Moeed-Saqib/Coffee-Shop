using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class SandwichWithBacon : MenuItem
    {
        public SandwichWithBacon()
        {
            Description += "White bread sandwitch with bacon";
            BaseCost += 5M;
        }

        public override string ToString()
        {
            return $"Item Name: Sandwitch With Bacon, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
