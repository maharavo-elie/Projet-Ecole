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
    public partial class Parametre : UserControl
    {
        public Parametre()
        {
            InitializeComponent();
        }

        public void LoadContent(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            params_conteneur.Controls.Clear();
            params_conteneur.Controls.Add(page);
        }

        private void Btn_conf_params_Click(object sender, EventArgs e)
        {
            Profil @params = new Profil();
            LoadContent(@params);
        }

        private void Btn_droit_Click(object sender, EventArgs e)
        {
            Config frais = new Config();
            LoadContent(frais);
        }

        private void btn_voir_conf_Click(object sender, EventArgs e)
        {
            VoirConfig voirConfig = new VoirConfig();
            LoadContent(voirConfig);
        }
    }
}
