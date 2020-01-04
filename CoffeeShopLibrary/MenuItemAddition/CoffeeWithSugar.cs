using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class CoffeeWithSugar : MenuItem
    {
        public CoffeeWithSugar()
        {
            Description += "Coffee with sugar";
            BaseCost += 2.05M;
        }

        public override string ToString()
        {
            return $"Item Name: Coffee with Sugar, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
