using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class Users
    {
        private long id;
        private Genres idGenre;
        private string firstaname;
        private string lastname;
        private DateTime birthdate;
        private Address idAddress;
        private string street;
        private string phone;
        private string cellphone;
        private string email;
        private Profesions idProffession;
        private Nationalites idNationalite;
        private CustomerCards idCustomercards;


        public long Id { get => id; set => id = value; }
        public string Firstaname { get => firstaname; set => firstaname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Street { get => street; set => street = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public string Email { get => email; set => email = value; }
        internal Genres IdGenre { get => idGenre; set => idGenre = value; }
        internal Address IdAddress { get => idAddress; set => idAddress = value; }
        internal Profesions IdProffession { get => idProffession; set => idProffession = value; }
        internal Nationalites IdNationalite { get => idNationalite; set => idNationalite = value; }
        internal CustomerCards IdCustomercards { get => idCustomercards; set => idCustomercards = value; }

       
    }
}
