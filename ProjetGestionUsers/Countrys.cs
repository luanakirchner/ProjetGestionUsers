using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class Countrys
    {
        private long id;
        private string country;

        public long Id { get => id; set => id = value; }
        public string Country { get => country; set => country = value; }

        public Countrys(int id, string country)
        {
            this.country = country;
            this.id = id;
        }
    }
}
