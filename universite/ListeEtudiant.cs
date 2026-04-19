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

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.Kernel.Colors;
using iText.Layout.Properties;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using Rectangle = System.Drawing.Rectangle;

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

        private void ListeEtudiant_Load(object sender, EventArgs e)
        {
            Annee();
            Parcour();
            Niveaux();
            InfoEtudiant();
            LoadData();
            Parcours.SelectedIndexChanged += Parcours_SelectedIndexChanged;

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

        private void AfficherBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ExporterPDF()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
            // Le nom du fichier s'adapte à votre triage actuel 
            saveDialog.FileName = $"Liste_{AnneeCombo.Text}_{Parcours.Text}_{Niveau.Text}.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string cheminPDF = saveDialog.FileName;

                try
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(cheminPDF, System.IO.FileMode.Create))
                    {
                        using (iText.Kernel.Pdf.PdfWriter writer = new iText.Kernel.Pdf.PdfWriter(fs))
                        {
                            using (iText.Kernel.Pdf.PdfDocument pdf = new iText.Kernel.Pdf.PdfDocument(writer))
                            {
                                iText.Layout.Document document = new iText.Layout.Document(pdf, iText.Kernel.Geom.PageSize.A4);
                                iText.Kernel.Font.PdfFont fontBold = iText.Kernel.Font.PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);

                                // ===== EN-TÊTE DYNAMIQUE =====
                                document.Add(new iText.Layout.Element.Paragraph("Universite : " + Session.ecole));
                                document.Add(new iText.Layout.Element.Paragraph("Année universitaire : " + AnneeCombo.Text));
                                document.Add(new iText.Layout.Element.Paragraph("Parcours : " + Parcours.Text));
                                document.Add(new iText.Layout.Element.Paragraph("Niveau : " + Niveau.Text));

                                document.Add(new iText.Layout.Element.Paragraph("LISTE DES ÉTUDIANTS")
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                                    .SetFontSize(16)
                                    .SetFont(fontBold)
                                    .SetMarginTop(20));

                                document.Add(new iText.Layout.Element.Paragraph("\n"));

                                // ===== TABLEAU (Format conservé : 2 colonnes) =====
                                iText.Layout.Element.Table table = new iText.Layout.Element.Table(iText.Layout.Properties.UnitValue.CreatePercentArray(new float[] { 3, 7 })).UseAllAvailableWidth();

                                table.AddHeaderCell(new iText.Layout.Element.Cell().Add(new iText.Layout.Element.Paragraph("Matricule").SetFont(fontBold))
                                    .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY));
                                table.AddHeaderCell(new iText.Layout.Element.Cell().Add(new iText.Layout.Element.Paragraph("Nom et prénoms").SetFont(fontBold))
                                    .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY));

                                // ===== NOUVEAU CODE : RÉCUPÉRATION DEPUIS LE DATAGRIDVIEW =====
                                // Remplacez 'votreDataGridView' par le nom exact de votre tableau (ex: dgvEtudiants)
                                foreach (DataGridViewRow row in Tableau.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        // On récupère les textes directement affichés dans les colonnes de votre interface
                                        string nom = row.Cells["Nom"].Value?.ToString() ?? "";
                                        string prenom = row.Cells["Prénoms"].Value?.ToString() ?? "";
                                        string matricule = row.Cells["Matricule"].Value?.ToString() ?? "";

                                        // Case Matricule
                                        table.AddCell(new iText.Layout.Element.Cell()
                                            .Add(new iText.Layout.Element.Paragraph(matricule))
                                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                                        // Case Nom et Prénoms
                                        table.AddCell(new iText.Layout.Element.Cell()
                                            .Add(new iText.Layout.Element.Paragraph(nom + " " + prenom)));
                                    }
                                }

                                document.Add(table);
                                document.Close();
                            }
                        }
                    }
                    MessageBox.Show("Exportation réussie pour " + Parcours.Text + " " + Niveau.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void ExportListBtn_Click(object sender, EventArgs e)
        {
            ExporterPDF();
        }
    }

}
