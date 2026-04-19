namespace universite
{
    partial class Personnelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.conteneur = new System.Windows.Forms.Panel();
            this.Liste_secertaireBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Ajouter_secretaire = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des personnelles";
            // 
            // conteneur
            // 
            this.conteneur.Location = new System.Drawing.Point(253, 57);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(559, 432);
            this.conteneur.TabIndex = 3;
            // 
            // Liste_secertaireBtn
            // 
            this.Liste_secertaireBtn.BorderRadius = 10;
            this.Liste_secertaireBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Liste_secertaireBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Liste_secertaireBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Liste_secertaireBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Liste_secertaireBtn.FillColor = System.Drawing.Color.Blue;
            this.Liste_secertaireBtn.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liste_secertaireBtn.ForeColor = System.Drawing.Color.White;
            this.Liste_secertaireBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Liste_secertaireBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Liste_secertaireBtn.Location = new System.Drawing.Point(603, 12);
            this.Liste_secertaireBtn.Name = "Liste_secertaireBtn";
            this.Liste_secertaireBtn.Size = new System.Drawing.Size(198, 31);
            this.Liste_secertaireBtn.TabIndex = 1;
            this.Liste_secertaireBtn.Text = "Liste secretaires";
            this.Liste_secertaireBtn.Click += new System.EventHandler(this.Liste_secertaireBtn_Click);
            // 
            // Ajouter_secretaire
            // 
            this.Ajouter_secretaire.BorderRadius = 10;
            this.Ajouter_secretaire.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ajouter_secretaire.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ajouter_secretaire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ajouter_secretaire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ajouter_secretaire.FillColor = System.Drawing.Color.Blue;
            this.Ajouter_secretaire.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_secretaire.ForeColor = System.Drawing.Color.White;
            this.Ajouter_secretaire.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Ajouter_secretaire.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ajouter_secretaire.Location = new System.Drawing.Point(399, 12);
            this.Ajouter_secretaire.Name = "Ajouter_secretaire";
            this.Ajouter_secretaire.Size = new System.Drawing.Size(198, 31);
            this.Ajouter_secretaire.TabIndex = 0;
            this.Ajouter_secretaire.Text = "Ajouter un(e) secretaire";
            this.Ajouter_secretaire.Click += new System.EventHandler(this.Ajouter_secretaire_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Liste_secertaireBtn);
            this.panel1.Controls.Add(this.Ajouter_secretaire);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 55);
            this.panel1.TabIndex = 0;
            // 
            // Personnelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.conteneur);
            this.Name = "Personnelle";
            this.Size = new System.Drawing.Size(817, 489);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Ajouter_secretaire;
        private Guna.UI2.WinForms.Guna2Button Liste_secertaireBtn;
    }
}
