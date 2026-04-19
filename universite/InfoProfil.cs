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
    public partial class InfoProfil : UserControl
    {
        public InfoProfil()
        {
            InitializeComponent();
        }

        private void InfoProfil_Load(object sender, EventArgs e)
        {
            string emailUser = Session.email;
            string connection = "server=localhost;database=universite;user=root;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE email = @email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", emailUser);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nomU.Text = reader["nom_utilisateur"].ToString();
                    email.Text = reader["email"].ToString();
                    univ.Text = reader["nom_universite"].ToString();
                    grade.Text = reader["type"].ToString();
                }
            }
        }
    }
}
