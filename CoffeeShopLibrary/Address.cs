using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLibrary
{
    public struct Address
    {
        private string streetName;
        private string postalCode;
        private string city;
        private string province;
        private string country;

        public string StreetName { get { return streetName; } set { streetName = value; } }
        public string PostalCode { get { return postalCode; } set { postalCode = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Province { get { return province; } set { province = value; } }
        public string Country { get { return country; } set { country = value; } }

        public Address(string streetName, string postalCode, string city, string province, string country)
        {
            this.streetName = streetName;
            this.postalCode = postalCode;
            this.city = city;
            this.province = province;
            this.country = country;
        }

        public static Address SHOP_ADDRESS
        {
            get
            {
                return new Address("4060 Lawrence ave E", "M1B 2RC", "Scarborough",  "ON", "Canada");
            }
        }

        public string GetInfo()
        {
            return $"{streetName} {postalCode} {city} {province}, {country}";
        }
    }
}
