namespace universite
{
    partial class Frais
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
            this.chek = new System.Windows.Forms.ComboBox();
            this.droit = new System.Windows.Forms.TextBox();
            this.Btn_ajout_frais = new System.Windows.Forms.Button();
            this.panelNiveau = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chek
            // 
            this.chek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chek.FormattingEnabled = true;
            this.chek.Location = new System.Drawing.Point(343, 91);
            this.chek.Name = "chek";
            this.chek.Size = new System.Drawing.Size(143, 21);
            this.chek.TabIndex = 1;
            this.chek.SelectedIndexChanged += new System.EventHandler(this.Chek_SelectedIndexChanged);
            // 
            // droit
            // 
            this.droit.Location = new System.Drawing.Point(325, 247);
            this.droit.Multiline = true;
            this.droit.Name = "droit";
            this.droit.Size = new System.Drawing.Size(182, 30);
            this.droit.TabIndex = 2;
            // 
            // Btn_ajout_frais
            // 
            this.Btn_ajout_frais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ajout_frais.Location = new System.Drawing.Point(363, 322);
            this.Btn_ajout_frais.Name = "Btn_ajout_frais";
            this.Btn_ajout_frais.Size = new System.Drawing.Size(112, 37);
            this.Btn_ajout_frais.TabIndex = 3;
            this.Btn_ajout_frais.Text = "Ajouter";
            this.Btn_ajout_frais.UseVisualStyleBackColor = true;
            this.Btn_ajout_frais.Click += new System.EventHandler(this.Btn_ajout_frais_Click);
            // 
            // panelNiveau
            // 
            this.panelNiveau.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelNiveau.Location = new System.Drawing.Point(316, 118);
            this.panelNiveau.Name = "panelNiveau";
            this.panelNiveau.Size = new System.Drawing.Size(200, 123);
            this.panelNiveau.TabIndex = 4;
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
            this.label8.Size = new System.Drawing.Size(255, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Droit d\'inscription";
            // 
            // Frais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panelNiveau);
            this.Controls.Add(this.Btn_ajout_frais);
            this.Controls.Add(this.droit);
            this.Controls.Add(this.chek);
            this.Name = "Frais";
            this.Size = new System.Drawing.Size(815, 501);
            this.Load += new System.EventHandler(this.Frais_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox chek;
        private System.Windows.Forms.TextBox droit;
        private System.Windows.Forms.Button Btn_ajout_frais;
        private System.Windows.Forms.FlowLayoutPanel panelNiveau;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label8;
    }
}
