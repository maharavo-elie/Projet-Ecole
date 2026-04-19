namespace universite
{
    partial class Etudiant
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etudiant));
            this.label1 = new System.Windows.Forms.Label();
            this.Inscrire_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Reinscrire_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conteneur_etudiant = new System.Windows.Forms.Panel();
            this.ListeBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(115, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des etudiants";
            // 
            // Inscrire_btn
            // 
            this.Inscrire_btn.BorderRadius = 10;
            this.Inscrire_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inscrire_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inscrire_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inscrire_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inscrire_btn.FillColor = System.Drawing.Color.SpringGreen;
            this.Inscrire_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Inscrire_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Inscrire_btn.Location = new System.Drawing.Point(392, 8);
            this.Inscrire_btn.Name = "Inscrire_btn";
            this.Inscrire_btn.Size = new System.Drawing.Size(110, 29);
            this.Inscrire_btn.TabIndex = 6;
            this.Inscrire_btn.Text = "S\'inscrire";
            this.Inscrire_btn.Click += new System.EventHandler(this.Inscrire_btn_Click);
            // 
            // Reinscrire_btn
            // 
            this.Reinscrire_btn.BorderRadius = 10;
            this.Reinscrire_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reinscrire_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reinscrire_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reinscrire_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reinscrire_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reinscrire_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Reinscrire_btn.ForeColor = System.Drawing.Color.White;
            this.Reinscrire_btn.Location = new System.Drawing.Point(519, 8);
            this.Reinscrire_btn.Name = "Reinscrire_btn";
            this.Reinscrire_btn.Size = new System.Drawing.Size(110, 29);
            this.Reinscrire_btn.TabIndex = 7;
            this.Reinscrire_btn.Text = "Réinscrire";
            this.Reinscrire_btn.Click += new System.EventHandler(this.Reinscrire_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // conteneur_etudiant
            // 
            this.conteneur_etudiant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.conteneur_etudiant.Location = new System.Drawing.Point(0, 43);
            this.conteneur_etudiant.Name = "conteneur_etudiant";
            this.conteneur_etudiant.Size = new System.Drawing.Size(817, 446);
            this.conteneur_etudiant.TabIndex = 5;
            // 
            // ListeBtn
            // 
            this.ListeBtn.BorderRadius = 10;
            this.ListeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ListeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ListeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ListeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ListeBtn.FillColor = System.Drawing.Color.Pink;
            this.ListeBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListeBtn.Location = new System.Drawing.Point(648, 8);
            this.ListeBtn.Name = "ListeBtn";
            this.ListeBtn.Size = new System.Drawing.Size(149, 29);
            this.ListeBtn.TabIndex = 12;
            this.ListeBtn.Text = "Liste des étudiants";
            this.ListeBtn.Click += new System.EventHandler(this.ListeBtn_Click);
            // 
            // Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.ListeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Reinscrire_btn);
            this.Controls.Add(this.Inscrire_btn);
            this.Controls.Add(this.conteneur_etudiant);
            this.Controls.Add(this.label1);
            this.Name = "Etudiant";
            this.Size = new System.Drawing.Size(817, 489);
            this.Load += new System.EventHandler(this.Etudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Inscrire_btn;
        private Guna.UI2.WinForms.Guna2Button Reinscrire_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel conteneur_etudiant;
        private Guna.UI2.WinForms.Guna2Button ListeBtn;
    }
}
