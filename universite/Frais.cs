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
    public partial class Frais : UserControl
    {
        public Frais()
        {
            InitializeComponent();
        }

        private void Frais_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=universite;user=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query1 = "SELECT * FROM parcours WHERE universite = @univ";
                using(MySqlCommand cmd1 = new MySqlCommand(query1, conn))
                {
                    cmd1.Parameters.AddWithValue("@univ", Session.ecole);
                    using (MySqlDataReader reader = cmd1.ExecuteReader())
                    {

                        List<string> list = new List<string>();

                        while (reader.Read())
                        {
                            list.Add(reader["parcours"].ToString());
                        }
                        conn.Close();
                        if (list.Count == 0)
                        {
                            chek.Items.Add("parcours");
                            chek.SelectedIndex = 0;
                        }
                        else
                        {
                            foreach (string v in list)
                            {
                                chek.Items.Add(v);
                            }

                            chek.SelectedIndex = 0;
                        }

                    }
                }
               
            }
        }

        private void Chek_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = chek.Text;

            string connectionString = "server=localhost;database=universite;user=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query2 = "SELECT * FROM niveau WHERE universite = @univ AND parcours = @parcour";
                using (MySqlCommand cmd2 = new MySqlCommand(query2, conn))
                {
                    cmd2.Parameters.AddWithValue("@univ", Session.ecole);
                    cmd2.Parameters.AddWithValue("@parcour", choix);
                    using (MySqlDataReader reader1 = cmd2.ExecuteReader())
                    {
                        panelNiveau.Controls.Clear();
                        while (reader1.Read())
                        {
                            CheckBox cb = new CheckBox();
                            cb.Text = reader1["niveau"].ToString();
                            cb.AutoSize = true;
                            panelNiveau.Controls.Add(cb);
                        }
                    }
                }
            }
        }

        private void Btn_ajout_frais_Click(object sender, EventArgs e)
        {
            string parcours = chek.Text;
            string frais = droit.Text;
            string ecole = Session.ecole;
            string type = Session.type;

            string connectionString = "server=localhost;database=universite;user=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                foreach (Control ctrl in panelNiveau.Controls)
                {
                    if (ctrl is CheckBox cb && cb.Checked)
                    {
                        string query3 = "INSERT INTO frais_scolarite (parcours, niveau, frais_Ar, universite, ajouter_par) VALUES (@parcour, @niveau, @droit, @univ, @ajouteur)";
                        using (MySqlCommand cmd3 = new MySqlCommand(query3, conn))
                        {
                            cmd3.Parameters.AddWithValue("@parcour", parcours);
                            cmd3.Parameters.AddWithValue("@niveau", cb.Text);
                            cmd3.Parameters.AddWithValue("@droit", frais);
                            cmd3.Parameters.AddWithValue("@univ", ecole);
                            cmd3.Parameters.AddWithValue("@ajouteur", type);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Frais de scolarité ajoutés avec succès !");

            }
        }
    }
}
