using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        public void Save(string fileName)
        {
            Stream stream = File.Open(fileName, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, customers);
            stream.Close();
        }

        public void Load(string fileName)
        {
            Stream stream = File.Open(fileName, FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            customers = (List<Customer>)bf.Deserialize(stream);
            stream.Close();
        }

    }
}
