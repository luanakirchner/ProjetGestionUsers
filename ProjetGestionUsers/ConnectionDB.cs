using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace ProjetGestionUsers
{
     class ConnectionDB
    {
        private MySqlConnection connection;
        public ConnectionDB()
        {
            InitConnection();
        }
        ConfigurationDB configJson;
        public void ReadJson()
        {
            string Jsonformat = File.ReadAllText(Application.StartupPath + "/Json/ConnectionDB.json");
            configJson = ConfigurationDB.FromJson(Jsonformat);

        }
        public void InitConnection()
        {
            ReadJson();
            string connectionString = "SERVER =" + configJson.Server + ";" + "DATABASE =" + configJson.Database + ";" + "UID =" + configJson.Uid + ";" + "PASSWORD =" + configJson.Password;
            connection = new MySqlConnection(connectionString);

        }
        public void OpenDB()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " Erreur - ConnectionDB");
            }
        }


       /* public List<Users> SelectUserForLastNameFirstName(string nom, string prenom)
        {
            OpenDB();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id,nom FROM countrys WHERE country = '" + countrys + "';";
            List<Users> listuser = new List<Users>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string country = dataReader["country"].ToString();

                Countrys dataCountry = new Countrys(id, country);
                listCountry.Add(dataCountry);
            }
            connection.Close();
            return listuser;
           
        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public void InsertUsers(Users user)
        {
            long idAddresse;
            long idNationalites;
            long idProfession;
            long idCustomerCards;
            idAddresse = ControllerAddress(user.IdAddress);
            idNationalites = ControllerNationalites(user.Nationalite);
            idProfession = InsertProfession(user.IdProffession);
            idCustomerCards = InsertCustommerCards();
            OpenDB();
            string commande = "INSERT INTO Users VALUES(NULL,'"+user.Firstaname+"','" + user.Lastname + "','"+user.Birthdate+"','" + user.Street + "','" + user.Phone + "','" + user.Cellphone + "','" + user.Email + "'," + user.Genre + "," +idAddresse + "," + idProfession + "," + idNationalites + "," + idCustomerCards + "); ";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            connection.Close();


        }

        public long ControllerCountryAdress(string country)
        {
            long idCountry = 0;
            //Recuperer la list des pays
            List<Countrys> listCountry = SelectCountrysWhereCountry(country);
            //Si le pays exite déjà -- Recuperer l'id
            if (listCountry.Count > 0)
            {
                foreach (Countrys value in listCountry)
                {
                    idCountry = value.Id;
                }
                return idCountry;
            }
            //Si le pays n'exite pas -- Inserer le pays et recuperer l'id
            else
            {
                idCountry = InsertCountry(country);
                return idCountry;
            }

        }
        /// <summary>
        /// Recupere la liste de pays par rapport au pays demandée 
        /// </summary>
        /// <param name="countrys">Pays à recuperer</param>
        /// <returns>Liste de pays touvrée</returns>
        public List<Countrys> SelectCountrysWhereCountry(string countrys)
        {
            OpenDB();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id,country FROM countrys WHERE country = '" + countrys + "';";
            List<Countrys> listCountry = new List<Countrys>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string country = dataReader["country"].ToString();

                Countrys dataCountry = new Countrys(id, country);
                listCountry.Add(dataCountry);
            }
            connection.Close();
            return listCountry;

        }
        public long InsertCountry(string Countrys)
        {
            OpenDB();
            string commande = "INSERT INTO countrys VALUES(NULL,'" + Countrys + "');";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return cmd.LastInsertedId;

        }

        public long ControllerAddress(Address address)
        {
            long idAddresse = 0;
            //Recuperer la list des address
            List<Address> listAddress = SelectAddressWhereCity(address);
            //Si l'address exite déjà -- Recuperer l'id
            if(listAddress.Count > 0)
            {
                foreach (Address value in listAddress)
                {
                    idAddresse = value.Id;
                }
                return idAddresse;
            }
            //Si l'adresse n'exite pas -- Inserer l'adresse et recuperer l'id
            else
            {
                idAddresse = InsertAddress(address);
                return idAddresse;
            }
            
        }
        public List<Address> SelectAddressWhereCity(Address address)
        {
            OpenDB();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id,city,zip FROM address WHERE city = '"+address.City+"';";
            List<Address> listAddress = new List<Address>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string city = dataReader["city"].ToString();
                string zip = dataReader["zip"].ToString();

                Address dataAddress = new Address(id,city,zip,address.Country);
                listAddress.Add(dataAddress);
            }
            connection.Close();
            return listAddress;

        }
        public long InsertAddress(Address address)
        {
            OpenDB();
            string commande = "INSERT INTO address VALUES(NULL,'"+address.City+"','"+address.Zip+"',"+address.Country+");";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return cmd.LastInsertedId;
            
        }
        public long InsertProfession(Profesions profesions)
        {
            OpenDB();
            string commande = "INSERT INTO Professions VALUES(NULL,'" + profesions.Profession + "','" + profesions.Localite + "');";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return cmd.LastInsertedId;
        }
        public long InsertCustommerCards()
        {
            OpenDB();
            string commande = "INSERT INTO customercards(Description) VALUES('');";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return cmd.LastInsertedId;
        }
        public long ControllerNationalites(string nationalites)
        {
            long idnationalites = 0;
            //Recuperer la list des address
            List<Nationalites> listnationalites = SelectNationalitesWhereNationalites(nationalites);
            //Si l'address exite déjà -- Recuperer l'id
            if (listnationalites.Count > 0)
            {
                foreach (Nationalites value in listnationalites)
                {
                    idnationalites = value.Id;
                }
                return idnationalites;
            }
            //Si l'adresse n'exite pas -- Inserer l'adresse et recuperer l'id
            else
            {
                idnationalites = InsertNationalites(nationalites);
                return idnationalites;
            }
        }

        public List<Nationalites> SelectNationalitesWhereNationalites(string nationalites)
        {
            OpenDB();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id, nationalite FROM Nationalites WHERE nationalite = '" + nationalites + "';";
            List<Nationalites> listnationalites = new List<Nationalites>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string nationalite = dataReader["nationalite"].ToString();

                Nationalites dataAddress = new Nationalites(id, nationalite);
                listnationalites.Add(dataAddress);
            }
            connection.Close();
            return listnationalites;

        }

        public long InsertNationalites(string nationalites)
        {
            OpenDB();
            string commande = "INSERT INTO Nationalites VALUES(NULL,'" + nationalites + "');";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return cmd.LastInsertedId;
        }

        public List<Genres> SelectGenres()
        {
            OpenDB();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id, genre FROM Genres;";
            List<Genres> listGenres = new List<Genres>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string genre = dataReader["genre"].ToString();

                Genres dataGenres = new Genres(id, genre);
                listGenres.Add(dataGenres);
            }
            connection.Close();
            return listGenres;

        }
    }
}
