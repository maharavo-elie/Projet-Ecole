using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universite
{
    public partial class Ajout_secretaire : UserControl
    {
        public Ajout_secretaire()
        {
            InitializeComponent();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
       
            if (checkBox1.Checked)
            {
                mdps.UseSystemPasswordChar = false;
            }
            else
            {
                mdps.UseSystemPasswordChar = true;
            }
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            string nom = nom_utilisateur.Text;
            string mail = email.Text;
            string univ = Session.ecole;
            string type = "secretaire";
            string actif = "oui";
            string password = HashPassword(mdps.Text);

            string connection = "server=localhost;database=universite;user=root;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "INSERT INTO users (nom_utilisateur, email, nom_universite, type, actif, mot_de_passe) VALUES (@nom, @mail, @univ, @type, @actif, @mdps)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@univ", univ);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@actif", actif);
                cmd.Parameters.AddWithValue("@mdps", password);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Secrétaire ajouté avec succès !");
                nom_utilisateur.Text = "";
                email.Text = "";
                mdps.Text = "";
            }
        }
    }
    
}
