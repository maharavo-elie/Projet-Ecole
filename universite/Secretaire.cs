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
    public partial class Secretaire : UserControl
    {

        public Secretaire()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE type = 'secretaire' AND nom_universite = @univ AND actif = 'oui' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@univ", Session.ecole);
                MySqlDataReader reader = cmd.ExecuteReader();

                Tableau.Rows.Clear();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string nom = reader["nom_utilisateur"].ToString();
                    string email = reader["email"].ToString();

                    Tableau.Rows.Add(nom, email, id);
                    
                }
            }
        }

        void InfoSecretaire()
        {
            Tableau.Columns.Clear();

            Tableau.ColumnCount = 3;
            Tableau.Columns[0].Name = "Nom";
            Tableau.Columns[1].Name = "Email";
            Tableau.Columns[2].Name = "id";

            Tableau.Columns["id"].Visible = false;
            Tableau.RowHeadersVisible = false;

            //Information un secretaire//
            DataGridViewButtonColumn voir_info = new DataGridViewButtonColumn();
            voir_info.HeaderText = "";
            voir_info.Text = "information";
            voir_info.Name = "information";
            voir_info.UseColumnTextForButtonValue = true;
            Tableau.Columns.Add(voir_info);

            //Modifier un secretaire//
            DataGridViewButtonColumn modifier = new DataGridViewButtonColumn();
            modifier.HeaderText = "";
            modifier.Text = "modifier";
            modifier.Name = "modifier";
            modifier.UseColumnTextForButtonValue = true;
            Tableau.Columns.Add(modifier);

            //Supprimer un secretaire//
            DataGridViewButtonColumn supprimer = new DataGridViewButtonColumn();
            supprimer.HeaderText = "";
            supprimer.Text = "supprimer";
            supprimer.Name = "supprimer";
            supprimer.UseColumnTextForButtonValue = true;
            Tableau.Columns.Add(supprimer);

            Tableau.CellClick += Tableau_CellClick;
            Tableau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tableau.AllowUserToAddRows = false;
        }

        //Action du button information//
        void VoirInformation(int id)
        {
            string connection = "server=localhost;user=root;database=universite;password=;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string nom = reader["nom_utilisateur"].ToString();
                    string email = reader["email"].ToString();
                    string type = reader["type"].ToString();
                    MessageBox.Show($"Nom : {nom} \nEmail : {email} \nType: {type}", "Information du Secrétaire",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Action du button Modifier//
        void Modifier(int id)
        {
            string connection = "server=localhost;user=root;database=universite;password=;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string idSecretaire = reader["id"].ToString();
                    string nom = reader["nom_utilisateur"].ToString();
                    string email = reader["email"].ToString();
                    string type = reader["type"].ToString();

                    ModifierUser modifier = new ModifierUser();
                    modifier.id = idSecretaire;
                    modifier.nom = nom;
                    modifier.email = email;
                    //modifier.ShowDialog();backup

                    // ShowDialog() retourne le DialogResult du formulaire//modificationko
                    DialogResult resultat = modifier.ShowDialog();

                    // On recharge SEULEMENT si la modification a réussi
                    if (resultat == DialogResult.OK)
                    {
                        LoadData(); // ← rafraîchit la table
                    }
                }
            }
        }

        //Action du button Supprimer//
        void Supprimer(int id)
        {
            string connection = "server=localhost;user=root;database=universite;password=;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "UPDATE users SET actif = 'non' WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Secrétaire supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du secrétaire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(Tableau.Rows[e.RowIndex].Cells["id"].Value);
            string header = Tableau.Columns[e.ColumnIndex].Name;

            if (header == "information")
            {
                VoirInformation(id);
            }
            else if (header == "modifier")
            {
                Modifier(id);
                //LoadData(); modificationko
            }
            else if (header == "supprimer")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce secrétaire?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { 
                    Supprimer(id);
                }
            }
        }

        private void Secretaire_Load(object sender, EventArgs e)
        {
            InfoSecretaire();
            LoadData();
        }
    }
    
}

