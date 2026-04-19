using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class VoirConfig : UserControl
    {
        public VoirConfig()
        {
            InitializeComponent();
        }

        public void LoadAnne()
        {
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM annee_universitaire WHERE universite = @univ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@univ", Session.ecole);
                MySqlDataReader reader = cmd.ExecuteReader();

                Table_AnneeUniv.Rows.Clear();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string nomUniv = reader["annee_universitaire"].ToString();
                    Table_AnneeUniv.Rows.Add(nomUniv, id);
                }
            }
        }
        public void Table_Annee()
        {
            Table_AnneeUniv.Columns.Clear();
            Table_AnneeUniv.ColumnCount = 2;
            Table_AnneeUniv.Columns[0].Name = "Année Universitaire";
            Table_AnneeUniv.Columns[1].Name = "id";
            Table_AnneeUniv.Columns["id"].Visible = false;
            Table_AnneeUniv.RowHeadersVisible = false;

            //Supprimer Année//
            DataGridViewButtonColumn supprimer = new DataGridViewButtonColumn();
            supprimer.HeaderText = "";
            supprimer.Text = "supprimer";
            supprimer.Name = "supprimer";
            supprimer.UseColumnTextForButtonValue = true;
            Table_AnneeUniv.Columns.Add(supprimer);

            Table_AnneeUniv.CellClick += Tableau_CellClick;
            Table_AnneeUniv.CellPainting += Tableau_CellPaintingAnnee;
            Table_AnneeUniv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table_AnneeUniv.AllowUserToAddRows = false;
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

        public void LoadParcours()
        {
            string univ = Session.ecole;
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection connexion = new MySqlConnection(connection))
            {
                connexion.Open();
                string query = "SELECT * FROM parcours WHERE universite = @univ";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@univ", univ);
                MySqlDataReader reader = cmd.ExecuteReader();

                TableParcours.Rows.Clear();
                while (reader.Read())
                {
                    string parcours = reader["parcours"].ToString();
                    string id = reader["id"].ToString();

                    TableParcours.Rows.Add(parcours, id);
                }
            }
        }

        public void TabParcours()
        {
            TableParcours.Columns.Clear();
            TableParcours.ColumnCount = 2;
            TableParcours.Columns[0].Name = "Parcours";
            TableParcours.Columns[1].Name = "id";

            TableParcours.Columns["id"].Visible = false;
            TableParcours.RowHeadersVisible = false;

            //Supprimer Parcours//
            DataGridViewButtonColumn supprimer = new DataGridViewButtonColumn();
            supprimer.HeaderText = "";
            supprimer.Text = "supprimer";
            supprimer.Name = "supprimer";
            supprimer.UseColumnTextForButtonValue = true;
            TableParcours.Columns.Add(supprimer);

            TableParcours.CellClick += Tableau_CellClick;
            TableParcours.CellPainting += Tableau_CellPaintingParcours;
            TableParcours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableParcours.AllowUserToAddRows = false;

        }

        public void LoadNiveaux()
        {   
            if (string.IsNullOrEmpty(Parcours.Text) || Parcours.Text == "Parcours") return;
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
                TableNiv.Rows.Clear();

                while (reader.Read())
                {
                    string niveau = reader["niveau"].ToString();
                    string id = reader["id"].ToString();

                    TableNiv.Rows.Add(niveau, id);
                }
                connexion.Close();
            }
        }

        public void TabNiveau()
        {
            TableNiv.Columns.Clear();
            TableNiv.ColumnCount = 2;
            TableNiv.Columns[0].Name = "Niveau";
            TableNiv.Columns[1].Name = "id";

            TableNiv.Columns["id"].Visible = false;
            TableNiv.RowHeadersVisible = false;

            //Supprimer Niveau//
            DataGridViewButtonColumn supprimer = new DataGridViewButtonColumn();
            supprimer.HeaderText = "";
            supprimer.Text = "supprimer";
            supprimer.Name = "supprimer";
            supprimer.UseColumnTextForButtonValue = true;
            TableNiv.Columns.Add(supprimer);

            TableNiv.CellClick += Tableau_CellClick;
            TableNiv.CellPainting+= Tableau_CellPaintingNiveau;
            TableNiv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableNiv.AllowUserToAddRows = false;
        }

        void SupprimerAnneeUniv(int id)
        {
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "DELETE FROM annee_universitaire WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Année universitaire supprimé avec succès.");
                    LoadAnne();
                }
                else
                {
                    MessageBox.Show("Erreur de suppression!!");
                }
            }
        }

        void SupprimerParcours(int id)
        {
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "DELETE FROM parcours WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Parcours supprimé avec succès.");
                    LoadParcours();
                }
                else
                {
                    MessageBox.Show("Erreur de suppression!!");
                }
            }
        }

        void SupprimerNiveau(int id)
        {
            string connection = "server=localhost;user=root;database=universite;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "DELETE FROM niveau WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Niveau supprimé avec succès.");
                    LoadNiveaux();
                }
                else
                {
                    MessageBox.Show("Erreur de suppression!!");
                }
            }
        }

        private void Tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView Tableau = sender as DataGridView;

            string id = Tableau.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string header = Tableau.Columns[e.ColumnIndex].Name;

            if (Tableau == Table_AnneeUniv)
            {
                if (header == "supprimer")
                {
                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette année?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SupprimerAnneeUniv(Convert.ToInt32(id));
                    }
                }
                
            }
            else if (Tableau == TableParcours)
            {
                if (header == "supprimer")
                {
                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce parcour?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SupprimerParcours(Convert.ToInt32(id));
                    }
                }
            }
            else if (Tableau == TableNiv)
            {
                if (header == "supprimer")
                {
                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce niveau?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SupprimerNiveau(Convert.ToInt32(id));
                    }
                }
            }
        }

        //----NEW MDODIFICATION----\\
        private void Tableau_CellPaintingAnnee(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool isSupprimerColumn = e.ColumnIndex == Table_AnneeUniv.Columns["supprimer"]?.Index;

                if (isSupprimerColumn)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    Image icon = null;
                    string buttonText = "";
                   
                    if (isSupprimerColumn)
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

        private void Tableau_CellPaintingParcours(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool isSupprimerColumn = e.ColumnIndex == Table_AnneeUniv.Columns["supprimer"]?.Index;

                if (isSupprimerColumn)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    Image icon = null;
                    string buttonText = "";

                    if (isSupprimerColumn)
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

        private void Tableau_CellPaintingNiveau(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool isSupprimerColumn = e.ColumnIndex == Table_AnneeUniv.Columns["supprimer"]?.Index;

                if (isSupprimerColumn)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    Image icon = null;
                    string buttonText = "";

                    if (isSupprimerColumn)
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

        // Fixée le tableau
        private void FixerDataGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void VoirConfig_Load(object sender, EventArgs e)
        {
            Table_Annee();
            TabParcours();
            TabNiveau();
            LoadAnne();
            Parcour();
            LoadParcours();
            Parcours.SelectedIndexChanged += Parcours_SelectedIndexChanged;
            LoadNiveaux();
            //Appelle du fonction fixée
            FixerDataGridView(Table_AnneeUniv);
            FixerDataGridView(TableNiv);
            FixerDataGridView(TableParcours);
        }

        private void Parcours_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNiveaux();
        }
    }

}
