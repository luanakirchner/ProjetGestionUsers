using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class Appointment
    {
        private long id;
        private DateTime date;
        private string heure;
        private string locality;
        private string description;

        public long Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public string Locality { get => locality; set => locality = value; }
        public string Description { get => description; set => description = value; }
    }
}
