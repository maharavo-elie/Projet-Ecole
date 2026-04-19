namespace universite
{
    partial class ForgotPwd
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
            this.Quitter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_enregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.Mdps = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cmdps = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.AffichePwd = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // Quitter
            // 
            this.Quitter.Animated = true;
            this.Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Quitter.BorderColor = System.Drawing.Color.Blue;
            this.Quitter.DefaultAutoSize = true;
            this.Quitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Quitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Quitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Quitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Quitter.FillColor = System.Drawing.Color.Empty;
            this.Quitter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Quitter.ForeColor = System.Drawing.Color.White;
            this.Quitter.Location = new System.Drawing.Point(210, 2);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(38, 24);
            this.Quitter.TabIndex = 29;
            this.Quitter.Text = "X";
            this.Quitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(24, 89);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(113, 15);
            this.guna2HtmlLabel3.TabIndex = 28;
            this.guna2HtmlLabel3.Text = "Nouveau mot de passe";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 140);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(169, 15);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "Confirmer le nouveau mot de passe";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 37);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(28, 15);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Email";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_enregistrer
            // 
            this.Btn_enregistrer.BorderRadius = 15;
            this.Btn_enregistrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_enregistrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_enregistrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_enregistrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_enregistrer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_enregistrer.ForeColor = System.Drawing.Color.White;
            this.Btn_enregistrer.Location = new System.Drawing.Point(50, 214);
            this.Btn_enregistrer.Name = "Btn_enregistrer";
            this.Btn_enregistrer.Size = new System.Drawing.Size(143, 28);
            this.Btn_enregistrer.TabIndex = 25;
            this.Btn_enregistrer.Text = "Enregistrer";
            this.Btn_enregistrer.Click += new System.EventHandler(this.Btn_enregistrer_Click);
            // 
            // Mdps
            // 
            this.Mdps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Mdps.DefaultText = "";
            this.Mdps.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Mdps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Mdps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Mdps.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Mdps.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Mdps.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Mdps.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Mdps.Location = new System.Drawing.Point(24, 110);
            this.Mdps.Name = "Mdps";
            this.Mdps.PlaceholderText = "";
            this.Mdps.SelectedText = "";
            this.Mdps.Size = new System.Drawing.Size(200, 24);
            this.Mdps.TabIndex = 24;
            this.Mdps.UseSystemPasswordChar = true;
            // 
            // Cmdps
            // 
            this.Cmdps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cmdps.DefaultText = "";
            this.Cmdps.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Cmdps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Cmdps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cmdps.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cmdps.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmdps.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cmdps.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmdps.Location = new System.Drawing.Point(24, 161);
            this.Cmdps.Name = "Cmdps";
            this.Cmdps.PlaceholderText = "";
            this.Cmdps.SelectedText = "";
            this.Cmdps.Size = new System.Drawing.Size(200, 24);
            this.Cmdps.TabIndex = 23;
            this.Cmdps.UseSystemPasswordChar = true;
            // 
            // Email
            // 
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Location = new System.Drawing.Point(24, 58);
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "";
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(200, 25);
            this.Email.TabIndex = 22;
            // 
            // AffichePwd
            // 
            this.AffichePwd.AutoSize = true;
            this.AffichePwd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AffichePwd.CheckedState.BorderRadius = 0;
            this.AffichePwd.CheckedState.BorderThickness = 0;
            this.AffichePwd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AffichePwd.Location = new System.Drawing.Point(86, 191);
            this.AffichePwd.Name = "AffichePwd";
            this.AffichePwd.Size = new System.Drawing.Size(138, 17);
            this.AffichePwd.TabIndex = 30;
            this.AffichePwd.Text = "afficher le mot de passe";
            this.AffichePwd.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AffichePwd.UncheckedState.BorderRadius = 0;
            this.AffichePwd.UncheckedState.BorderThickness = 0;
            this.AffichePwd.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AffichePwd.CheckedChanged += new System.EventHandler(this.AffichePwd_CheckedChanged);
            // 
            // ForgotPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 253);
            this.Controls.Add(this.AffichePwd);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Btn_enregistrer);
            this.Controls.Add(this.Mdps);
            this.Controls.Add(this.Cmdps);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPwd";
            this.Load += new System.EventHandler(this.ForgotPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Quitter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Btn_enregistrer;
        private Guna.UI2.WinForms.Guna2TextBox Mdps;
        private Guna.UI2.WinForms.Guna2TextBox Cmdps;
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private Guna.UI2.WinForms.Guna2CheckBox AffichePwd;
    }
}