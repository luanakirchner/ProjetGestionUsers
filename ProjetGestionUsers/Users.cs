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
        private int genre;
        private string firstaname;
        private string lastname;
        private string birthdate;
        private Address idAddress;
        private string street;
        private string phone;
        private string cellphone;
        private string email;
        private Profesions idProffession;
        private string nationalite;
        private CustomerCards idCustomercards;


        public long Id { get => id; set => id = value; }
        public string Firstaname { get => firstaname; set => firstaname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string Street { get => street; set => street = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public string Email { get => email; set => email = value; }
        public int Genre { get => genre; set => genre = value; }
        public string Nationalite { get => nationalite; set => nationalite = value; }
        internal Address IdAddress { get => idAddress; set => idAddress = value; }
        internal Profesions IdProffession { get => idProffession; set => idProffession = value; }
        internal CustomerCards IdCustomercards { get => idCustomercards; set => idCustomercards = value; }

        public Users(string firstaname, string lastname, string birthdate, string nationalite, string street, string phone, string cellphone, string email, int genre, Address adresse, Profesions profession, int id = 0)
        {
            this.id = id;
            this.firstaname = firstaname;
            this.lastname = lastname;
            this.birthdate = birthdate;
            this.street = street;
            this.phone = phone;
            this.cellphone = cellphone;
            this.email = email;
            this.genre = genre;
            this.IdAddress = adresse;
            this.IdProffession = profession;
            this.nationalite = nationalite;
        }
       
    }
}
