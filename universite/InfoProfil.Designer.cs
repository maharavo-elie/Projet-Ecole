namespace universite
{
    partial class InfoProfil
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
            this.grade = new System.Windows.Forms.Label();
            this.univ = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.nomU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(199, 211);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(0, 13);
            this.grade.TabIndex = 31;
            // 
            // univ
            // 
            this.univ.AutoSize = true;
            this.univ.Location = new System.Drawing.Point(221, 161);
            this.univ.Name = "univ";
            this.univ.Size = new System.Drawing.Size(0, 13);
            this.univ.TabIndex = 30;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(199, 114);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(0, 13);
            this.email.TabIndex = 29;
            // 
            // nomU
            // 
            this.nomU.AutoSize = true;
            this.nomU.Location = new System.Drawing.Point(251, 58);
            this.nomU.Name = "nomU";
            this.nomU.Size = new System.Drawing.Size(0, 13);
            this.nomU.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(154, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nom d\'utilisateur :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Université :";
            // 
            // InfoProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grade);
            this.Controls.Add(this.univ);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nomU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "InfoProfil";
            this.Size = new System.Drawing.Size(442, 365);
            this.Load += new System.EventHandler(this.InfoProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label univ;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label nomU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
