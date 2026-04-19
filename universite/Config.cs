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
    public partial class Config : UserControl
    {
        public Config()
        {
            InitializeComponent();
        }

        public void LoadingF()
        {
            string connectionString = "server=localhost;database=universite;user=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query1 = "SELECT * FROM parcours WHERE universite = @univ";
                using (MySqlCommand cmd1 = new MySqlCommand(query1, conn))
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

        private void Config_Load(object sender, EventArgs e)
        {
            Loading();
            LoadingF();
        }

        private void chek_SelectedIndexChanged(object sender, EventArgs e)
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


        public void Loading()
        {
            anneeU.SelectedIndex = 0;
            string univ = Session.ecole;

            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection connexion = new MySqlConnection(connection))
            {
                connexion.Open();
                string query = "SELECT parcours FROM parcours WHERE universite = @univ";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@univ", univ);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> list = new List<string>();

                while (reader.Read())
                {
                    list.Add(reader["parcours"].ToString());
                }
                connexion.Close();
                if (list.Count == 0)
                {
                    BoxNiveau.Items.Add("parcours");
                    BoxNiveau.SelectedIndex = 0;
                }
                else
                {
                    foreach (string v in list)
                    {
                        BoxNiveau.Items.Add(v);
                    }

                    BoxNiveau.SelectedIndex = 0;
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

        private void btn_ajout_annee_Click(object sender, EventArgs e)
        {
            string annee = anneeU.Text;
            string universite = Session.ecole;
            string ajouteur = Session.type;

            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection connexion = new MySqlConnection(connection))
            {
                connexion.Open();
                string query = "INSERT INTO annee_universitaire (annee_universitaire, universite, ajouter_par) VALUES (@annee, @universite, @ajouteur)";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@annee", annee);
                cmd.Parameters.AddWithValue("@universite", universite);
                cmd.Parameters.AddWithValue("@ajouteur", ajouteur);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Année universitaire ajoutée avec succès !");
                connexion.Close();

            }
        }

        private void btn_ajout_parcours_Click(object sender, EventArgs e)
        {
            string parcour = parcours.Text;
            string universite = Session.ecole;
            string ajouteur = Session.type;

            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection connexion = new MySqlConnection(connection))
            {
                connexion.Open();
                string query = "INSERT INTO parcours (parcours, universite, ajouter_par) VALUES (@parcour, @universite, @ajouteur)";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@parcour", parcour);
                cmd.Parameters.AddWithValue("@universite", universite);
                cmd.Parameters.AddWithValue("@ajouteur", ajouteur);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Parcours ajouté avec succès !");
                connexion.Close();

            }
            parcours.Text = "";
            BoxNiveau.Items.Clear();
            chek.Items.Clear();
            Loading();
            LoadingF();
        }

        private void btn_ajout_niv_Click(object sender, EventArgs e)
        {
            string niv = niveau.Text;
            string parcour = BoxNiveau.Text;
            string universite = Session.ecole;
            string ajouteur = Session.type;

            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection connexion = new MySqlConnection(connection))
            {
                connexion.Open();
                string query = "INSERT INTO niveau (parcours, niveau, universite, ajouter_par) VALUES (@parcour, @niv, @universite, @ajouteur)";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@parcour", parcour);
                cmd.Parameters.AddWithValue("@niv", niv);
                cmd.Parameters.AddWithValue("@universite", universite);
                cmd.Parameters.AddWithValue("@ajouteur", ajouteur);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Niveau ajouté avec succès !");
                connexion.Close();

            }
            niveau.Text = "";
        }
    }
}
