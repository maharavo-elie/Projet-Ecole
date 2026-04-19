namespace universite
{
    partial class Profil
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnModif = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_info = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_modif = new Guna.UI2.WinForms.Guna2Button();
            this.Conteneur = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(815, 41);
            this.guna2GradientPanel1.TabIndex = 177;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(315, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mon profil";
            // 
            // BtnModif
            // 
            this.BtnModif.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModif.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnModif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnModif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnModif.ForeColor = System.Drawing.Color.White;
            this.BtnModif.Location = new System.Drawing.Point(3, 76);
            this.BtnModif.Name = "BtnModif";
            this.BtnModif.Size = new System.Drawing.Size(180, 23);
            this.BtnModif.TabIndex = 182;
            this.BtnModif.Text = "Modifier les informations";
            this.BtnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // Btn_info
            // 
            this.Btn_info.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_info.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_info.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_info.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_info.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_info.ForeColor = System.Drawing.Color.White;
            this.Btn_info.Location = new System.Drawing.Point(3, 47);
            this.Btn_info.Name = "Btn_info";
            this.Btn_info.Size = new System.Drawing.Size(180, 23);
            this.Btn_info.TabIndex = 179;
            this.Btn_info.Text = "Mes informations";
            this.Btn_info.Click += new System.EventHandler(this.Btn_info_Click);
            // 
            // Btn_modif
            // 
            this.Btn_modif.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_modif.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_modif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_modif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_modif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_modif.ForeColor = System.Drawing.Color.White;
            this.Btn_modif.Location = new System.Drawing.Point(3, 105);
            this.Btn_modif.Name = "Btn_modif";
            this.Btn_modif.Size = new System.Drawing.Size(180, 23);
            this.Btn_modif.TabIndex = 180;
            this.Btn_modif.Text = "Modifier le mot de passe";
            this.Btn_modif.Click += new System.EventHandler(this.Btn_modif_Click);
            // 
            // Conteneur
            // 
            this.Conteneur.Location = new System.Drawing.Point(189, 47);
            this.Conteneur.Name = "Conteneur";
            this.Conteneur.Size = new System.Drawing.Size(442, 365);
            this.Conteneur.TabIndex = 181;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnModif);
            this.Controls.Add(this.Conteneur);
            this.Controls.Add(this.Btn_modif);
            this.Controls.Add(this.Btn_info);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Profil";
            this.Size = new System.Drawing.Size(815, 501);
            this.Load += new System.EventHandler(this.Profil_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button BtnModif;
        private Guna.UI2.WinForms.Guna2Button Btn_info;
        private Guna.UI2.WinForms.Guna2Button Btn_modif;
        private Guna.UI2.WinForms.Guna2Panel Conteneur;
    }
}
