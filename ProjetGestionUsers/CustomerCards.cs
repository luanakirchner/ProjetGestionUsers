using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class CustomerCards
    {
        private long id;
        private string description;

        public long Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
    }
}
