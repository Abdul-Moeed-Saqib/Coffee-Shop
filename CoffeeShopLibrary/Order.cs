using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    [Serializable]
    public class Order
    {
        private static uint idInc;
        private uint id;
        private Customer customer;
        private DateTime orderTime;
        private DateTime deliveryTime;
        private Address deliveryAddress;
        private decimal cost;
        private OrderType orderType;
        private List<OrderItem> orderItems;
        private bool isDelivered;

        public uint ID { get { return id; } set { id = value; } }
        public string Name { get; }
        public Customer Customer { get { return customer; } set { if (customer != null) { Console.WriteLine("Something went wrong! Customer cannot be changed once assigned."); } else { customer = value; } } }
        public DateTime OrderTime { get { return orderTime; } set { orderTime = value; } }
        public DateTime DeliveryTime { get { return deliveryTime; } set { deliveryTime = value; } }
        public Address DeliveryAddress { get { return deliveryAddress; } set { deliveryAddress = value; } }
        public decimal Cost { get { return cost; } set { cost = value; } }
        public OrderType OrderType { get { return orderType; } set { orderType = value; } }
        public List<OrderItem> OrderItems { get { return orderItems; } set { orderItems = value; } }
        public bool IsDelivered { get { return IsDelivered; } set { isDelivered = value; if (isDelivered == true) { DeliveryTime = DateTime.Now; } else { DeliveryTime = DateTime.MinValue; } } }

        public Order()
        {
            idInc++;
            id = idInc;
            orderItems = new List<OrderItem>();
        }

        public Order(Address deliveryAddress)
        {
            idInc++;
            id = idInc;
            DeliveryAddress = deliveryAddress;
            orderItems = new List<OrderItem>();
        }

        public void AddOrderItem(MenuItem newItem)
        {
            OrderItem item = new OrderItem(newItem);
            orderItems.Add(item);
            cost += newItem.BaseCost;
        }

        public void Deliver()
        {
            IsDelivered = true;
        }

        public void Delivered()
        {
            if (IsDelivered == true)
            {
                Console.WriteLine("DELIVERED");
            }
            else
            {
                Console.WriteLine("NOT DELIVERED");
            }
        }

        public string GetInfo()
        {
            string result = $"\t\nOrder ID: {id}\n Order Time: {orderTime.ToShortTimeString()}\n Delivery Date: {deliveryTime.ToShortTimeString()}\n Delivery Address: {deliveryAddress.GetInfo()}\n Cost: {cost:C}\n";
            result += "Order Type: ";
            if (orderType.Equals(OrderType.PHONE_ORDER)) 
            {
                result += "Phone Order";
            }
            else
            {
                result += "Resturant Order";
            }

            if (isDelivered)
            {
                result += $"\n Delivery Time: {DeliveryTime}\n";
            }
            else
            {
                result += "\nNOT DELIVERED!\n";
            }

            result += "\t\tItems: \n";

            if (orderItems != null)
            {
                foreach (OrderItem item in orderItems)
                {
                    if (item != null)
                    {
                        result += $"\t\t{item.GetInfo()}\n";
                    }
                }
            }
            return result;
        }
    }
}
