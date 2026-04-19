namespace universite
{
    partial class SingIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_inscrire = new Guna.UI2.WinForms.Guna2Button();
            this.cmdps = new Guna.UI2.WinForms.Guna2TextBox();
            this.mdps = new Guna.UI2.WinForms.Guna2TextBox();
            this.nom_univ = new Guna.UI2.WinForms.Guna2TextBox();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.nom_utilisateur = new Guna.UI2.WinForms.Guna2TextBox();
            this.voir_mdps = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 49);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(102, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "S\'inscrire";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Btn_inscrire);
            this.panel2.Controls.Add(this.cmdps);
            this.panel2.Controls.Add(this.mdps);
            this.panel2.Controls.Add(this.nom_univ);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.nom_utilisateur);
            this.panel2.Controls.Add(this.voir_mdps);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 345);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Btn_inscrire
            // 
            this.Btn_inscrire.BorderRadius = 13;
            this.Btn_inscrire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_inscrire.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_inscrire.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_inscrire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_inscrire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_inscrire.FillColor = System.Drawing.Color.Blue;
            this.Btn_inscrire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_inscrire.ForeColor = System.Drawing.Color.White;
            this.Btn_inscrire.Location = new System.Drawing.Point(15, 289);
            this.Btn_inscrire.Name = "Btn_inscrire";
            this.Btn_inscrire.Size = new System.Drawing.Size(313, 39);
            this.Btn_inscrire.TabIndex = 18;
            this.Btn_inscrire.Text = "Inscription";
            this.Btn_inscrire.Click += new System.EventHandler(this.Btn_inscrire_Click);
            // 
            // cmdps
            // 
            this.cmdps.BackColor = System.Drawing.Color.Transparent;
            this.cmdps.BorderColor = System.Drawing.Color.White;
            this.cmdps.BorderRadius = 3;
            this.cmdps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmdps.DefaultText = "";
            this.cmdps.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cmdps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cmdps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cmdps.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cmdps.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmdps.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdps.ForeColor = System.Drawing.Color.Black;
            this.cmdps.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmdps.Location = new System.Drawing.Point(15, 228);
            this.cmdps.Name = "cmdps";
            this.cmdps.PlaceholderText = "";
            this.cmdps.SelectedText = "";
            this.cmdps.Size = new System.Drawing.Size(313, 23);
            this.cmdps.TabIndex = 17;
            this.cmdps.UseSystemPasswordChar = true;
            // 
            // mdps
            // 
            this.mdps.BackColor = System.Drawing.Color.Transparent;
            this.mdps.BorderColor = System.Drawing.Color.White;
            this.mdps.BorderRadius = 3;
            this.mdps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mdps.DefaultText = "";
            this.mdps.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mdps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mdps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mdps.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mdps.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mdps.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.mdps.ForeColor = System.Drawing.Color.Black;
            this.mdps.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mdps.Location = new System.Drawing.Point(15, 178);
            this.mdps.Name = "mdps";
            this.mdps.PlaceholderText = "";
            this.mdps.SelectedText = "";
            this.mdps.Size = new System.Drawing.Size(313, 23);
            this.mdps.TabIndex = 16;
            this.mdps.UseSystemPasswordChar = true;
            // 
            // nom_univ
            // 
            this.nom_univ.BackColor = System.Drawing.Color.Transparent;
            this.nom_univ.BorderColor = System.Drawing.Color.White;
            this.nom_univ.BorderRadius = 3;
            this.nom_univ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_univ.DefaultText = "";
            this.nom_univ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom_univ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom_univ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom_univ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom_univ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom_univ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.nom_univ.ForeColor = System.Drawing.Color.Black;
            this.nom_univ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom_univ.Location = new System.Drawing.Point(15, 128);
            this.nom_univ.Name = "nom_univ";
            this.nom_univ.PlaceholderText = "";
            this.nom_univ.SelectedText = "";
            this.nom_univ.Size = new System.Drawing.Size(313, 23);
            this.nom_univ.TabIndex = 15;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.BorderColor = System.Drawing.Color.White;
            this.email.BorderRadius = 3;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Location = new System.Drawing.Point(15, 78);
            this.email.Name = "email";
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(313, 23);
            this.email.TabIndex = 14;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // nom_utilisateur
            // 
            this.nom_utilisateur.BackColor = System.Drawing.Color.Transparent;
            this.nom_utilisateur.BorderColor = System.Drawing.Color.White;
            this.nom_utilisateur.BorderRadius = 3;
            this.nom_utilisateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_utilisateur.DefaultText = "";
            this.nom_utilisateur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom_utilisateur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom_utilisateur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom_utilisateur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom_utilisateur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom_utilisateur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.nom_utilisateur.ForeColor = System.Drawing.Color.Black;
            this.nom_utilisateur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom_utilisateur.Location = new System.Drawing.Point(15, 28);
            this.nom_utilisateur.Name = "nom_utilisateur";
            this.nom_utilisateur.PlaceholderText = "";
            this.nom_utilisateur.SelectedText = "";
            this.nom_utilisateur.Size = new System.Drawing.Size(313, 23);
            this.nom_utilisateur.TabIndex = 13;
            // 
            // voir_mdps
            // 
            this.voir_mdps.AutoSize = true;
            this.voir_mdps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voir_mdps.ForeColor = System.Drawing.Color.Blue;
            this.voir_mdps.Location = new System.Drawing.Point(148, 263);
            this.voir_mdps.Name = "voir_mdps";
            this.voir_mdps.Size = new System.Drawing.Size(180, 17);
            this.voir_mdps.TabIndex = 11;
            this.voir_mdps.Text = "afficher les mots de passes";
            this.voir_mdps.UseVisualStyleBackColor = true;
            this.voir_mdps.CheckedChanged += new System.EventHandler(this.voir_mdps_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirmer votre mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom de l\'Université :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom d\'utilisateur :";
            // 
            // SingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SingIn";
            this.Size = new System.Drawing.Size(353, 397);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox voir_mdps;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox nom_utilisateur;
        private Guna.UI2.WinForms.Guna2TextBox cmdps;
        private Guna.UI2.WinForms.Guna2TextBox mdps;
        private Guna.UI2.WinForms.Guna2TextBox nom_univ;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2Button Btn_inscrire;
    }
}
