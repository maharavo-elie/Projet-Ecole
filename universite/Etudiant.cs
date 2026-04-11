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
    public partial class Etudiant : UserControl
    {
        public Etudiant()
        {
            InitializeComponent();
        }

        public void LoadContent(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            conteneur_etudiant.Controls.Clear();
            conteneur_etudiant.Controls.Add(page);

        }
        private void Inscrire_btn_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            LoadContent(inscription);
        }

        private void ListeBtn_Click(object sender, EventArgs e)
        {
            ListeEtudiant listeEtudiant = new ListeEtudiant();
            LoadContent(listeEtudiant);
        }

        private void Etudiant_Load(object sender, EventArgs e)
        {
            ToustEtudiants tousAfficher = new ToustEtudiants();
            LoadContent(tousAfficher);
        }

        private void Reinscrire_btn_Click(object sender, EventArgs e)
        {
            Reinsc reinscription = new Reinsc();
            LoadContent(reinscription);
        }
    }
}
