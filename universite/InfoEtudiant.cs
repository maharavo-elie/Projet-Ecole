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
    public partial class InfoEtudiant : Form
    {

        public string annee { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string date_nee { get; set; }
        public string lieu_nee { get; set; }
        public string Numero { get; set; }
        public string email { get; set; }
        public string Matricules { get; set; }
        public string sexe { get; set; }
        public string parcours { get; set; }
        public string niveau { get; set; }
        public string frais { get; set; }
        public string pere { get; set; }
        public string mere { get; set; }
        public string Num_Parent { get; set; }
        public string adresse { get; set; }
        public string cin { get; set; }
        public string Date_Cin { get; set; }
        public string Lieu_Cin { get; set; }
        public string Dateajout { get; set; }
        public string Ajouteurs { get; set; }
        public string Status { get; set; }

        public InfoEtudiant()
        {
            InitializeComponent();
        }

        private void InfoEtudiant_Load(object sender, EventArgs e)
        {
            Annee.Text = annee;
            Nom.Text = nom;
            Prenom.Text = prenom;
            DateNaissance.Text = date_nee;
            LieuNaissance.Text = lieu_nee;
            Telephone.Text = Numero;
            Email.Text = email;
            Matricule.Text = Matricules;
            Sexe.Text = sexe;
            Parcours.Text = parcours;
            Niveau.Text = niveau;
            Droit.Text = frais +" "+"Ar";
            Pere.Text = pere;
            Mere.Text = mere;
            NumParent.Text = Num_Parent;
            Adresse.Text = adresse;
            Cin.Text = cin;
            DateCin.Text = Date_Cin;
            LieuCin.Text = Lieu_Cin;
            DateAjout.Text = Dateajout;
            Ajouteur.Text = Ajouteurs;
            Statut.Text = Status;
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
