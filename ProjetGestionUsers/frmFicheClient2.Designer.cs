namespace ProjetGestionUsers
{
    partial class frmFicheClient2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblRendezVous = new System.Windows.Forms.Label();
            this.lblDerniereRendezVous = new System.Windows.Forms.Label();
            this.cmbRendezVousPrevu = new System.Windows.Forms.ComboBox();
            this.lstDerniereRendezVous = new System.Windows.Forms.ListBox();
            this.txtDateRendezVous = new System.Windows.Forms.TextBox();
            this.txtHeureRendezVous = new System.Windows.Forms.TextBox();
            this.txtLocalite = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gpbRemarqueRendezVous = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValiderRemarque = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.gpbRemarqueRendezVous.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNom.Location = new System.Drawing.Point(36, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 25);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrenom.Location = new System.Drawing.Point(162, 9);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(80, 25);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescription.Location = new System.Drawing.Point(122, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 29);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescription.Location = new System.Drawing.Point(306, 83);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(682, 199);
            this.txtDescription.TabIndex = 3;
            // 
            // lblRendezVous
            // 
            this.lblRendezVous.AutoSize = true;
            this.lblRendezVous.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendezVous.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRendezVous.Location = new System.Drawing.Point(25, 325);
            this.lblRendezVous.Name = "lblRendezVous";
            this.lblRendezVous.Size = new System.Drawing.Size(232, 29);
            this.lblRendezVous.TabIndex = 4;
            this.lblRendezVous.Text = "Rendez-vous prevu?";
            // 
            // lblDerniereRendezVous
            // 
            this.lblDerniereRendezVous.AutoSize = true;
            this.lblDerniereRendezVous.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerniereRendezVous.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDerniereRendezVous.Location = new System.Drawing.Point(12, 394);
            this.lblDerniereRendezVous.Name = "lblDerniereRendezVous";
            this.lblDerniereRendezVous.Size = new System.Drawing.Size(245, 29);
            this.lblDerniereRendezVous.TabIndex = 5;
            this.lblDerniereRendezVous.Text = "Dernière rendez-vous";
            // 
            // cmbRendezVousPrevu
            // 
            this.cmbRendezVousPrevu.FormattingEnabled = true;
            this.cmbRendezVousPrevu.Location = new System.Drawing.Point(306, 333);
            this.cmbRendezVousPrevu.Name = "cmbRendezVousPrevu";
            this.cmbRendezVousPrevu.Size = new System.Drawing.Size(121, 21);
            this.cmbRendezVousPrevu.TabIndex = 6;
            // 
            // lstDerniereRendezVous
            // 
            this.lstDerniereRendezVous.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstDerniereRendezVous.FormattingEnabled = true;
            this.lstDerniereRendezVous.Location = new System.Drawing.Point(306, 394);
            this.lstDerniereRendezVous.Name = "lstDerniereRendezVous";
            this.lstDerniereRendezVous.Size = new System.Drawing.Size(121, 186);
            this.lstDerniereRendezVous.TabIndex = 7;
            // 
            // txtDateRendezVous
            // 
            this.txtDateRendezVous.Location = new System.Drawing.Point(514, 334);
            this.txtDateRendezVous.Name = "txtDateRendezVous";
            this.txtDateRendezVous.Size = new System.Drawing.Size(98, 20);
            this.txtDateRendezVous.TabIndex = 8;
            // 
            // txtHeureRendezVous
            // 
            this.txtHeureRendezVous.Location = new System.Drawing.Point(703, 334);
            this.txtHeureRendezVous.Name = "txtHeureRendezVous";
            this.txtHeureRendezVous.Size = new System.Drawing.Size(98, 20);
            this.txtHeureRendezVous.TabIndex = 9;
            // 
            // txtLocalite
            // 
            this.txtLocalite.Location = new System.Drawing.Point(890, 334);
            this.txtLocalite.Name = "txtLocalite";
            this.txtLocalite.Size = new System.Drawing.Size(98, 20);
            this.txtLocalite.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.Location = new System.Drawing.Point(146, 19);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(297, 118);
            this.textBox5.TabIndex = 11;
            // 
            // gpbRemarqueRendezVous
            // 
            this.gpbRemarqueRendezVous.Controls.Add(this.label3);
            this.gpbRemarqueRendezVous.Controls.Add(this.btnValiderRemarque);
            this.gpbRemarqueRendezVous.Controls.Add(this.textBox5);
            this.gpbRemarqueRendezVous.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbRemarqueRendezVous.Location = new System.Drawing.Point(537, 394);
            this.gpbRemarqueRendezVous.Name = "gpbRemarqueRendezVous";
            this.gpbRemarqueRendezVous.Size = new System.Drawing.Size(451, 186);
            this.gpbRemarqueRendezVous.TabIndex = 12;
            this.gpbRemarqueRendezVous.TabStop = false;
            this.gpbRemarqueRendezVous.Text = "Remarque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // btnValiderRemarque
            // 
            this.btnValiderRemarque.BackColor = System.Drawing.Color.DarkCyan;
            this.btnValiderRemarque.Location = new System.Drawing.Point(297, 157);
            this.btnValiderRemarque.Name = "btnValiderRemarque";
            this.btnValiderRemarque.Size = new System.Drawing.Size(148, 23);
            this.btnValiderRemarque.TabIndex = 12;
            this.btnValiderRemarque.Text = "Sauve remarque";
            this.btnValiderRemarque.UseVisualStyleBackColor = false;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauvegarder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSauvegarder.Location = new System.Drawing.Point(770, 12);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(218, 43);
            this.btnSauvegarder.TabIndex = 13;
            this.btnSauvegarder.Text = "Sauvergarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            // 
            // frmFicheClient2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1020, 634);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.gpbRemarqueRendezVous);
            this.Controls.Add(this.txtLocalite);
            this.Controls.Add(this.txtHeureRendezVous);
            this.Controls.Add(this.txtDateRendezVous);
            this.Controls.Add(this.lstDerniereRendezVous);
            this.Controls.Add(this.cmbRendezVousPrevu);
            this.Controls.Add(this.lblDerniereRendezVous);
            this.Controls.Add(this.lblRendezVous);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFicheClient2";
            this.Text = "frmFicheClient2";
            this.gpbRemarqueRendezVous.ResumeLayout(false);
            this.gpbRemarqueRendezVous.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblRendezVous;
        private System.Windows.Forms.Label lblDerniereRendezVous;
        private System.Windows.Forms.ComboBox cmbRendezVousPrevu;
        private System.Windows.Forms.ListBox lstDerniereRendezVous;
        private System.Windows.Forms.TextBox txtDateRendezVous;
        private System.Windows.Forms.TextBox txtHeureRendezVous;
        private System.Windows.Forms.TextBox txtLocalite;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gpbRemarqueRendezVous;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValiderRemarque;
        private System.Windows.Forms.Button btnSauvegarder;
    }
}