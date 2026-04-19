namespace universite
{
    partial class Config
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNiveau = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_ajout_frais = new System.Windows.Forms.Button();
            this.droit = new System.Windows.Forms.TextBox();
            this.chek = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajout_niv = new System.Windows.Forms.Button();
            this.niveau = new System.Windows.Forms.TextBox();
            this.BoxNiveau = new System.Windows.Forms.ComboBox();
            this.anneeU = new System.Windows.Forms.ComboBox();
            this.btn_ajout_parcours = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.parcours = new System.Windows.Forms.TextBox();
            this.btn_ajout_annee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.label8.Location = new System.Drawing.Point(293, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "CONFIGURATION";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.panelNiveau);
            this.guna2Panel1.Controls.Add(this.Btn_ajout_frais);
            this.guna2Panel1.Controls.Add(this.droit);
            this.guna2Panel1.Controls.Add(this.chek);
            this.guna2Panel1.Location = new System.Drawing.Point(435, 62);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(198, 327);
            this.guna2Panel1.TabIndex = 178;
            // 
            // panelNiveau
            // 
            this.panelNiveau.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelNiveau.Location = new System.Drawing.Point(27, 73);
            this.panelNiveau.Name = "panelNiveau";
            this.panelNiveau.Size = new System.Drawing.Size(143, 123);
            this.panelNiveau.TabIndex = 8;
            // 
            // Btn_ajout_frais
            // 
            this.Btn_ajout_frais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ajout_frais.Location = new System.Drawing.Point(43, 231);
            this.Btn_ajout_frais.Name = "Btn_ajout_frais";
            this.Btn_ajout_frais.Size = new System.Drawing.Size(112, 23);
            this.Btn_ajout_frais.TabIndex = 7;
            this.Btn_ajout_frais.Text = "Ajouter";
            this.Btn_ajout_frais.UseVisualStyleBackColor = true;
            // 
            // droit
            // 
            this.droit.Location = new System.Drawing.Point(27, 202);
            this.droit.Multiline = true;
            this.droit.Name = "droit";
            this.droit.Size = new System.Drawing.Size(143, 20);
            this.droit.TabIndex = 6;
            // 
            // chek
            // 
            this.chek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chek.FormattingEnabled = true;
            this.chek.Location = new System.Drawing.Point(27, 46);
            this.chek.Name = "chek";
            this.chek.Size = new System.Drawing.Size(143, 21);
            this.chek.TabIndex = 5;
            this.chek.SelectedIndexChanged += new System.EventHandler(this.chek_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_ajout_niv);
            this.panel1.Controls.Add(this.niveau);
            this.panel1.Controls.Add(this.BoxNiveau);
            this.panel1.Controls.Add(this.anneeU);
            this.panel1.Controls.Add(this.btn_ajout_parcours);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.parcours);
            this.panel1.Controls.Add(this.btn_ajout_annee);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(175, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 327);
            this.panel1.TabIndex = 179;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Annee Universitaire";
            // 
            // btn_ajout_niv
            // 
            this.btn_ajout_niv.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajout_niv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_niv.ForeColor = System.Drawing.Color.Blue;
            this.btn_ajout_niv.Location = new System.Drawing.Point(58, 285);
            this.btn_ajout_niv.Name = "btn_ajout_niv";
            this.btn_ajout_niv.Size = new System.Drawing.Size(85, 27);
            this.btn_ajout_niv.TabIndex = 3;
            this.btn_ajout_niv.Text = "Ajouter";
            this.btn_ajout_niv.UseVisualStyleBackColor = false;
            this.btn_ajout_niv.Click += new System.EventHandler(this.btn_ajout_niv_Click);
            // 
            // niveau
            // 
            this.niveau.Location = new System.Drawing.Point(39, 259);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(121, 20);
            this.niveau.TabIndex = 5;
            // 
            // BoxNiveau
            // 
            this.BoxNiveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxNiveau.FormattingEnabled = true;
            this.BoxNiveau.Location = new System.Drawing.Point(39, 231);
            this.BoxNiveau.Name = "BoxNiveau";
            this.BoxNiveau.Size = new System.Drawing.Size(121, 21);
            this.BoxNiveau.TabIndex = 9;
            // 
            // anneeU
            // 
            this.anneeU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anneeU.FormattingEnabled = true;
            this.anneeU.Items.AddRange(new object[] {
            "2025-2026",
            "2026-2027",
            "2027-2028",
            "2028-2029",
            "2029-2030"});
            this.anneeU.Location = new System.Drawing.Point(39, 46);
            this.anneeU.Name = "anneeU";
            this.anneeU.Size = new System.Drawing.Size(121, 21);
            this.anneeU.TabIndex = 1;
            // 
            // btn_ajout_parcours
            // 
            this.btn_ajout_parcours.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajout_parcours.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_parcours.ForeColor = System.Drawing.Color.Blue;
            this.btn_ajout_parcours.Location = new System.Drawing.Point(58, 163);
            this.btn_ajout_parcours.Name = "btn_ajout_parcours";
            this.btn_ajout_parcours.Size = new System.Drawing.Size(85, 27);
            this.btn_ajout_parcours.TabIndex = 7;
            this.btn_ajout_parcours.Text = "Ajouter";
            this.btn_ajout_parcours.UseVisualStyleBackColor = false;
            this.btn_ajout_parcours.Click += new System.EventHandler(this.btn_ajout_parcours_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ajouter les niveaux";
            // 
            // parcours
            // 
            this.parcours.Location = new System.Drawing.Point(39, 137);
            this.parcours.Name = "parcours";
            this.parcours.Size = new System.Drawing.Size(121, 20);
            this.parcours.TabIndex = 8;
            // 
            // btn_ajout_annee
            // 
            this.btn_ajout_annee.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajout_annee.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_annee.ForeColor = System.Drawing.Color.Blue;
            this.btn_ajout_annee.Location = new System.Drawing.Point(58, 73);
            this.btn_ajout_annee.Name = "btn_ajout_annee";
            this.btn_ajout_annee.Size = new System.Drawing.Size(85, 27);
            this.btn_ajout_annee.TabIndex = 2;
            this.btn_ajout_annee.Text = "Ajouter";
            this.btn_ajout_annee.UseVisualStyleBackColor = false;
            this.btn_ajout_annee.Click += new System.EventHandler(this.btn_ajout_annee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ajouter les parcours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Droit d\'inscription";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Config";
            this.Size = new System.Drawing.Size(815, 501);
            this.Load += new System.EventHandler(this.Config_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel panelNiveau;
        private System.Windows.Forms.Button Btn_ajout_frais;
        private System.Windows.Forms.TextBox droit;
        private System.Windows.Forms.ComboBox chek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajout_niv;
        private System.Windows.Forms.TextBox niveau;
        private System.Windows.Forms.ComboBox BoxNiveau;
        private System.Windows.Forms.ComboBox anneeU;
        private System.Windows.Forms.Button btn_ajout_parcours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parcours;
        private System.Windows.Forms.Button btn_ajout_annee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
