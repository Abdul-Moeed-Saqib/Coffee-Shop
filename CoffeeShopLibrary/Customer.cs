using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    public class Customer
    {
        private int id;
        private string name;
        private Address address;
        private uint phoneNumber;
        private List<Order> orders;
        private int noOfOrder;

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Address Address { get { return address; } set { address = value; } }
        public uint PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public List<Order> Orders { get { return orders; } set { orders = value; } }

        public Customer()
        {
            id++;
            orders = new List<Order>();
        }

        public Customer(string name, Address address, uint phoneNumber)
        {
            id++;
            orders = new List<Order>();
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public Order CreatePhoneOrder(Address address, OrderType type)
        {
            Order order = new Order();
            if (type.Equals(OrderType.PHONE_ORDER))
            {
                orders.Add(order);
            }
            return order;
        }

        public Order AddOrder(Order newOrder)
        {
            orders.Add(newOrder);
            return newOrder;
        }

        public string GetInfo()
        {
            string result = $"ID: {id}\nName: {name}\n Address: {address.GetInfo()}\n Phone Number: {phoneNumber}\n";
            foreach (Order order in orders)
            {
                result += $"Orders: {order.GetInfo()}";
            }
            return result;
        }
    }
}
