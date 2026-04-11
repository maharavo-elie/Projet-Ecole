using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universite
{
    public partial class Reinsc : UserControl
    {
        
        public Reinsc()
        {
            InitializeComponent();
        }

        public void Annee_recherche()
        {
            AnneeRecherche.Items.Clear();
            string universite = Session.ecole;

            string connection = "server = localhost; user = root; database = universite; password = ;";
            using (MySqlConnection connex = new MySqlConnection(connection))
            {
                connex.Open();
                string query = "SELECT * FROM annee_universitaire WHERE universite = @univ";
                MySqlCommand command = new MySqlCommand(query, connex);
                command.Parameters.AddWithValue("@univ", universite);
                MySqlDataReader reader = command.ExecuteReader();

                List<string> list = new List<string>();

                while (reader.Read())
                {
                    list.Add(reader["annee_universitaire"].ToString());
                }
                connex.Close();
                if (list.Count == 0)
                {
                    AnneeRecherche.Items.Add("Annee universitaire");
                    AnneeRecherche.SelectedIndex = 0;
                }
                else
                {
                    foreach (string item in list)
                    {
                        AnneeRecherche.Items.Add(item);
                    }

                    AnneeRecherche.SelectedIndex = 0;
                }
            }
        }

            public void annee_univ()
            {
            AnneeUniversitaire.Items.Clear();
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
                    AnneeUniversitaire.Items.Add("Annee universitaire");
                    AnneeUniversitaire.SelectedIndex = 0;
                }
                else
                {
                    foreach (string v in list)
                    {
                        AnneeUniversitaire.Items.Add(v);
                    }

                    AnneeUniversitaire.SelectedIndex = 0;
                }
            }
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
                string query = "SELECT * FROM niveau WHERE universite = @univ AND parcours = @parcours";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string annee = AnneeRecherche.Text;
            string univ = Session.ecole;
            string matricule = Num_Matricule.Text;

            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection connexion = new MySqlConnection(connection))
            {
                connexion.Open();
                string query = "SELECT * FROM etudiant WHERE universite = @univ AND annee_universitaire = @annee AND matricule = @matricule";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@univ", univ);
                cmd.Parameters.AddWithValue("@annee", annee);
                cmd.Parameters.AddWithValue("@matricule", matricule);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Parcour();
                    Niveaux();
                    Parcours.SelectedIndexChanged += Parcours_SelectedIndexChanged;
                    Nom.Text = reader["nom"].ToString();
                    Prenom.Text = reader["prenom"].ToString();
                    Date_de_naissance.Text = reader["date_de_naissance"].ToString();
                    Lieu_naissance.Text = reader["lieu_de_naissance"].ToString();
                    Email.Text = reader["email"].ToString();
                    Matricule.Text = reader["matricule"].ToString();
                    NumEtudiant.Text = reader["numero"].ToString();
                    string sexe = reader["sexe"].ToString();
                    if (sexe == "Masculin")
                    {
                        Masculin.Checked = true;
                    }
                    else if (sexe == "Feminin")
                    {
                        Feminin.Checked = true;
                    }
                    Parcours.Text = reader["parcours"].ToString();
                    Niveau.Text = reader["niveau"].ToString();
                    Pere.Text = reader["pere"].ToString();
                    Mere.Text = reader["mere"].ToString();
                    NumParent.Text = reader["numero_parent"].ToString();
                    AdresseEtudiant.Text = reader["adresse"].ToString();
                    Frais.Text = reader["frais_droit_Ar"].ToString();
                    string cin = reader["cin"].ToString();
                    string date_delivrer = reader["date_cin"].ToString();
                    string lieu_delivrer = reader["lieu_cin"].ToString();
                    if (cin == "aucun")
                    {
                        Cin.Text = "";
                        Delivrer.Text = "";
                        Lieu_delivrer.Text = "";
                        Panel18ans.Visible = false;
                    }
                    else
                    {
                        Check18ans.Checked = true;
                        Panel18ans.Visible = true;
                        Cin.Text = cin;
                        Delivrer.Text = date_delivrer;
                        Lieu_delivrer.Text = lieu_delivrer;
                    }
                    panelVisible.Visible = true;
                }
                else
                {
                    MessageBox.Show("Aucun correspondance.");
                    panelVisible.Visible = false;
                }
            }
        }

        private void Parcours_SelectedIndexChanged(object sender, EventArgs e)
        {
            Niveau.Items.Clear();
            if (Parcours.SelectedItem == null || Parcours.Text == "") return;
            Niveaux();
        }

        private void Reinsc_Load(object sender, EventArgs e)
        {
            panelVisible.Visible = false;
            annee_univ();
            Annee_recherche();
        }

        private void InscrireBtn_Click(object sender, EventArgs e)
        {
            int nbr = 0;
            string mat = Matricule.Text;
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            string date_née = Date_de_naissance.Text;
            string lieu_née = Lieu_naissance.Text;
            string email = Email.Text;
            string sexe = "";
            if (Masculin.Checked)
            {
                sexe = Masculin.Text;
            }
            else if (Feminin.Checked)
            {
                sexe = Feminin.Text;
            }

            string frais = Frais.Text;
            string pere = Pere.Text;
            string mere = Mere.Text;
            string tel_parent = NumParent.Text;
            string adresse_etudiant = AdresseEtudiant.Text;
            string CIN;
            string delivrer;
            string lieu_delivrer;
            if (Check18ans.Checked)
            {
                CIN = Cin.Text;
                delivrer = Delivrer.Text;
                lieu_delivrer = Lieu_delivrer.Text;
            }
            else
            {
                CIN = "aucun";
                delivrer = "aucun";
                lieu_delivrer = "aucun";
            }

            string numEtudiant = NumEtudiant.Text;
            string parcour = Parcours.Text;
            string niv = Niveau.Text;
            string annee = AnneeUniversitaire.Text;
            string universite = Session.ecole;
            string actif = "oui";
            string status = "";
            if (Passant.Checked)
            {
                status = "Passant(e)";
            }
            else if (Redouble.Checked)
            {
                status = "Redoublant(e)";
            }
            string ajouter_par = Session.type;
            string ajouter_le = DateTime.Today.ToString("dd MM yyyy", new CultureInfo("fr-FR"));
            string connex = "server = localhost; user = root; database = universite; password = ;";

            using (MySqlConnection connection = new MySqlConnection(connex))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM etudiant WHERE universite = @universite";
                    MySqlCommand Command = new MySqlCommand(query, connection);
                    Command.Parameters.AddWithValue("@universite", Session.ecole);
                    Command.Parameters.AddWithValue("@matricule", mat);
                    MySqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        string annees = reader["annee_universitaire"].ToString();
                        string matricules = reader["matricule"].ToString();
                        if (annees == annee && matricules == mat)
                        {
                            nbr++;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                    return;
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connex))
            {
                try
                {
                    conn.Open();
                    if (nbr == 0)
                    {
                        string query = "INSERT INTO etudiant (universite, nom, prenom, date_de_naissance," +
                            " lieu_de_naissance, numero, email, matricule, sexe, frais_droit_Ar, pere, mere," +
                            " numero_parent, adresse, cin, date_cin, lieu_cin, parcours," +
                        "niveau, annee_universitaire, actif, status, ajouter_par, ajouter_le) VALUES (@universite, @nom, @prenom, @date_née, @lieu_née" +
                        ", @numEtudiant, @email, @mat, @sexe, @frais, @pere,@mere, @tel_parent, @adresse_etudiant, @CIN," +
                        "@delivrer, @lieu_delivrer, @parcour, @niv, @annee, @actif, @status, @ajouter_par, @ajouter_le)";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@prenom", prenom);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@sexe", sexe);
                        command.Parameters.AddWithValue("@frais", frais);
                        command.Parameters.AddWithValue("@pere", pere);
                        command.Parameters.AddWithValue("@mere", mere);
                        command.Parameters.AddWithValue("@tel_parent", tel_parent);
                        command.Parameters.AddWithValue("@adresse_etudiant", adresse_etudiant);
                        command.Parameters.AddWithValue("@delivrer", delivrer);
                        command.Parameters.AddWithValue("@lieu_delivrer", lieu_delivrer);
                        command.Parameters.AddWithValue("@date_née", date_née);
                        command.Parameters.AddWithValue("@lieu_née", lieu_née);
                        command.Parameters.AddWithValue("@CIN", CIN);
                        command.Parameters.AddWithValue("@parcour", parcour);
                        command.Parameters.AddWithValue("@niv", niv);
                        command.Parameters.AddWithValue("@annee", annee);
                        command.Parameters.AddWithValue("@numEtudiant", numEtudiant);
                        command.Parameters.AddWithValue("@universite", universite);
                        command.Parameters.AddWithValue("@actif", actif);
                        command.Parameters.AddWithValue("@mat", mat);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@ajouter_par", ajouter_par);
                        command.Parameters.AddWithValue("@ajouter_le", ajouter_le);
                        //ajouter_par
                        //ajouter_le
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Réinscription réussie!!");
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la réinscription.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le matricule correspondant est deja inscrit à l'annee universitaire" + " " + annee);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                } 
            }
        }

        private void Check18ans_CheckedChanged(object sender, EventArgs e)
        {
            if (Check18ans.Checked)
            {
                Panel18ans.Visible = true;
            }
            else
            {
                Panel18ans.Visible = false;
            }
        }
    }
}


