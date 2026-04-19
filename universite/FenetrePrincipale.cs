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
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
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
            InitialiserSections();//
            ChangerSection("TableauBord");//

            TableauBord accueil = new TableauBord();
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
            TableauBord accueil = new TableauBord();
            loadContent(accueil);
            ChangerSection("TableauBord");//
        }

        private void etudiant_btn_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant();
            loadContent(etudiant);
            ChangerSection("GestionEtudiants");//

        }

        private void personnelles_btn_Click(object sender, EventArgs e)
        {
            Personnelle personnelles = new Personnelle();
            loadContent(personnelles);
            ChangerSection("GestionPersonnel");//
        }

        private void parametre_btn_Click(object sender, EventArgs e)
        {
            Parametre parametre = new Parametre();
            loadContent(parametre);
            ChangerSection("Parametres");//
        }

        private void corbeille_btn_Click(object sender, EventArgs e)
        {
            Corbeille corbeille = new Corbeille();
            loadContent(corbeille);
            ChangerSection("Corbeilles");//
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

        private void LogOutImg_Click(object sender, EventArgs e)
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

        // Fonction de changement ICON ET TEXTE//
        private Dictionary<string, (string Texte, Image Icone)> sections;

        private void InitialiserSections()
        {
            sections = new Dictionary<string, (string, Image)>
            {
                ["TableauBord"] = ("Tableau de bord", Properties.Resources.icon_dash),
                ["GestionEtudiants"] = ("Gestions étudiants", Properties.Resources.icon_etudiant),
                ["GestionPersonnel"] = ("Gestions personnelles", Properties.Resources.icon_perso),
                ["Corbeilles"] = ("Corbeilles", Properties.Resources.icon_corbeille),
                ["Parametres"] = ("Paramètres", Properties.Resources.icon_setting),
            };
        }

        private void ChangerSection(string nomSection)
        {
            if (sections.ContainsKey(nomSection))
            {
                Texte.Text = sections[nomSection].Texte;
                Icone.Image = new Bitmap(sections[nomSection].Icone, new Size(75, 73));
                Icone.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Deconnexion_MouseEnter(object sender, EventArgs e)
        {
            LogOutImg.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void Deconnexion_MouseLeave(object sender, EventArgs e)
        {
            LogOutImg.BackColor = Color.Teal;
        }
    }
}
