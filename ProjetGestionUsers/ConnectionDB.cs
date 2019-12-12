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
            string commande = "INSERT INTO Users VALUES(NULL,'"+user.Firstaname+"','" + user.Lastname + "',' 2019.12.26','" + user.Street + "','" + user.Phone + "','" + user.Cellphone + "','" + user.Email + "'," + user.Genre + "," +idAddresse + "," + idProfession + "," + idNationalites + "," + idCustomerCards + "); ";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            connection.Close();


        }

        public long ControllerAddress(Address address)
        {
            long idAddresse = 0;
            //Recuperer la list des address
            List<Address> listAddress = SelectAddressWhereCity(address);
            //Si l'address exite déjà -- Recuperer l'id
            if(listAddress.Count > 1)
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
            if (listnationalites.Count > 1)
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
    }
}
