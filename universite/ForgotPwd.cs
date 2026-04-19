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
    public partial class ForgotPwd : Form
    {
        public ForgotPwd()
        {
            InitializeComponent();
        }

        private void ForgotPwd_Load(object sender, EventArgs e)
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

        private void AffichePwd_CheckedChanged(object sender, EventArgs e)
        {
            if (AffichePwd.Checked)
            {
                Mdps.UseSystemPasswordChar = false;
                Cmdps.UseSystemPasswordChar = false;

            }
            else
            {
                Mdps.UseSystemPasswordChar = true;
                Cmdps.UseSystemPasswordChar = true;
            }
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_enregistrer_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string newPassword = Mdps.Text;
            string confirmPassword = Cmdps.Text;

            string connection = "server=localhost;database=universite;user=root;password=";
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                string query = "SELECT * FROM users WHERE email = @Email AND actif = 'oui'";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (newPassword == confirmPassword)
                            {
                                reader.Close();
                                string updateQuery = "UPDATE users SET mot_de_passe = @newPassword WHERE email = @Email";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, con))
                                {
                                    updateCmd.Parameters.AddWithValue("@newPassword", HashPassword(newPassword));
                                    updateCmd.Parameters.AddWithValue("@Email", email);
                                    int rowsAffected = updateCmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Mot de passe mis à jour avec succès.");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur lors de la mise à jour du mot de passe.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Les mots de passe ne correspondent pas.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucun utilisateur trouvé avec cet email.");
                        }
                    }
                }
            }
        }
    }
}
