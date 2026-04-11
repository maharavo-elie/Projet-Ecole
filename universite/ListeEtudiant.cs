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
    public partial class ListeEtudiant : UserControl
    {
        public ListeEtudiant()
        {
            InitializeComponent();
        }

        public void Parcour()
        {
            Parcours.Items.Clear();
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
                    Parcours.Items.Add("parcours");
                    Parcours.SelectedIndex = 0;
                }
                else
                {
                    foreach (string v in list)
                    {
                        Parcours.Items.Add(v);
                    }

                    Parcours.SelectedIndex = 0;
                }
            }
        }

        public void Niveaux()
        {
            Niveau.Items.Clear();
            string parcours = Parcours.Text;
            string univ = Session.ecole;

            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection connexion = new MySqlConnection(connection))
            {
                connexion.Open();
                string query = "SELECT niveau FROM niveau WHERE universite = @univ AND parcours = @parcours";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@univ", univ);
                cmd.Parameters.AddWithValue("@parcours", parcours);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> list = new List<string>();

                while (reader.Read())
                {
                    list.Add(reader["niveau"].ToString());
                }
                connexion.Close();
                if (list.Count == 0)
                {
                    Niveau.Items.Add("niveau");
                    Niveau.SelectedIndex = 0;
                }
                else
                {
                    foreach (string v in list)
                    {
                        Niveau.Items.Add(v);
                    }

                    Niveau.SelectedIndex = 0;
                }
            }
        }

        private void Parcours_SelectedIndexChanged(object sender, EventArgs e)
        {
            Niveau.Items.Clear();
            if (Parcours.SelectedItem == null || Parcours.Text == "") return;
            Niveaux();
        }

        public void Annee()
        {
            AnneeCombo.Items.Clear();
            string univ = Session.ecole;

            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection connexion = new MySqlConnection(connection))
            {
                connexion.Open();
                string query = "SELECT * FROM annee_universitaire WHERE universite = @univ";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@univ", univ);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> list = new List<string>();

                while (reader.Read())
                {
                    list.Add(reader["annee_universitaire"].ToString());
                }
                connexion.Close();
                if (list.Count == 0)
                {
                    AnneeCombo.Items.Add("Annee universitaire");
                    AnneeCombo.SelectedIndex = 0;
                }
                else
                {
                    foreach (string v in list)
                    {
                        AnneeCombo.Items.Add(v);
                    }

                    AnneeCombo.SelectedIndex = 0;
                }
            }
        }

        void LoadData()
        {
            string annee = AnneeCombo.Text;
            string niveau = Niveau.Text;
            string parcour = Parcours.Text;
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM etudiant WHERE universite = @univ AND annee_universitaire = @annee " +
                    "AND niveau = @niveau AND parcours = @parcour AND actif = 'oui' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@univ", Session.ecole);
                cmd.Parameters.AddWithValue("@annee", annee);
                cmd.Parameters.AddWithValue("@parcour", parcour);
                cmd.Parameters.AddWithValue("@niveau", niveau);
                MySqlDataReader reader = cmd.ExecuteReader();

                Tableau.Rows.Clear();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string matricule = reader["matricule"].ToString();

                    Tableau.Rows.Add(nom, prenom, id, matricule);

                }
            }

        }

        void InfoEtudiant()
        {
            Tableau.Columns.Clear();

            Tableau.ColumnCount = 4;
            Tableau.Columns[0].Name = "Nom";
            Tableau.Columns[1].Name = "Prénoms";
            Tableau.Columns[2].Name = "id";
            Tableau.Columns[3].Name = "Matricule";

            Tableau.Columns["id"].Visible = false;
            Tableau.RowHeadersVisible = false;

            //Information Etudiant//
            DataGridViewButtonColumn voir_info = new DataGridViewButtonColumn();
            voir_info.HeaderText = "";
            voir_info.Text = "information";
            voir_info.Name = "information";
            voir_info.UseColumnTextForButtonValue = true;
            Tableau.Columns.Add(voir_info);

            //Modifier Etudiant//
            DataGridViewButtonColumn modifier = new DataGridViewButtonColumn();
            modifier.HeaderText = "";
            modifier.Text = "modifier";
            modifier.Name = "modifier";
            modifier.UseColumnTextForButtonValue = true;
            Tableau.Columns.Add(modifier);

            //Supprimer Etudiant//
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
                string query = "SELECT * FROM etudiant WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string annee = reader["annee_universitaire"].ToString();
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string dateDeNaissance = reader["date_de_naissance"].ToString();
                    string lieu_de_naissance = reader["lieu_de_naissance"].ToString();
                    string numero = reader["numero"].ToString();
                    string email = reader["email"].ToString();
                    string matricule = reader["matricule"].ToString();
                    string sexe = reader["sexe"].ToString();
                    string parcours = reader["parcours"].ToString();
                    string niveau = reader["niveau"].ToString();
                    string frais = reader["frais_droit_Ar"].ToString();
                    string pere = reader["pere"].ToString();
                    string mere = reader["mere"].ToString();
                    string numero_parent = reader["numero_parent"].ToString();
                    string adresse = reader["adresse"].ToString();
                    string cin = reader["cin"].ToString();
                    string date_cin = reader["date_cin"].ToString();
                    string lieu_cin = reader["lieu_cin"].ToString();
                    string dateAjout = reader["ajouter_le"].ToString();
                    string ajouteur = reader["ajouter_par"].ToString();

                    MessageBox.Show(
                        $"Année universitaire : {annee}\nNom : {nom}\nPrenom : {prenom}\nDate de naissance : {dateDeNaissance}\nLieu de naissance : {lieu_de_naissance}\nNumero : {numero}\nEmail : {email}\nMatricule : {matricule}\nSexe : {sexe}\nParcours : {parcours}\nNiveau : {niveau}" +
                        $"\nFrais : {frais}\nPère : {pere}\nMère : {mere}\nNumero Parent : {numero_parent}\nAdresse : {adresse}\nCIN : {cin}\nDélivré le : {date_cin}\nA : {lieu_cin}\nAjouté le : {dateAjout}\nAjouté par : {ajouteur}",
                        "Informations de l'etudiant",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                     );
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
                string query = "SELECT * FROM etudiant WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string idEtudiant = reader["id"].ToString();
                    string universite = reader["universite"].ToString();
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string matricule = reader["matricule"].ToString();
                    string date_de_naissance = reader["date_de_naissance"].ToString();
                    string lieu_de_naissance = reader["lieu_de_naissance"].ToString();
                    string numero = reader["numero"].ToString();
                    string email = reader["email"].ToString();
                    string sexe = reader["sexe"].ToString();
                    string parcour = reader["parcours"].ToString();
                    string niveau = reader["niveau"].ToString();
                    string frais = reader["frais_droit_Ar"].ToString();
                    string pere = reader["pere"].ToString();
                    string mere = reader["mere"].ToString();
                    string num_parent = reader["numero_parent"].ToString();
                    string adresse_etudiant = reader["adresse"].ToString();
                    string cin = reader["cin"].ToString();
                    string date_cin = reader["date_cin"].ToString();
                    string lieu_cin = reader["lieu_cin"].ToString();

                    ModifierEtudiant modifier = new ModifierEtudiant();
                    modifier.Id = idEtudiant;
                    modifier.nom = nom;
                    modifier.prenom = prenom;
                    modifier.date_nee = date_de_naissance;
                    modifier.lieu_nee = lieu_de_naissance;
                    modifier.Numero = numero;
                    modifier.email = email;
                    modifier.Matricules = matricule;
                    modifier.Sexe = sexe;
                    modifier.parcours = parcour;
                    modifier.niveau = niveau;
                    modifier.frais = frais;
                    modifier.pere = pere;
                    modifier.mere = mere;
                    modifier.Num_Parent = num_parent;
                    modifier.Adresse = adresse_etudiant;
                    modifier.cin = cin;
                    modifier.Date_Cin = date_cin;
                    modifier.Lieu_Cin = lieu_cin;

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
                string query = "UPDATE etudiant SET actif = 'non' WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Etudiant supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression d'étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étudiant?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Supprimer(id);
                }
            }
        }

        private void ListeEtudiant_Load(object sender, EventArgs e)
        {
            Annee();
            Parcour();
            Niveaux();
            InfoEtudiant();
            LoadData();
            Parcours.SelectedIndexChanged += Parcours_SelectedIndexChanged;
        }

        private void AfficherBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}
