using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class Address
    {
        private int id;
        private string city;
        private string zip;
        private int country;

        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public string Zip { get => zip; set => zip = value; }
        public int Country { get => country; set => country = value; }

        public Address(string city, string zip, int countrys)
        {
            this.city = city;
            this.zip = zip;
            this.country = countrys;
           
        }
        public Address(int id, string city, string zip, int countrys)
        {
            this.id = id;
            this.city = city;
            this.zip = zip;

        }
    }
}
