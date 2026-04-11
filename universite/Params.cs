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
    public partial class Params : UserControl
    {
        public Params()
        {
            InitializeComponent();
        }

        public void Chargement()
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

        private void Params_Load(object sender, EventArgs e)
        {
            Loading();
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
                cmd .Parameters.AddWithValue("@parcour", parcour);
                cmd.Parameters.AddWithValue("@niv", niv);
                cmd.Parameters.AddWithValue("@universite", universite);
                cmd.Parameters.AddWithValue("@ajouteur", ajouteur);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Niveau ajouté avec succès !");
                connexion.Close();

            }
            niveau.Text = "";
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
            Loading();
        }
    }
}
