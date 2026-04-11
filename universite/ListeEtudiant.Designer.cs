namespace universite
{
    partial class ListeEtudiant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tableau = new System.Windows.Forms.DataGridView();
            this.AnneeCombo = new System.Windows.Forms.ComboBox();
            this.Parcours = new System.Windows.Forms.ComboBox();
            this.Niveau = new System.Windows.Forms.ComboBox();
            this.AfficherBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // Tableau
            // 
            this.Tableau.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tableau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tableau.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Tableau.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tableau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tableau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tableau.EnableHeadersVisualStyles = false;
            this.Tableau.GridColor = System.Drawing.Color.Silver;
            this.Tableau.Location = new System.Drawing.Point(0, 43);
            this.Tableau.Name = "Tableau";
            this.Tableau.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tableau.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.Tableau.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tableau.Size = new System.Drawing.Size(815, 446);
            this.Tableau.TabIndex = 1;            // 
            // AnneeCombo
            // 
            this.AnneeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnneeCombo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AnneeCombo.FormattingEnabled = true;
            this.AnneeCombo.Items.AddRange(new object[] {
            "2025-2026",
            "2026-2027",
            "2027-2028",
            "2028-2029",
            "2029-2030"});
            this.AnneeCombo.Location = new System.Drawing.Point(277, 12);
            this.AnneeCombo.Name = "AnneeCombo";
            this.AnneeCombo.Size = new System.Drawing.Size(119, 23);
            this.AnneeCombo.TabIndex = 65;
            // 
            // Parcours
            // 
            this.Parcours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parcours.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.Parcours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Parcours.FormattingEnabled = true;
            this.Parcours.Items.AddRange(new object[] {
            "2025-2026",
            "2026-2027",
            "2027-2028",
            "2028-2029",
            "2029-2030"});
            this.Parcours.Location = new System.Drawing.Point(413, 12);
            this.Parcours.Name = "Parcours";
            this.Parcours.Size = new System.Drawing.Size(119, 23);
            this.Parcours.TabIndex = 66;
            // 
            // Niveau
            // 
            this.Niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Niveau.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.Niveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Niveau.FormattingEnabled = true;
            this.Niveau.Items.AddRange(new object[] {
            "2025-2026",
            "2026-2027",
            "2027-2028",
            "2028-2029",
            "2029-2030"});
            this.Niveau.Location = new System.Drawing.Point(549, 12);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(119, 23);
            this.Niveau.TabIndex = 67;
            // 
            // AfficherBtn
            // 
            this.AfficherBtn.BorderRadius = 8;
            this.AfficherBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AfficherBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AfficherBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AfficherBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AfficherBtn.FillColor = System.Drawing.Color.LightPink;
            this.AfficherBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficherBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AfficherBtn.Location = new System.Drawing.Point(697, 10);
            this.AfficherBtn.Name = "AfficherBtn";
            this.AfficherBtn.Size = new System.Drawing.Size(94, 27);
            this.AfficherBtn.TabIndex = 68;
            this.AfficherBtn.Text = "Afficher";
            this.AfficherBtn.Click += new System.EventHandler(this.AfficherBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(19, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 69;
            this.label1.Text = "Triage des étudiants";
            // 
            // ListeEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AfficherBtn);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.Parcours);
            this.Controls.Add(this.AnneeCombo);
            this.Controls.Add(this.Tableau);
            this.Name = "ListeEtudiant";
            this.Size = new System.Drawing.Size(815, 489);
            this.Load += new System.EventHandler(this.ListeEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tableau;
        private System.Windows.Forms.ComboBox AnneeCombo;
        private System.Windows.Forms.ComboBox Parcours;
        private System.Windows.Forms.ComboBox Niveau;
        private Guna.UI2.WinForms.Guna2Button AfficherBtn;
        private System.Windows.Forms.Label label1;
    }
}
