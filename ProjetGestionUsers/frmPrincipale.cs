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
    public partial class frmPrincipale : Form
    {
        private Form _objFrom;
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMenu.Text = "Bienvenu";
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Home";
            _objFrom?.Close();
            _objFrom = new frmHome
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipale.Controls.Add(_objFrom);
            _objFrom.Show();
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {
            _objFrom?.Close();
            _objFrom = new FrmUsers
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipale.Controls.Add(_objFrom);
            _objFrom.Show();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            //Menu normale
            if(pnlMenu.Width == 70)
            {
                pnlMenu.Width = 236;
                pnlPrincipale.Width = 1020;
                pnlPrincipale.Location = new Point(252, 93);
                lblMenu.Location = new Point(243, 12);

            }
            //menu redimensionner
            else
            {
                pnlMenu.Width = 70;
                pnlPrincipale.Width = 1080;
                pnlPrincipale.Location = new Point(140, 93);
                lblMenu.Location = new Point(131, 12);
                //pnlPrincipale.Left = 100;

            }
           
        }

        private void lblAddUsers_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Nouveau utilisateur";
            _objFrom?.Close();
            _objFrom = new FrmAddUsers
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipale.Controls.Add(_objFrom);
            _objFrom.Show();
        }

        private void lblFileUsers_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Fiche des clients";
            _objFrom?.Close();
            _objFrom = new frmFicheClient1
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlPrincipale.Controls.Add(_objFrom);
            _objFrom.Show();
        }
    }
}
