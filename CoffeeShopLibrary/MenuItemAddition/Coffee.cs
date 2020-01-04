using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class Coffee : MenuItem
    {
        public Coffee()
        {
            Description += "Black Coffee";
            BaseCost += 2M;
        }

        public override string ToString()
        {
            return $"Item Name: Coffee, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
