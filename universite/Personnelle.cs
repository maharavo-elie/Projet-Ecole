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
    public partial class Personnelle : UserControl
    {
        public Personnelle()
        {
            InitializeComponent();
        }

        public void loadContent(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            conteneur.Controls.Clear();
            conteneur.Controls.Add(page);
        }
        private void Ajouter_secretaire_Click(object sender, EventArgs e)
        {
            Ajout_secretaire ajout_Secretaire = new Ajout_secretaire();
            loadContent(ajout_Secretaire);
        }
        private void Liste_secertaireBtn_Click(object sender, EventArgs e)
        {
            Secretaire secretaire = new Secretaire();
            loadContent(secretaire);
        }
    }
}
