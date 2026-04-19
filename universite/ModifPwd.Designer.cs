namespace universite
{
    partial class ModifPwd
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
            this.Btn_modif = new Guna.UI2.WinForms.Guna2Button();
            this.newPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.cnewPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Affiche = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // Btn_modif
            // 
            this.Btn_modif.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_modif.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_modif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_modif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_modif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_modif.ForeColor = System.Drawing.Color.White;
            this.Btn_modif.Location = new System.Drawing.Point(131, 270);
            this.Btn_modif.Name = "Btn_modif";
            this.Btn_modif.Size = new System.Drawing.Size(180, 29);
            this.Btn_modif.TabIndex = 7;
            this.Btn_modif.Text = "Modifier";
            this.Btn_modif.Click += new System.EventHandler(this.Btn_modif_Click);
            // 
            // newPwd
            // 
            this.newPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPwd.DefaultText = "";
            this.newPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPwd.Location = new System.Drawing.Point(122, 126);
            this.newPwd.Name = "newPwd";
            this.newPwd.PlaceholderText = "";
            this.newPwd.SelectedText = "";
            this.newPwd.Size = new System.Drawing.Size(200, 36);
            this.newPwd.TabIndex = 6;
            this.newPwd.UseSystemPasswordChar = true;
            // 
            // cnewPwd
            // 
            this.cnewPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnewPwd.DefaultText = "";
            this.cnewPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cnewPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cnewPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cnewPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cnewPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cnewPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnewPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cnewPwd.Location = new System.Drawing.Point(122, 205);
            this.cnewPwd.Name = "cnewPwd";
            this.cnewPwd.PlaceholderText = "";
            this.cnewPwd.SelectedText = "";
            this.cnewPwd.Size = new System.Drawing.Size(200, 36);
            this.cnewPwd.TabIndex = 5;
            this.cnewPwd.UseSystemPasswordChar = true;
            // 
            // oldPwd
            // 
            this.oldPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPwd.DefaultText = "";
            this.oldPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oldPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oldPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oldPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.oldPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oldPwd.Location = new System.Drawing.Point(122, 51);
            this.oldPwd.Name = "oldPwd";
            this.oldPwd.PlaceholderText = "";
            this.oldPwd.SelectedText = "";
            this.oldPwd.Size = new System.Drawing.Size(200, 36);
            this.oldPwd.TabIndex = 4;
            this.oldPwd.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(169, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(102, 15);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Ancien mot de passe";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(168, 105);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(103, 15);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Nouvel mot de passe";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(143, 184);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(159, 15);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "Confirmer le nouvel mot de passe";
            // 
            // Affiche
            // 
            this.Affiche.AutoSize = true;
            this.Affiche.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Affiche.CheckedState.BorderRadius = 0;
            this.Affiche.CheckedState.BorderThickness = 0;
            this.Affiche.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Affiche.Location = new System.Drawing.Point(169, 247);
            this.Affiche.Name = "Affiche";
            this.Affiche.Size = new System.Drawing.Size(153, 17);
            this.Affiche.TabIndex = 11;
            this.Affiche.Text = "afficher les mots de passes";
            this.Affiche.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Affiche.UncheckedState.BorderRadius = 0;
            this.Affiche.UncheckedState.BorderThickness = 0;
            this.Affiche.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Affiche.CheckedChanged += new System.EventHandler(this.Affiche_CheckedChanged);
            // 
            // ModifPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Affiche);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Btn_modif);
            this.Controls.Add(this.newPwd);
            this.Controls.Add(this.cnewPwd);
            this.Controls.Add(this.oldPwd);
            this.Name = "ModifPwd";
            this.Size = new System.Drawing.Size(442, 365);
            this.Load += new System.EventHandler(this.ModifPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Btn_modif;
        private Guna.UI2.WinForms.Guna2TextBox newPwd;
        private Guna.UI2.WinForms.Guna2TextBox cnewPwd;
        private Guna.UI2.WinForms.Guna2TextBox oldPwd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CheckBox Affiche;
    }
}
