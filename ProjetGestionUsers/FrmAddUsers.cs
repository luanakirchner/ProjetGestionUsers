using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Address adresse = new Address(txtVille.Text, txtNpa.Text,1);
            Profesions profesion = new Profesions(txtProfession.Text, txtLieu.Text);
            DateTime datebirthdate = DateTime.Parse(txtDateDeNaissance.Text);
            Users utilisateur = new Users(txtPrenom.Text,txtNom.Text, datebirthdate, txtNationalite.Text,txtRue.Text,txtTelephoneFixe.Text,txtTelephonePortable.Text,txtEmail.Text, 1,adresse,profesion);
            conectDB.InsertUsers(utilisateur);
        }
    }
}
