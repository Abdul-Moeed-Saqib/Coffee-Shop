using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    public class OrderItem
    {
        private MenuItem menuItem;

        public MenuItem MenuItem { get { return menuItem; } set { menuItem = value; } }

        public string GetInfo()
        {
            return $"Item: {menuItem.GetInfo()}";
        }
    }
}
