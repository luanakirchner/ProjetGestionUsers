using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionUsers
{
    public partial class FrmAddUsers : Form
    {
        ConnectionDB conectDB = new ConnectionDB();

        public FrmAddUsers()
        {
            InitializeComponent();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGenre.SelectedIndex == -1)
                {
                    throw new Exception("Entrez un genre");
                }
                //Recuperer le genre selectionée
                Genres genreSelectionne = (Genres)cmbGenre.SelectedItem;
                //Controller les champs obligatoire, non vides
                Controller.ChekValuesNotVide(txtNom.Text, txtPrenom.Text, txtPays.Text);
                //Recuperer l'id du pays
                long idCountry = conectDB.ControllerCountryAdress(txtPays.Text);
                //Controller le format de la date
                Controller.DateController(txtDateDeNaissance.Text);
                /* //Créer un objet dans classe adresse
                 Address adresse = new Address(txtVille.Text, txtNpa.Text, idCountry);
                 //Créer un objet dans classe Profession
                 Profesions profesion = new Profesions(txtProfession.Text, txtLieu.Text);
                 //Créer un objet dans classe Users
                 Users utilisateur = new Users(txtPrenom.Text, txtNom.Text, txtDateDeNaissance.Text, txtNationalite.Text, txtRue.Text, txtTelephoneFixe.Text, txtTelephonePortable.Text, txtEmail.Text, genreSelectionne.Id, adresse, profesion);
                 //Passe l'objet de la classe user dans la methode d'insertions des données dans MySql
                 conectDB.InsertUsers(utilisateur);
                 MessageBox.Show("Votre utilisateur a été ajouteé");
                 ClearChamps();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearChamps();
        }

        public void ClearChamps()
        {
            txtDateDeNaissance.Text = "";
            txtEmail.Text = "";
            txtLieu.Text = "";
            txtNationalite.Text = "";
            txtNom.Text = "";
            txtNpa.Text = "";
            txtPays.Text = "";
            txtPrenom.Text = "";
            txtProfession.Text = "";
            txtRue.Text = "";
            txtTelephoneFixe.Text = "";
            txtTelephonePortable.Text = "";
            txtVille.Text = "";
            
        }

        private void FrmAddUsers_Load(object sender, EventArgs e)
        {
            txtDateDeNaissance.Text = "Format - 2019.01.30";
            List<Genres> listgenres = conectDB.SelectGenres();
             foreach (Genres value in listgenres)
             {
                cmbGenre.Items.Add(value);
             }

        }
    }
}
