namespace universite
{
    partial class Parametre
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
            this.params_conteneur = new System.Windows.Forms.Panel();
            this.Btn_conf_params = new Guna.UI2.WinForms.Guna2Button();
            this.btn_voir_conf = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_droit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // params_conteneur
            // 
            this.params_conteneur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.params_conteneur.Location = new System.Drawing.Point(0, 45);
            this.params_conteneur.Name = "params_conteneur";
            this.params_conteneur.Size = new System.Drawing.Size(817, 444);
            this.params_conteneur.TabIndex = 10;
            // 
            // Btn_conf_params
            // 
            this.Btn_conf_params.BorderRadius = 10;
            this.Btn_conf_params.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_conf_params.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_conf_params.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_conf_params.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_conf_params.FillColor = System.Drawing.Color.SpringGreen;
            this.Btn_conf_params.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_conf_params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_conf_params.Location = new System.Drawing.Point(205, 8);
            this.Btn_conf_params.Name = "Btn_conf_params";
            this.Btn_conf_params.Size = new System.Drawing.Size(182, 31);
            this.Btn_conf_params.TabIndex = 17;
            this.Btn_conf_params.Text = "Mon profil";
            this.Btn_conf_params.Click += new System.EventHandler(this.Btn_conf_params_Click);
            // 
            // btn_voir_conf
            // 
            this.btn_voir_conf.BorderRadius = 10;
            this.btn_voir_conf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_voir_conf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_voir_conf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_voir_conf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_voir_conf.FillColor = System.Drawing.Color.Pink;
            this.btn_voir_conf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_voir_conf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_voir_conf.Location = new System.Drawing.Point(614, 8);
            this.btn_voir_conf.Name = "btn_voir_conf";
            this.btn_voir_conf.Size = new System.Drawing.Size(182, 31);
            this.btn_voir_conf.TabIndex = 18;
            this.btn_voir_conf.Text = "Voir mes configurations";
            this.btn_voir_conf.Click += new System.EventHandler(this.btn_voir_conf_Click);
            // 
            // Btn_droit
            // 
            this.Btn_droit.BorderRadius = 10;
            this.Btn_droit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_droit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_droit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_droit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_droit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_droit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_droit.ForeColor = System.Drawing.Color.White;
            this.Btn_droit.Location = new System.Drawing.Point(410, 8);
            this.Btn_droit.Name = "Btn_droit";
            this.Btn_droit.Size = new System.Drawing.Size(182, 31);
            this.Btn_droit.TabIndex = 19;
            this.Btn_droit.Text = "Configurer mes options";
            this.Btn_droit.Click += new System.EventHandler(this.Btn_droit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Paramètres";
            // 
            // Parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_droit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voir_conf);
            this.Controls.Add(this.Btn_conf_params);
            this.Controls.Add(this.params_conteneur);
            this.Name = "Parametre";
            this.Size = new System.Drawing.Size(817, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel params_conteneur;
        private Guna.UI2.WinForms.Guna2Button Btn_conf_params;
        private Guna.UI2.WinForms.Guna2Button btn_voir_conf;
        private Guna.UI2.WinForms.Guna2Button Btn_droit;
        private System.Windows.Forms.Label label1;
    }
}
