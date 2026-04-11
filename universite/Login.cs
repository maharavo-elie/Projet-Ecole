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
using MySql.Data.MySqlClient;
namespace universite
{
    public partial class Login : UserControl
    {
        public Login()
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

        private void Btn_connecter_Click(object sender, EventArgs e)
        {
            string mail = email.Text;
            string password = HashPassword(mdps.Text);

            string connection = "server=localhost;database=universite;user=root;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query;
                query = "SELECT * FROM users WHERE email = @email AND mot_de_passe = @mdps";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", mail);
                cmd.Parameters.AddWithValue("@mdps", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Session.ecole = reader["nom_universite"].ToString();
                    Session.type = reader["type"].ToString();
                    this.ParentForm.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Compte n'existe pas.Veuillez réessayer.", "Information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
