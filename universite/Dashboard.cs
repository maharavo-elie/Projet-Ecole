using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universite
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }



        //====chargement de contenue====\\
        public void loadContent(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            conteneur.Controls.Clear();
            conteneur.Controls.Add(page);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            loadContent(accueil);
            string univ = Session.ecole;
            string type = Session.type;
            if (type == "secretaire")
            {
                personnelles_btn.Visible = false;
            }
        }

        private void accueil_btn_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            loadContent(accueil);
        }

        private void etudiant_btn_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant();
            loadContent(etudiant);

        }

        private void personnelles_btn_Click(object sender, EventArgs e)
        {
            Personnelle personnelles = new Personnelle();
            loadContent(personnelles);
        }

        private void parametre_btn_Click(object sender, EventArgs e)
        {
            Parametre parametre = new Parametre();
            loadContent(parametre);
        }

        private void corbeille_btn_Click(object sender, EventArgs e)
        {
            Corbeille corbeille = new Corbeille();
            loadContent(corbeille);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form1 form = new Form1();
                form.Show();
            }
        }
    }
}
