namespace ProjetGestionUsers
{
    partial class frmFicheClient1
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.picFicheClient = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFicheClient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(405, 168);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(332, 37);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(405, 332);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(332, 37);
            this.txtPrenom.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblNom.Location = new System.Drawing.Point(398, 116);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(111, 39);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom *";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblPrenom.Location = new System.Drawing.Point(398, 280);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(136, 39);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.SandyBrown;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.Window;
            this.btnValider.Location = new System.Drawing.Point(405, 472);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(332, 43);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Chercher client";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // picFicheClient
            // 
            this.picFicheClient.Image = global::ProjetGestionUsers.Properties.Resources.contract__1_;
            this.picFicheClient.Location = new System.Drawing.Point(96, 142);
            this.picFicheClient.Name = "picFicheClient";
            this.picFicheClient.Size = new System.Drawing.Size(230, 239);
            this.picFicheClient.TabIndex = 5;
            this.picFicheClient.TabStop = false;
            // 
            // frmFicheClient1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1020, 634);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.picFicheClient);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFicheClient1";
            this.Text = "frmFicheClient1";
            ((System.ComponentModel.ISupportInitialize)(this.picFicheClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.PictureBox picFicheClient;
        private System.Windows.Forms.Button btnValider;
    }
}