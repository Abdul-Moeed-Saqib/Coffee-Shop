using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopLibrary;
using CoffeeShopLibrary.MenuItemAddition;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository repository = new CustomerRepository();
            Address address1;
            Address address2;
            Address address3;

            setAddresses(out address1, out address2, out address3);

            Customer customer1;
            Customer customer2;
            Customer customer3;
            Customer internalCustomer = new Customer("Coffee and sandwiches", Address.SHOP_ADDRESS, 0);

            setCustomers(out customer1, out customer2, out customer3, address1, address2, address3);

            repository.Add(customer1);
            repository.Add(customer2);
            repository.Add(customer3);
            repository.Add(internalCustomer);

            titleMeessage("CUSTOMERS");
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);
            Console.WriteLine(internalCustomer);

            MenuItem[] menuItems = new MenuItem[10];

            setMenuItems(menuItems);

            titleMeessage("Menu Items");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(menuItems[i]);
            }

            Order order1 = customer1.CreatePhoneOrder(address1, OrderType.PHONE_ORDER);
            Order order2 = customer2.CreatePhoneOrder(address2, OrderType.PHONE_ORDER);
            Order order3 = customer3.CreatePhoneOrder(address3, OrderType.PHONE_ORDER);
            Order order4 = customer1.CreatePhoneOrder(address1, OrderType.PHONE_ORDER);

            //Tying to change customer for order 4

            order4.Customer = customer3;
            order4.Customer = customer1;

            Order order5 = new Order();
            Order order6 = new Order();



            titleMeessage("Customer with empty orders");
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);
            Console.WriteLine(internalCustomer);

            //populate orders
            order1.AddOrderItem(menuItems[0]);
            order1.AddOrderItem(menuItems[1]);
            order1.AddOrderItem(menuItems[2]);
            order1.AddOrderItem(menuItems[2]);

            order2.AddOrderItem(menuItems[3]);
            order2.AddOrderItem(menuItems[3]);

            order3.AddOrderItem(menuItems[4]);
            order3.AddOrderItem(menuItems[5]);
            order3.AddOrderItem(menuItems[5]);

            order4.AddOrderItem(menuItems[6]);
            order4.AddOrderItem(menuItems[7]);

            order5.AddOrderItem(menuItems[7]);

            order6.AddOrderItem(menuItems[8]);
            order6.AddOrderItem(menuItems[9]);

            internalCustomer.AddOrder(order5);
            internalCustomer.AddOrder(order6);

            titleMeessage("Customer with  non empty orders");
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);
            Console.WriteLine(internalCustomer);

            //marked as delivered
            order1.Deliver();
            order2.Deliver();
            order3.Deliver();
            order4.Deliver();

            titleMeessage("Customer with all orders delivered");
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);
            Console.WriteLine(internalCustomer);

            titleMeessage("Saving then loading and displaying content");
            repository.Save("Customers.dat");

            repository.Load("Customers.dat");
            foreach (Customer customer in repository.Customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void setMenuItems(MenuItem[] menuItems)
        {
            menuItems[0] = new Coffee();


            menuItems[1] = new CoffeeWithSugar();
            menuItems[2] = new CoffeeDoubleSugar();
            menuItems[3] = new CoffeeWithMilk();
            menuItems[4] = new CoffeeDoubleMilk();
            menuItems[5] = new CoffeeSugarAndMilk();
            menuItems[6] = new CoffeeDoubleDouble();
            menuItems[7] = new SandwichWithBacon();
            menuItems[8] = new SandwichWithRoastedBeef();
            menuItems[9] = new SandwichWithEggSalad();
        }

        private static void titleMeessage(string message)
        {
            Console.WriteLine($"--------------{message}-------------");
        }

        private static void setCustomers(out Customer customer1, out Customer customer2, out Customer customer3,
                                        Address a1, Address a2, Address a3)
        {
            customer1 = new Customer();
            customer1.Address = a1;
            customer1.Name = "Jon Smith";
            customer1.PhoneNumber = 4161234567;

            customer2 = new Customer("Ann Brown", a2, 4169876543);
            customer3 = new Customer("John Dow", a3, 0);

        }

        private static void setAddresses(out Address address1, out Address address2, out Address address3)
        {
            address1.StreetName = "35 Elm St";
            address1.City = "Toronto";
            address1.Province = "ON";
            address1.PostalCode = "M2M 2K5";

            address2.StreetName = "35 Queen St";
            address2.City = "Toronto";
            address2.Province = "ON";
            address2.PostalCode = "M2T 1M1";

            address3.StreetName = "";
            address3.City = "Toronto";
            address3.Province = "ON";
            address3.PostalCode = "";
        }
    
    }
}
