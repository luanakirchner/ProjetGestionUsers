namespace ProjetGestionUsers
{
    partial class frmPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCalandrier = new System.Windows.Forms.Label();
            this.picFile = new System.Windows.Forms.PictureBox();
            this.lblFileUsers = new System.Windows.Forms.Label();
            this.picAddUsers = new System.Windows.Forms.PictureBox();
            this.lblAddUsers = new System.Windows.Forms.Label();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlPrincipale = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Teal;
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.lblCalandrier);
            this.pnlMenu.Controls.Add(this.picFile);
            this.pnlMenu.Controls.Add(this.lblFileUsers);
            this.pnlMenu.Controls.Add(this.picAddUsers);
            this.pnlMenu.Controls.Add(this.lblAddUsers);
            this.pnlMenu.Controls.Add(this.picUsers);
            this.pnlMenu.Controls.Add(this.picHome);
            this.pnlMenu.Controls.Add(this.picMenu);
            this.pnlMenu.Controls.Add(this.lblUsers);
            this.pnlMenu.Controls.Add(this.lblHome);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(236, 740);
            this.pnlMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetGestionUsers.Properties.Resources.icons8_planner_50;
            this.pictureBox1.Location = new System.Drawing.Point(13, 585);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblCalandrier
            // 
            this.lblCalandrier.AutoSize = true;
            this.lblCalandrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalandrier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCalandrier.Location = new System.Drawing.Point(72, 604);
            this.lblCalandrier.Name = "lblCalandrier";
            this.lblCalandrier.Size = new System.Drawing.Size(139, 31);
            this.lblCalandrier.TabIndex = 9;
            this.lblCalandrier.Text = "Calandrier";
            // 
            // picFile
            // 
            this.picFile.Image = global::ProjetGestionUsers.Properties.Resources.icons8_regular_file_64;
            this.picFile.Location = new System.Drawing.Point(13, 379);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(53, 47);
            this.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFile.TabIndex = 8;
            this.picFile.TabStop = false;
            // 
            // lblFileUsers
            // 
            this.lblFileUsers.AutoSize = true;
            this.lblFileUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFileUsers.Location = new System.Drawing.Point(67, 395);
            this.lblFileUsers.Name = "lblFileUsers";
            this.lblFileUsers.Size = new System.Drawing.Size(166, 31);
            this.lblFileUsers.TabIndex = 7;
            this.lblFileUsers.Text = "Fiche clients";
            this.lblFileUsers.Click += new System.EventHandler(this.lblFileUsers_Click);
            // 
            // picAddUsers
            // 
            this.picAddUsers.Image = global::ProjetGestionUsers.Properties.Resources.icons8_add_user_group_man_man_50__1_;
            this.picAddUsers.Location = new System.Drawing.Point(13, 482);
            this.picAddUsers.Name = "picAddUsers";
            this.picAddUsers.Size = new System.Drawing.Size(53, 52);
            this.picAddUsers.TabIndex = 6;
            this.picAddUsers.TabStop = false;
            // 
            // lblAddUsers
            // 
            this.lblAddUsers.AutoSize = true;
            this.lblAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddUsers.Location = new System.Drawing.Point(72, 503);
            this.lblAddUsers.Name = "lblAddUsers";
            this.lblAddUsers.Size = new System.Drawing.Size(123, 31);
            this.lblAddUsers.TabIndex = 5;
            this.lblAddUsers.Text = "Nouveau";
            this.lblAddUsers.Click += new System.EventHandler(this.lblAddUsers_Click);
            // 
            // picUsers
            // 
            this.picUsers.Image = global::ProjetGestionUsers.Properties.Resources.icons8_user_account_50__1_;
            this.picUsers.Location = new System.Drawing.Point(13, 286);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(53, 48);
            this.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUsers.TabIndex = 4;
            this.picUsers.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::ProjetGestionUsers.Properties.Resources.icons8_home_48__1_;
            this.picHome.Location = new System.Drawing.Point(13, 184);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(49, 46);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHome.TabIndex = 3;
            this.picHome.TabStop = false;
            // 
            // picMenu
            // 
            this.picMenu.Image = global::ProjetGestionUsers.Properties.Resources.icons8_menu_24;
            this.picMenu.Location = new System.Drawing.Point(13, 12);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(29, 24);
            this.picMenu.TabIndex = 2;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsers.Location = new System.Drawing.Point(68, 303);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(150, 31);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Mes clients";
            this.lblUsers.Click += new System.EventHandler(this.lblUsers_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHome.Location = new System.Drawing.Point(68, 199);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(86, 31);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.HOME_Click);
            // 
            // pnlPrincipale
            // 
            this.pnlPrincipale.Location = new System.Drawing.Point(252, 93);
            this.pnlPrincipale.Name = "pnlPrincipale";
            this.pnlPrincipale.Size = new System.Drawing.Size(1020, 634);
            this.pnlPrincipale.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMenu.Location = new System.Drawing.Point(243, 27);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(218, 54);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Bienvenu";
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1290, 739);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pnlPrincipale);
            this.Controls.Add(this.pnlMenu);
            this.MaximizeBox = false;
            this.Name = "frmPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionUser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlPrincipale;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picUsers;
        private System.Windows.Forms.Label lblAddUsers;
        private System.Windows.Forms.PictureBox picAddUsers;
        private System.Windows.Forms.PictureBox picFile;
        private System.Windows.Forms.Label lblFileUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCalandrier;
        private System.Windows.Forms.Label lblMenu;
    }
}

