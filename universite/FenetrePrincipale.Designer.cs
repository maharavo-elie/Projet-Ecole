namespace universite
{
    partial class FenetrePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.conteneur = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Deconnexion = new Guna.UI2.WinForms.Guna2Button();
            this.Texte = new System.Windows.Forms.Label();
            this.parametre_btn = new Guna.UI2.WinForms.Guna2Button();
            this.corbeille_btn = new Guna.UI2.WinForms.Guna2Button();
            this.accueil_btn = new Guna.UI2.WinForms.Guna2Button();
            this.etudiant_btn = new Guna.UI2.WinForms.Guna2Button();
            this.personnelles_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Icone = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.conteneur.Location = new System.Drawing.Point(200, 50);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(817, 489);
            this.conteneur.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Navy;
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.Texte);
            this.menu.Controls.Add(this.parametre_btn);
            this.menu.Controls.Add(this.corbeille_btn);
            this.menu.Controls.Add(this.accueil_btn);
            this.menu.Controls.Add(this.etudiant_btn);
            this.menu.Controls.Add(this.personnelles_btn);
            this.menu.Controls.Add(this.Icone);
            this.menu.Location = new System.Drawing.Point(0, 47);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(199, 493);
            this.menu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LogOutImg);
            this.panel1.Controls.Add(this.Deconnexion);
            this.panel1.Location = new System.Drawing.Point(16, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 39);
            this.panel1.TabIndex = 0;
            // 
            // LogOutImg
            // 
            this.LogOutImg.BackColor = System.Drawing.Color.Teal;
            this.LogOutImg.FillColor = System.Drawing.Color.Transparent;
            this.LogOutImg.Image = global::universite.Properties.Resources.se_deconnecter;
            this.LogOutImg.ImageRotate = 0F;
            this.LogOutImg.Location = new System.Drawing.Point(124, 10);
            this.LogOutImg.Name = "LogOutImg";
            this.LogOutImg.Size = new System.Drawing.Size(24, 20);
            this.LogOutImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOutImg.TabIndex = 10;
            this.LogOutImg.TabStop = false;
            this.LogOutImg.Click += new System.EventHandler(this.LogOutImg_Click);
            // 
            // Deconnexion
            // 
            this.Deconnexion.BorderRadius = 6;
            this.Deconnexion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deconnexion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deconnexion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deconnexion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deconnexion.FillColor = System.Drawing.Color.Teal;
            this.Deconnexion.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold);
            this.Deconnexion.ForeColor = System.Drawing.Color.White;
            this.Deconnexion.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Deconnexion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Deconnexion.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Deconnexion.Location = new System.Drawing.Point(7, 5);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Deconnexion.Size = new System.Drawing.Size(156, 29);
            this.Deconnexion.TabIndex = 8;
            this.Deconnexion.Text = "Deconnexion";
            this.Deconnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Deconnexion.Click += new System.EventHandler(this.guna2Button1_Click);
            this.Deconnexion.MouseEnter += new System.EventHandler(this.Deconnexion_MouseEnter);
            this.Deconnexion.MouseLeave += new System.EventHandler(this.Deconnexion_MouseLeave);
            // 
            // Texte
            // 
            this.Texte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texte.ForeColor = System.Drawing.Color.White;
            this.Texte.Location = new System.Drawing.Point(13, 98);
            this.Texte.Name = "Texte";
            this.Texte.Size = new System.Drawing.Size(175, 14);
            this.Texte.TabIndex = 0;
            this.Texte.Text = "label2";
            this.Texte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.parametre_btn.Location = new System.Drawing.Point(9, 301);
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
            this.corbeille_btn.Location = new System.Drawing.Point(9, 257);
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
            this.accueil_btn.Location = new System.Drawing.Point(9, 124);
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
            this.etudiant_btn.Location = new System.Drawing.Point(9, 168);
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
            this.personnelles_btn.Location = new System.Drawing.Point(8, 212);
            this.personnelles_btn.Name = "personnelles_btn";
            this.personnelles_btn.Size = new System.Drawing.Size(182, 32);
            this.personnelles_btn.TabIndex = 2;
            this.personnelles_btn.Text = "Gestions personnelles";
            this.personnelles_btn.Click += new System.EventHandler(this.personnelles_btn_Click);
            // 
            // Icone
            // 
            this.Icone.Image = ((System.Drawing.Image)(resources.GetObject("Icone.Image")));
            this.Icone.Location = new System.Drawing.Point(50, 14);
            this.Icone.Name = "Icone";
            this.Icone.Size = new System.Drawing.Size(97, 81);
            this.Icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icone.TabIndex = 9;
            this.Icone.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkOrchid;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1018, 49);
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
            this.ClientSize = new System.Drawing.Size(1018, 540);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogOutImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button Deconnexion;
        private System.Windows.Forms.PictureBox Icone;
        private Guna.UI2.WinForms.Guna2PictureBox LogOutImg;
        private System.Windows.Forms.Label Texte;
        private System.Windows.Forms.Panel panel1;
    }
}