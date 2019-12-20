using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    public class Order
    {
        private int id;
        private Customer customer;
        private DateTime orderTime;
        private DateTime deliveryTime;
        private Address deliveryAddress;
        private decimal cost;
        private OrderType orderType;
        private List<OrderItem> orderItems;
        private int noOfItems;
        private bool isDelivered;

        public int ID { get { return id; } set { id = value; } }
        public Customer Customer { get { return customer; } set { if (customer != null) { Console.WriteLine("Something went wrong! Customer cannot be changed once assigned."); } else { customer = value; } } }
        public DateTime OrderTime { get { return orderTime; } set { orderTime = value; } }
        public DateTime DeliveryTime { get { return deliveryTime; } set { deliveryTime = value; } }
        public Address DeliveryAddress { get { return deliveryAddress; } set { deliveryAddress = value; } }
        public decimal Cost { get { return cost; } set { cost = value; } }
        public OrderType OrderType { get { return orderType; } set { orderType = value; } }
        public List<OrderItem> OrderItems { get { return orderItems; } set { orderItems = value; } }
        public bool IsDelivered { get { return IsDelivered; } set { isDelivered = value; } }

        public Order()
        {
            id++;
            orderItems = new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem newItem)
        {
            orderItems[noOfItems++] = newItem;
            cost += newItem.MenuItem.BaseCost;
        }

        public void Deliver()
        {
            if (isDelivered == true)
            {
                deliveryTime = DateTime.Now; 
            }
            else
            {
                deliveryTime = DateTime.MinValue;
            }
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
            string result = $"Order ID: {id}\nCustomer: {customer.Name}\n Order Time: {orderTime}\n Delivery Date: {deliveryTime}\n Delivery Address: {deliveryAddress.GetInfo()}\n Cost: {cost:C}\n" +
                $"Order Type: {(orderType.Equals(0) ? "Phone Order" : "Resturant Order")}";
            foreach (OrderItem item in orderItems)
            {
                result += $"Orders: {item.GetInfo()}\n";
            }
            return result;
        }
    }
}
