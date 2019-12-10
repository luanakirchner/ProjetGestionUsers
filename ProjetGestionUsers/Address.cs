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
        private Countrys country;

        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public string Zip { get => zip; set => zip = value; }
        internal Countrys Country { get => country; set => country = value; }

        public Address(int id, string city, string zip, Countrys countrys)
        {
            this.id = id;
            this.city = city;
            this.zip = zip;
            this.country = countrys;
           
        }
        public Address(int id, string city, string zip)
        {
            this.id = id;
            this.city = city;
            this.zip = zip;

        }
    }
}
