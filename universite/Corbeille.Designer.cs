namespace universite
{
    partial class Corbeille
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
            this.CorbeilleEtudiant = new Guna.UI2.WinForms.Guna2Button();
            this.SecretaireCorbeille = new Guna.UI2.WinForms.Guna2Button();
            this.CorbeillePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(362, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corbeille";
            // 
            // CorbeilleEtudiant
            // 
            this.CorbeilleEtudiant.BorderRadius = 6;
            this.CorbeilleEtudiant.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CorbeilleEtudiant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CorbeilleEtudiant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CorbeilleEtudiant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CorbeilleEtudiant.FillColor = System.Drawing.Color.RoyalBlue;
            this.CorbeilleEtudiant.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorbeilleEtudiant.ForeColor = System.Drawing.Color.White;
            this.CorbeilleEtudiant.Location = new System.Drawing.Point(196, 54);
            this.CorbeilleEtudiant.Name = "CorbeilleEtudiant";
            this.CorbeilleEtudiant.Size = new System.Drawing.Size(153, 34);
            this.CorbeilleEtudiant.TabIndex = 1;
            this.CorbeilleEtudiant.Text = "Etudiants";
            this.CorbeilleEtudiant.Click += new System.EventHandler(this.CorbeilleEtudiant_Click);
            // 
            // SecretaireCorbeille
            // 
            this.SecretaireCorbeille.BorderRadius = 6;
            this.SecretaireCorbeille.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SecretaireCorbeille.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SecretaireCorbeille.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SecretaireCorbeille.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SecretaireCorbeille.FillColor = System.Drawing.Color.RoyalBlue;
            this.SecretaireCorbeille.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecretaireCorbeille.ForeColor = System.Drawing.Color.White;
            this.SecretaireCorbeille.Location = new System.Drawing.Point(472, 54);
            this.SecretaireCorbeille.Name = "SecretaireCorbeille";
            this.SecretaireCorbeille.Size = new System.Drawing.Size(153, 34);
            this.SecretaireCorbeille.TabIndex = 4;
            this.SecretaireCorbeille.Text = "Secretaires";
            this.SecretaireCorbeille.Click += new System.EventHandler(this.SecretaireCorbeille_Click);
            // 
            // CorbeillePanel
            // 
            this.CorbeillePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CorbeillePanel.Location = new System.Drawing.Point(0, 94);
            this.CorbeillePanel.Name = "CorbeillePanel";
            this.CorbeillePanel.Size = new System.Drawing.Size(815, 452);
            this.CorbeillePanel.TabIndex = 5;
            // 
            // Corbeille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CorbeillePanel);
            this.Controls.Add(this.SecretaireCorbeille);
            this.Controls.Add(this.CorbeilleEtudiant);
            this.Controls.Add(this.label1);
            this.Name = "Corbeille";
            this.Size = new System.Drawing.Size(815, 546);
            this.Load += new System.EventHandler(this.Corbeille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button CorbeilleEtudiant;
        private Guna.UI2.WinForms.Guna2Button SecretaireCorbeille;
        private Guna.UI2.WinForms.Guna2Panel CorbeillePanel;
    }
}
