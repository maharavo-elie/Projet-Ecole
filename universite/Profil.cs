using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace universite
{
    public partial class Profil : UserControl
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            InfoProfil infoProfil = new InfoProfil();
            LoadContent(infoProfil);
        }

        public void LoadContent(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            Conteneur.Controls.Clear();
            Conteneur.Controls.Add(page);
        }
        private void Btn_info_Click(object sender, EventArgs e)
        {
            InfoProfil infoProfil = new InfoProfil();
            LoadContent(infoProfil);
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            ModifProfil modifProfil = new ModifProfil();
            LoadContent(modifProfil);
        }

        private void Btn_modif_Click(object sender, EventArgs e)
        {
            ModifPwd modifPwd = new ModifPwd();
            LoadContent(modifPwd);
        }
    }
}
