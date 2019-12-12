using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class Profesions
    {
        private long id;
        private string profession;
        private string localite;

        public long Id { get => id; set => id = value; }
        public string Profession { get => profession; set => profession = value; }
        public string Localite { get => localite; set => localite = value; }

        public Profesions(string profession, string localite, long id = 0 )
        {
            this.id = id;
            this.profession = profession;
            this.localite = localite;
        }
    }
}
