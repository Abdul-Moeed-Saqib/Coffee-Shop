using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    public class MenuItem
    {
        private string name;
        private string description;
        private decimal baseCost;

        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public decimal BaseCost { get { return baseCost; } set { baseCost = value; } }

        public string GetInfo()
        {
            return $"Item Name: {name}, Description: {description}, Base Cost: {baseCost:C}";
        }
    }
}
