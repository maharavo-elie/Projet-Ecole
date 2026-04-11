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
    public partial class Corbeille : UserControl
    {
        public Corbeille()
        {
            InitializeComponent();
        }

        private void Corbeille_Load(object sender, EventArgs e)
        {

        }
        public void LoadContent(UserControl secretaire)
        {
            secretaire.Dock = DockStyle.Fill;
            CorbeillePanel.Controls.Clear();
            CorbeillePanel.Controls.Add(secretaire);
        }

        private void SecretaireCorbeille_Click(object sender, EventArgs e)
        {
            CorbeilleSecretaire corbeilleSecretaire = new CorbeilleSecretaire();
            LoadContent(corbeilleSecretaire);
        }

        private void CorbeilleEtudiant_Click(object sender, EventArgs e)
        {
            CorbeilleEtudiant corbeilleEtudiant = new CorbeilleEtudiant();
            LoadContent(corbeilleEtudiant);
        }
    }
}
