using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universite
{
    public partial class ToustEtudiants : UserControl
    {
        public ToustEtudiants()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM etudiant WHERE universite = @univ AND actif = 'oui' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@univ", Session.ecole);
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
            Tableau.CellPainting += Tableau_CellPainting;
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
                    string status = reader["status"].ToString();

                    InfoEtudiant info = new InfoEtudiant();
                    info.annee = annee;
                    info.nom = nom;
                    info.prenom = prenom;
                    info.date_nee = dateDeNaissance;
                    info.lieu_nee = lieu_de_naissance;
                    info.Numero = numero;
                    info.email = email;
                    info.Matricules = matricule;
                    info.sexe = sexe;
                    info.parcours = parcours;
                    info.niveau = niveau;
                    info.frais = frais;
                    info.pere = pere;
                    info.mere = mere;
                    info.Num_Parent = numero_parent;
                    info.adresse = adresse;
                    info.cin = cin;
                    info.Date_Cin = date_cin;
                    info.Lieu_Cin = lieu_cin;
                    info.Dateajout = dateAjout;
                    info.Ajouteurs = ajouteur;
                    info.Status = status;
                    info.ShowDialog();
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

        //----NEW MDODIFICATION----\\
        private void Tableau_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool isInfoColumn = e.ColumnIndex == Tableau.Columns["information"]?.Index;
                bool isModifierColumn = e.ColumnIndex == Tableau.Columns["modifier"]?.Index;
                bool isSupprimerColumn = e.ColumnIndex == Tableau.Columns["supprimer"]?.Index;

                if (isInfoColumn || isModifierColumn || isSupprimerColumn)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    //Image icon = null;
                    System.Drawing.Image icon = null;
                    string buttonText = "";

                    if (isInfoColumn)
                    {
                        icon = Properties.Resources.icon_info;
                        buttonText = "information";
                    }
                    else if (isModifierColumn)
                    {
                        icon = Properties.Resources.icon_modif;
                        buttonText = "modifier";
                    }
                    else if (isSupprimerColumn)
                    {
                        icon = Properties.Resources.icon_delet;
                        buttonText = "supprimer";
                    }

                    if (icon != null)
                    {
                        int iconSize = 16;
                        int spacing = 4; // espace entre icône et texte

                        // Mesurer la largeur du texte
                        //Size textSize = TextRenderer.MeasureText(e.Graphics, buttonText, e.CellStyle.Font);
                        System.Drawing.Size textSize = TextRenderer.MeasureText(e.Graphics, buttonText, e.CellStyle.Font);

                        // Largeur totale = icône + espace + texte
                        int totalWidth = iconSize + spacing + textSize.Width;

                        // Point de départ X pour centrer le tout
                        int startX = e.CellBounds.X + (e.CellBounds.Width - totalWidth) / 2;

                        // -------- DESSINER L'ICÔNE --------
                        Rectangle iconRect = new Rectangle(
                            startX,
                            e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2,
                            iconSize,
                            iconSize
                        );
                        e.Graphics.DrawImage(icon, iconRect);

                        // -------- DESSINER LE TEXTE à côté de l'icône --------
                        Rectangle textRect = new Rectangle(
                            startX + iconSize + spacing,
                            e.CellBounds.Y,
                            textSize.Width,
                            e.CellBounds.Height
                        );

                        TextRenderer.DrawText(e.Graphics, buttonText, e.CellStyle.Font,
                            textRect, e.CellStyle.ForeColor, TextFormatFlags.VerticalCenter);
                    }

                    e.Handled = true;
                }
            }
        }

        private void ToustEtudiants_Load(object sender, EventArgs e)
        {
            InfoEtudiant();
            LoadData();

            // Fixer le DataGridView 
            Tableau.ReadOnly = true;
            // Empêcher l'ajout/suppression de lignes directement
            Tableau.AllowUserToAddRows = false;
            Tableau.AllowUserToDeleteRows = false;
            // Désactiver le redimensionnement des colonnes 
            Tableau.AllowUserToResizeColumns = false;
            Tableau.AllowUserToResizeRows = false;
            // Sélection par ligne entière 
            Tableau.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Empêcher l'édition
            Tableau.EditMode = DataGridViewEditMode.EditProgrammatically;
        }        
    }
}
