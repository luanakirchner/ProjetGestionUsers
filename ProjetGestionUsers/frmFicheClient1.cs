﻿using System;
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
            clienTrouve = true;
            this.Close();



        }
    }
}
