using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    [Serializable]
    public class OrderItem
    {
        private MenuItem menuItem;

        public MenuItem MenuItem { get { return menuItem; } set { menuItem = value; } }

        public OrderItem(MenuItem menuItem)
        {
            this.menuItem = menuItem;
        }

        public string GetInfo()
        {
            return $"{menuItem.ToString()}";
        }
    }
}
