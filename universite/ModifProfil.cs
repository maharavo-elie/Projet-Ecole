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

namespace universite
{
    public partial class ModifProfil : UserControl
    {
        public ModifProfil()
        {
            InitializeComponent();
        }

        private void ModifProfil_Load(object sender, EventArgs e)
        {
            string emailUser = Session.email;
            string connection = "server=localhost;database=universite;user=root;password=";
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                string query = "SELECT * FROM users WHERE email = @email";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", emailUser);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nomU.Text = reader["nom_utilisateur"].ToString();
                            email.Text = reader["email"].ToString();
                        }
                    }
                }
            }
        }

        private void Btn_modif_Click(object sender, EventArgs e)
        {
            string nom = nomU.Text;
            string mail = email.Text;
            string connection = "server=localhost;database=universite;user=root;password=";
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                string query = "UPDATE users SET nom_utilisateur = @nom, email = @mail WHERE email = @email";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@email", Session.email);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Profil mis à jour avec succès !");
                        Session.email = mail; // Met à jour l'email dans la session
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la mise à jour du profil.");
                    }
                }
            }
        }
    }
}
