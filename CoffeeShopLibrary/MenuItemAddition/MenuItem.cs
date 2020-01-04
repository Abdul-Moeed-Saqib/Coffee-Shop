using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    [Serializable]
    public abstract class MenuItem
    {
        private string description;
        private decimal baseCost;

        public string Description { get { return description; } set { description = value; } }
        public decimal BaseCost { get { return baseCost; } set { baseCost = value; } }

        public abstract override string ToString();
    }
}
