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
    public partial class frmFicheClient1 : Form
    {
        public bool clienTrouve = false;
        public frmFicheClient1()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.ChekValuesNotVide(txtNom.Text,txtPrenom.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            clienTrouve = false;
            if (clienTrouve == true)
            {
                this.Close();
            }
            else
            {

            }
           
           

        }
    }
}
