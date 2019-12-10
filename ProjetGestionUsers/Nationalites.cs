using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class Nationalites
    {
        private long id;
        private string nationalite;

        public long Id { get => id; set => id = value; }
        public string Nationalite { get => nationalite; set => nationalite = value; }

        public Nationalites(long id, string nationalite)
        {
            this.id = id;
            this.nationalite = nationalite;
        }
        public override string ToString()
        {
            return nationalite;
        }
    }

}
