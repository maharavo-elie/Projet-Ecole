using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySqlX.XDevAPI;

namespace universite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1020, 560);
            Login login = new Login();
            loadContent(login);
        }

        //====chargement de contenue====\\
        public void loadContent(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            conteneur.Controls.Clear();
            conteneur.Controls.Add(page);
        }

        // ==== Cryptage mot de passe === \\
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void BtnSinscrire_Click_1(object sender, EventArgs e)
        {
            SingIn singIn = new SingIn();
            loadContent(singIn);
        }

        private void BtnSeConnecter_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            loadContent(login);
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
