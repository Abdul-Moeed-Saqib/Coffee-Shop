using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class SandwichWithRoastedBeef : MenuItem
    {
        public SandwichWithRoastedBeef()
        {
            Description += "White bread sendwitch with roasted beef";
            BaseCost += 5.50M;
        }

        public override string ToString()
        {
            return $"Item Name: Sandwitch With Roasted Beef, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
