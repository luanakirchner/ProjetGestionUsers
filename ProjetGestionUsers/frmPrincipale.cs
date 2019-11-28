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
           
        }

        private void HOME_Click(object sender, EventArgs e)
        {
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
    }
}
