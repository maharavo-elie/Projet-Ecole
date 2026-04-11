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
    public partial class ModifierUser : Form
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string email { get; set; }

        public ModifierUser()
        {
            InitializeComponent();
        }

        private void ModifierUser_Load(object sender, EventArgs e)
        {
            Id_utilisateur.Text = id;
            NomUser.Text = nom;
            EmailUser.Text = email;
            Id_utilisateur.Visible = false;
        }

        private void Btn_Valider_Click_1(object sender, EventArgs e)
        {
            string Nom = NomUser.Text;
            string Email = EmailUser.Text;
            string idUser = Id_utilisateur.Text;

            string connection = "server=localhost;user=root;database=universite;password=;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "UPDATE users SET nom_utilisateur = @nom, email = @email WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", Nom);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@id", idUser);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Utilisateur modifié avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;//modificationko
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
