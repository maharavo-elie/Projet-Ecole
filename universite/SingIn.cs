using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universite
{
    public partial class SingIn : UserControl
    {
        public SingIn()
        {
            InitializeComponent();
        }

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

        private void voir_mdps_CheckedChanged(object sender, EventArgs e)
        {
            if (voir_mdps.Checked)
            {
                mdps.UseSystemPasswordChar = false;
                cmdps.UseSystemPasswordChar = false;
            }
            else
            {
                mdps.UseSystemPasswordChar = true;
                cmdps.UseSystemPasswordChar = true;
            }
        }

        private void Btn_inscrire_Click(object sender, EventArgs e)
        {
            string name = nom_utilisateur.Text;
            string mail = email.Text;
            string univ = nom_univ.Text;
            string grade = "Admin";
            string actif = "oui";
            string password = mdps.Text;
            string cpassword = cmdps.Text;
            string hpassword = HashPassword(password);

            string connection = "server=localhost;database=universite;user=root;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query;
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(mail) ||
                    string.IsNullOrWhiteSpace(univ) || string.IsNullOrWhiteSpace(password)
                    || string.IsNullOrWhiteSpace(cpassword))
                {
                    MessageBox.Show("Veuillez remplir tous les champs!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Email non valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password != cpassword)
                {
                    MessageBox.Show("Verifier votre mot de passe!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "INSERT INTO users (nom_utilisateur, email, nom_universite, type, actif, mot_de_passe) VALUES (@nom, @email, @nomUniv, @type, @actif, @mdps)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nom", name);
                    cmd.Parameters.AddWithValue("email", mail);
                    cmd.Parameters.AddWithValue("@nomUniv", univ);
                    cmd.Parameters.AddWithValue("@type", grade);
                    cmd.Parameters.AddWithValue("@actif", actif);
                    cmd.Parameters.AddWithValue("@mdps", hpassword);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inscription réussi !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ParentForm.Hide();
                    Session.ecole = univ;
                    Session.type = grade;
                    Session.ecole = mail;
                    FenetrePrincipale dashboard = new FenetrePrincipale();
                    dashboard.Show();
                    conn.Close();
                }
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
