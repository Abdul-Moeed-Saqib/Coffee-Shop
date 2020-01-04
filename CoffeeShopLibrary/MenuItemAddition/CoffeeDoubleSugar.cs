using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary.MenuItemAddition
{
    [Serializable]
    public class CoffeeDoubleSugar : MenuItem
    {
        public CoffeeDoubleSugar()
        {
            Description += "Coffee with two sugars";
            BaseCost += 2.10M;
        }

        public override string ToString()
        {
            return $"Item Name: Coffee Double Sugar, Description: {Description}, Base Cost: {BaseCost:C}";
        }
    }
}
