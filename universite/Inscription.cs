using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace universite
{
    public partial class Inscription : UserControl
    {
        
        public Inscription()
        {
            InitializeComponent();
        }

        int matricule = 0;

        private void GetMatricule()
        {
            string connectionString = "server=localhost;database=universite;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(matricule) FROM matricule WHERE  universite = @univ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@univ", Session.ecole);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        matricule = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        matricule = 1;
                    }
                }
            }
        }

        private void Matricule()
        {
            string connectionString = "server=localhost;database=universite;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO matricule (universite, matricule ) VALUES (@univ, @matricule)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@matricule", matricule);
                    command.Parameters.AddWithValue("@univ", Session.ecole);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ViderLesChamps()
        {
            Nom.Clear();
            Prenom.Clear();
            Email.Clear();
            Frais.Clear();
            Pere.Clear();
            Mere.Clear();
            NumParent.Clear();
            NumEtudiant.Clear();
            AdresseEtudiant.Clear();
            Lieu_naissance.Clear();
        }

        private void inscrireBtn_Click(object sender, EventArgs e)
        {
            GetMatricule();
            Matricule();
            string mat = matricule.ToString();
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
            else
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
            string annee = AnneeCombo.Text;
            string universite = Session.ecole;
            string actif = "oui";
            string statut = "Passant(e)";
            string ajouter_par = Session.type;
            string ajouter_le = DateTime.Today.ToString("dd MMMM yyyy", new CultureInfo("fr-FR"));


            string connectionString = "server=localhost;database=universite;uid=root;pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO etudiant (universite, nom, prenom, date_de_naissance, lieu_de_naissance, numero, email, matricule, sexe, frais_droit_Ar, pere, mere, numero_parent, adresse, cin, date_cin, lieu_cin, parcours," +
                    " niveau, annee_universitaire, actif, status, ajouter_par, ajouter_le) VALUES (@universite, @nom, @prenom, @date_née, @lieu_née, @numEtudiant, @email, @mat, @sexe, @frais, @pere," +
                    " @mere, @tel_parent, @adresse_etudiant, @CIN, @delivrer, @lieu_delivrer, @parcour, @niv, @annee, @actif, @status, @ajouter_par, @ajouter_le)";
                                
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(prenom) 
                    //    || string.IsNullOrWhiteSpace(date_née) || string.IsNullOrWhiteSpace(lieu_née) || string.IsNullOrWhiteSpace(sexe) 
                    //    || string.IsNullOrWhiteSpace(niv) || string.IsNullOrWhiteSpace(annee) || string.IsNullOrWhiteSpace(parcour) 
                    //    || string.IsNullOrWhiteSpace(frais) || string.IsNullOrWhiteSpace(tel_parent) || string.IsNullOrWhiteSpace(adresse_etudiant)
                    //    || string.IsNullOrWhiteSpace(pere) || string.IsNullOrWhiteSpace(mere))
                    //{
                    //    MessageBox.Show("Veuillez remplir tous les champs!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else if(!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    //{
                    //    MessageBox.Show("Email non valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    //{
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
                        command.Parameters.AddWithValue("@status", statut);
                        command.Parameters.AddWithValue("@ajouter_par", ajouter_par);
                        command.Parameters.AddWithValue("@ajouter_le", ajouter_le);

                    command.ExecuteNonQuery();
                        MessageBox.Show("Inscription réussie !!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViderLesChamps();
                    }
                }
            }
        //}

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

        private void Inscription_Load(object sender, EventArgs e)
        {
            Panel18ans.Visible = false;
            Annee();
            Parcour();
            Niveaux();
            Parcours.SelectedIndexChanged += Parcours_SelectedIndexChanged;
        }

        ///
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
    }
}
