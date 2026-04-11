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
    public partial class ModifierEtudiant : Form
    {
        public string Id { get; set; }
        public string nom {  get; set; }
        public string prenom { get; set; }
        public string date_nee { get; set; }
        public string lieu_nee { get; set; }
        public string Numero { get; set; }
        public string email { get; set; }
        public string Matricules { get; set; }

        public string Sexe { get; set; }
        public string parcours { get; set; }
        public string niveau { get; set; }
        public string frais { get; set; }
        public string pere { get; set; }
        public string mere { get; set; }
        public string Num_Parent { get; set; }
        public string Adresse { get; set; }
        public string cin { get; set; }
        public string Date_Cin { get; set; }
        public string Lieu_Cin { get; set; }
        public ModifierEtudiant()
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

        private void ModifierEtudiant_Load(object sender, EventArgs e)
        {
            Parcour();
            Niveaux();
            Nom.Text = nom;
            Prenom.Text = prenom;
            Date_de_naissance.Text = date_nee;
            Lieu_naissance.Text = lieu_nee;
            Email.Text = email;
            Matricule.Text = Matricules;
            if (Sexe == "Masculin")
            {
                Masculin.Checked = true;
            }
            else {
                Feminin.Checked = true;
            }
            Parcours.SelectedItem = parcours;
            Niveau.SelectedItem = Niveau;
            Frais.Text = frais;
            Pere.Text = pere;
            Mere.Text = mere;
            NumParent.Text = Num_Parent;
            NumEtudiant.Text = Numero;
            AdresseEtudiant.Text = Adresse;
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
                Delivrer.Text = Date_Cin;
                Lieu_delivrer.Text = Lieu_Cin;
            }

            Parcours.SelectedIndexChanged += Parcours_SelectedIndexChanged;

        }


        private void InscrireBtn_Click(object sender, EventArgs e)
        {
            
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

            string connection = "server=localhost;user=root;database=universite;password=;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "UPDATE etudiant SET nom = @nom, prenom = @prenom, date_de_naissance = @date_née," +
                    " lieu_de_naissance = @lieu_née, numero = @numEtudiant, email = @email, sexe = @sexe, frais_droit_Ar = @frais," +
                    " pere = @pere, mere = @mere, numero_parent = @tel_parent, adresse = @adresse_etudiant, cin = @CIN," +
                    " date_cin = @delivrer, lieu_cin = @lieu_delivrer, parcours = @parcour, niveau = @niv WHERE id = @id";
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
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
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
                    command.Parameters.AddWithValue("@numEtudiant", numEtudiant);
                    command.Parameters.AddWithValue("@id", Id);

                    int result = command.ExecuteNonQuery();
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
