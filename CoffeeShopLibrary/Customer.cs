using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    [Serializable]
    public class Customer
    {
        private static uint idInc;
        private uint id;
        private string name;
        private Address address;
        private uint phoneNumber;
        private List<Order> orders;

        public uint ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Address Address { get { return address; } set { address = value; } }
        public uint PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public List<Order> Orders { get { return orders; } set { orders = value; } }

        public Customer()
        {
            id = 1;
            idInc = 1;
            orders = new List<Order>();
        }

        public Customer(string name, Address address, uint phoneNumber)
        {
            idInc++;
            id = idInc;
            orders = new List<Order>();
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public Order CreatePhoneOrder(Address address, OrderType type)
        {
            Order order = new Order(address);
            if (type.Equals(OrderType.PHONE_ORDER))
            {
                order.OrderType = type;
                orders.Add(order);
            }
            return order;
        }

        public Order AddOrder(Order newOrder)
        {
            orders.Add(newOrder);
            return newOrder;
        }

        public override string ToString()
        {
            string result = $"\t\nID: {id}\nName: {name}\n \tAddress: {address.GetInfo()}\n Phone Number: {phoneNumber}\n";
            if (orders != null)
            {
                result += "\nOrders: \n";

                foreach (Order order in orders)
                {
                    if (order != null)
                    {
                        result += $"{order.GetInfo()}";
                    }
                }
            }
            return result;
        }
    }
}
