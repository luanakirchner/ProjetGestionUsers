using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class Genres
    {
        private long id;
        private string genre;

        public long Id { get => id; set => id = value; }
        public string Genre { get => genre; set => genre = value; }

        public Genres(long id, string genre)
        {
            this.id = id;
            this.genre = genre;
        }
        public override string ToString()
        {
            return genre;
        }
    }
}
