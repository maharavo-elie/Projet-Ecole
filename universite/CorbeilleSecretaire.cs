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
    public partial class CorbeilleSecretaire : UserControl
    {

        public CorbeilleSecretaire()
        {
            InitializeComponent();
        }

        private void CorbeilleSecretaire_Load(object sender, EventArgs e)
        {
            InfoSecretaire();
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

        void LoadData()
        {
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE type = 'secretaire' AND nom_universite = @univ AND actif = 'non' ";
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

            //Restaurer un secretaire//
            DataGridViewButtonColumn restaurer = new DataGridViewButtonColumn();
            restaurer.HeaderText = "";
            restaurer.Text = "restaurer";
            restaurer.Name = "restaurer";
            restaurer.UseColumnTextForButtonValue = true;
            Tableau.Columns.Add(restaurer);

            //Supprimer un secretaire//
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

        //Action du button Restaurer//
        void Restaurer(int id)
        {
            string connection = "server=localhost;user=root;database=universite;password=;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "UPDATE users SET actif = 'oui' WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Secrétaire restauré avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la restauration du secrétaire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "DELETE FROM users WHERE id = @id";
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
            else if (header == "restaurer")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir restaurer cet étudiant?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Restaurer(id);
                }
            }
            else if (header == "supprimer")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                bool isRestaurerColumn = e.ColumnIndex == Tableau.Columns["restaurer"]?.Index;
                bool isSupprimerColumn = e.ColumnIndex == Tableau.Columns["supprimer"]?.Index;

                if (isInfoColumn || isRestaurerColumn || isSupprimerColumn)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    Image icon = null;
                    string buttonText = "";

                    if (isInfoColumn)
                    {
                        icon = Properties.Resources.icon_info;
                        buttonText = "information";
                    }
                    else if (isRestaurerColumn)
                    {
                        icon = Properties.Resources.icon_restaurer;
                        buttonText = "restaurer";
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
                        Size textSize = TextRenderer.MeasureText(e.Graphics, buttonText, e.CellStyle.Font);

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
    }
}

