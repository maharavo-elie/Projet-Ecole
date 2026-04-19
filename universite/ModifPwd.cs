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
    public partial class ModifPwd : UserControl
    {
        public ModifPwd()
        {
            InitializeComponent();
        }

        private void ModifPwd_Load(object sender, EventArgs e)
        {

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

        private void Btn_modif_Click(object sender, EventArgs e)
        {
            string oldPassword = HashPassword(oldPwd.Text);
            string newPassword = newPwd.Text;
            string cnewPassword = cnewPwd.Text;
            string connection = "server=localhost;database=universite;user=root;password=";
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                string query = "SELECT * FROM users WHERE email = @email AND mot_de_passe = @oldPwd";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", Session.email);
                    cmd.Parameters.AddWithValue("@oldPwd", oldPassword);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (newPassword == cnewPassword)
                            {
                                reader.Close();
                                string updateQuery = "UPDATE users SET mot_de_passe = @newPwd WHERE email = @email";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, con))
                                {
                                    updateCmd.Parameters.AddWithValue("@newPwd", HashPassword(newPassword));
                                    updateCmd.Parameters.AddWithValue("@email", Session.email);
                                    int result = updateCmd.ExecuteNonQuery();
                                    if (result > 0)
                                    {
                                        MessageBox.Show("Mot de passe modifié avec succès !");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur lors de la modification du mot de passe.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Le nouveau mot de passe et sa confirmation ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ancien mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

            }
        }

        private void Affiche_CheckedChanged(object sender, EventArgs e)
        {
            if (Affiche.Checked)
            {
                oldPwd.UseSystemPasswordChar = false;
                newPwd.UseSystemPasswordChar = false;
                cnewPwd.UseSystemPasswordChar = false;
            }
            else
            {
                oldPwd.UseSystemPasswordChar = true;
                newPwd.UseSystemPasswordChar = true;
                cnewPwd.UseSystemPasswordChar = true;
            }
        }
    }
}
