namespace universite
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.conteneur = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.parametre_btn = new Guna.UI2.WinForms.Guna2Button();
            this.corbeille_btn = new Guna.UI2.WinForms.Guna2Button();
            this.accueil_btn = new Guna.UI2.WinForms.Guna2Button();
            this.etudiant_btn = new Guna.UI2.WinForms.Guna2Button();
            this.personnelles_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.conteneur.Location = new System.Drawing.Point(200, 50);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(815, 546);
            this.conteneur.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Navy;
            this.menu.Controls.Add(this.parametre_btn);
            this.menu.Controls.Add(this.corbeille_btn);
            this.menu.Controls.Add(this.accueil_btn);
            this.menu.Controls.Add(this.etudiant_btn);
            this.menu.Controls.Add(this.personnelles_btn);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Controls.Add(this.guna2Button1);
            this.menu.Location = new System.Drawing.Point(0, 47);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(199, 555);
            this.menu.TabIndex = 2;
            // 
            // parametre_btn
            // 
            this.parametre_btn.BackColor = System.Drawing.Color.Transparent;
            this.parametre_btn.BorderColor = System.Drawing.Color.Transparent;
            this.parametre_btn.BorderRadius = 6;
            this.parametre_btn.BorderThickness = 1;
            this.parametre_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.parametre_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.parametre_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.parametre_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.parametre_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parametre_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametre_btn.ForeColor = System.Drawing.Color.Blue;
            this.parametre_btn.Location = new System.Drawing.Point(9, 319);
            this.parametre_btn.Name = "parametre_btn";
            this.parametre_btn.Size = new System.Drawing.Size(181, 32);
            this.parametre_btn.TabIndex = 3;
            this.parametre_btn.Text = "Paramètres";
            this.parametre_btn.Click += new System.EventHandler(this.parametre_btn_Click);
            // 
            // corbeille_btn
            // 
            this.corbeille_btn.BackColor = System.Drawing.Color.Transparent;
            this.corbeille_btn.BorderColor = System.Drawing.Color.Transparent;
            this.corbeille_btn.BorderRadius = 6;
            this.corbeille_btn.BorderThickness = 1;
            this.corbeille_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.corbeille_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.corbeille_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.corbeille_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.corbeille_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corbeille_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corbeille_btn.ForeColor = System.Drawing.Color.Blue;
            this.corbeille_btn.Location = new System.Drawing.Point(9, 275);
            this.corbeille_btn.Name = "corbeille_btn";
            this.corbeille_btn.Size = new System.Drawing.Size(181, 32);
            this.corbeille_btn.TabIndex = 4;
            this.corbeille_btn.Text = "Corbeilles";
            this.corbeille_btn.Click += new System.EventHandler(this.corbeille_btn_Click);
            // 
            // accueil_btn
            // 
            this.accueil_btn.BackColor = System.Drawing.Color.Transparent;
            this.accueil_btn.BorderColor = System.Drawing.Color.Transparent;
            this.accueil_btn.BorderRadius = 6;
            this.accueil_btn.BorderThickness = 1;
            this.accueil_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accueil_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accueil_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accueil_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accueil_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accueil_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueil_btn.ForeColor = System.Drawing.Color.Blue;
            this.accueil_btn.Location = new System.Drawing.Point(9, 142);
            this.accueil_btn.Name = "accueil_btn";
            this.accueil_btn.Size = new System.Drawing.Size(181, 32);
            this.accueil_btn.TabIndex = 0;
            this.accueil_btn.Text = "Tableau de bord";
            this.accueil_btn.Click += new System.EventHandler(this.accueil_btn_Click);
            // 
            // etudiant_btn
            // 
            this.etudiant_btn.BackColor = System.Drawing.Color.Transparent;
            this.etudiant_btn.BorderColor = System.Drawing.Color.Transparent;
            this.etudiant_btn.BorderRadius = 6;
            this.etudiant_btn.BorderThickness = 1;
            this.etudiant_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.etudiant_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.etudiant_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.etudiant_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.etudiant_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.etudiant_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etudiant_btn.ForeColor = System.Drawing.Color.Blue;
            this.etudiant_btn.Location = new System.Drawing.Point(9, 186);
            this.etudiant_btn.Name = "etudiant_btn";
            this.etudiant_btn.Size = new System.Drawing.Size(181, 32);
            this.etudiant_btn.TabIndex = 1;
            this.etudiant_btn.Text = "Gestions étudiants";
            this.etudiant_btn.Click += new System.EventHandler(this.etudiant_btn_Click);
            // 
            // personnelles_btn
            // 
            this.personnelles_btn.BackColor = System.Drawing.Color.Transparent;
            this.personnelles_btn.BorderColor = System.Drawing.Color.Transparent;
            this.personnelles_btn.BorderRadius = 6;
            this.personnelles_btn.BorderThickness = 1;
            this.personnelles_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.personnelles_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.personnelles_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.personnelles_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.personnelles_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personnelles_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personnelles_btn.ForeColor = System.Drawing.Color.Blue;
            this.personnelles_btn.Location = new System.Drawing.Point(8, 230);
            this.personnelles_btn.Name = "personnelles_btn";
            this.personnelles_btn.Size = new System.Drawing.Size(182, 32);
            this.personnelles_btn.TabIndex = 2;
            this.personnelles_btn.Text = "Gestions personnelles";
            this.personnelles_btn.Click += new System.EventHandler(this.personnelles_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Teal;
            this.guna2Button1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(21, 511);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(156, 29);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Deconnexion";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1016, 49);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "GESTION D\'INSCRIPTION DES ETUDIANTS";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 599);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Panel menu;
        private Guna.UI2.WinForms.Guna2Button accueil_btn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button corbeille_btn;
        private Guna.UI2.WinForms.Guna2Button parametre_btn;
        private Guna.UI2.WinForms.Guna2Button personnelles_btn;
        private Guna.UI2.WinForms.Guna2Button etudiant_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}