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
        public void Open()
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
            idNationalites = ControllerNationalites(user.IdNationalite);
            idProfession = InsertProfession(user.IdProffession);
            idCustomerCards = InsertCustommerCards();

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
            return listAddress;
        }
        public long InsertAddress(Address address)
        {
            string commande = "INSERT INTO address VALUES(NULL,'"+address.City+"',"+address.Zip+","+address.Country.Id+");";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }
        public long InsertProfession(Profesions profesions)
        {
            string commande = "INSERT INTO Professions VALUES(NULL,'" + profesions.Profession + "','" + profesions.Localite + "');";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }
        public long InsertCustommerCards()
        {
            string commande = "INSERT INTO CustommerCards VALUES(NULL);";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }
        public long ControllerNationalites(Nationalites nationalites)
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

        public List<Nationalites> SelectNationalitesWhereNationalites(Nationalites nationalites)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id, nationalite FROM Nationalites WHERE city = '" + nationalites.Nationalite + "';";
            List<Nationalites> listnationalites = new List<Nationalites>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string nationalite = dataReader["nationalite"].ToString();

                Nationalites dataAddress = new Nationalites(id, nationalite);
                listnationalites.Add(dataAddress);
            }
            return listnationalites;

        }

        public long InsertNationalites(Nationalites nationalites)
        {
            string commande = "INSERT INTO Nationalites VALUES(NULL,'" + nationalites.Nationalite + "');";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }
    }
}
