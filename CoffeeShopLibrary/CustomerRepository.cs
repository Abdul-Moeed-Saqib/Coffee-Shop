using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    [Serializable]
    public class CustomerRepository
    {
        private List<Customer> customers = new List<Customer>();

        public CustomerRepository()
        {
            
        }

        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        public void Add(Customer collect)
        {
            Customers.Add(collect);
        }
    }
}
