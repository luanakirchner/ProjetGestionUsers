namespace ProjetGestionUsers
{
    partial class frmHome
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRendezVousPrevu = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(24, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblRendezVousPrevu
            // 
            this.lblRendezVousPrevu.AutoSize = true;
            this.lblRendezVousPrevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendezVousPrevu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRendezVousPrevu.Location = new System.Drawing.Point(81, 65);
            this.lblRendezVousPrevu.Name = "lblRendezVousPrevu";
            this.lblRendezVousPrevu.Size = new System.Drawing.Size(280, 25);
            this.lblRendezVousPrevu.TabIndex = 1;
            this.lblRendezVousPrevu.Text = "Rendez vous prevu aujourd\'hui";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(416, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 126);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1020, 634);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblRendezVousPrevu);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(269, 85);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRendezVousPrevu;
        private System.Windows.Forms.ListView listView1;
    }
}