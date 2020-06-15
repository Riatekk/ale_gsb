using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acces_BDClassLibrary; // Utilisation d'une bibliothèque de classes contenant toutes les méthodes de connexion.
using System.Data.SqlClient;

namespace BBLL_GSB
{
    public partial class FrmConsultationVisiteur : Form
    {

        private void NombreVisiteur()
        {
            outils.MaConnexion();
            lblNbVisiteur.Text = "Nombre de visiteur\n" + outils.ExecuteScalar("EXECUTE PSS_NombreVisiteur");
            outils.MaDeconnexion();
        }

        private void NombreVisiteurParDate(string unedate)
        {
            outils.MaConnexion();
            lblNbVisiteur.Text = "Nombre de visiteur\n" +  outils.ExecuteScalar("EXECUTE PSS_NombreVisiteurParDate '" + getDateSelectionne() + "'" );
            outils.MaDeconnexion();
        }

        private void ListeVisiteur()
        {
            outils.MaConnexion();
            try
            {
                string requête;
                requête = ("EXECUTE PSS_InfoVisiteur");
                dtgListeVisiteur.DataSource = outils.ExecReader_DataTable(requête);
            }
            catch (SqlException probleme)
            {
                MessageBox.Show("L'erreur suivante a été rencontrée :" + probleme.Message);
            }

            #region Mise en forme de la grille
            dtgListeVisiteur.ReadOnly = true; // On interdit la saisit directement dans la grille
            // Rafraichissement de la grille
            dtgListeVisiteur.Refresh();
            // Pour ajuster la grille
            // Ajustement de la largeur des colonnes
            dtgListeVisiteur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajustement de la hauteur des lignes :
            // ici les lignes s'ajustent mais pas au contenu de l'en-tête de ligne
            dtgListeVisiteur.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            #endregion
            outils.MaDeconnexion();
        }

        private string getDateSelectionne()
        {
            string annee, jour, mois, dateSelectionne;
            annee = CalDate.SelectionStart.Year.ToString();
            mois = CalDate.SelectionStart.Month.ToString();
            jour = CalDate.SelectionStart.Day.ToString();
            dateSelectionne = annee + "/" + mois + "/" + jour;
            return dateSelectionne;
        }

        private void ListeVisiteurParDate(string unedate)
        {
            outils.MaConnexion();
            dtgListeVisiteurDateEmbauche.DataSource = outils.ExecReader_DataTable("EXEC PSS_DateEmbaucheVisiteur '" + unedate + "'");
            outils.MaDeconnexion();
        }

        private void DetailVisiteur(String UnMatricule)
        {
            outils.MaConnexion();
            SqlDataReader MonDataReader;
            // On récupère le matricule du visiteur où la ligne est sélectionnée.
            MonDataReader = outils.ExecuteReader("EXECUTE PSS_DetailVisiteur " + "'" + UnMatricule + "'");
            // Tant qu'il y a une ligne ...
            while (MonDataReader.Read())
            {
                lblDetailNom.Text = MonDataReader[0].ToString();
                lblDetailPrenom.Text = MonDataReader[1].ToString();
                lblDetailAdresse.Text = MonDataReader[2].ToString();
                lblDetailCP.Text = MonDataReader[3].ToString();
                lblDetailVille.Text = MonDataReader[4].ToString();
                lblDetailEmbauche.Text = Convert.ToDateTime(MonDataReader[5].ToString()).ToShortDateString();
            }
            outils.MaDeconnexion();
        }

        public FrmConsultationVisiteur()
        {
            InitializeComponent();
        }

        private void FrmConsultationVisiteur_Load(object sender, EventArgs e)
        {
            dtgListeVisiteurDateEmbauche.Visible = false;
            NombreVisiteur();
            ListeVisiteur();
            gbxDetailVisiteur.Visible = false;
            btnListeVisiteurDateEmbauche.Visible = false;
            dtgListeVisiteur.ReadOnly = true;
            dtgListeVisiteurDateEmbauche.ReadOnly = true;
        }

        private void lblDetail_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuitterVisite_Click(object sender, EventArgs e)
        {
            // Bouton permettant de quitter la fenêtre d'affiche des visiteurs.
            this.Close();
        }

        private void lblNbVisiteur_Click(object sender, EventArgs e)
        {

        }

        private void dtgListeVisiteur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String monMatricule;

            gbxDetailVisiteur.Visible = true;
            monMatricule = dtgListeVisiteur.CurrentRow.Cells["VIS_MATRICULE"].Value.ToString();
            DetailVisiteur(monMatricule);
        }

        private void dtgListeVisiteur_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void CalDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            dtgListeVisiteur.Visible = false;
            dtgListeVisiteurDateEmbauche.Visible = true;
            ListeVisiteurParDate(getDateSelectionne());
            NombreVisiteurParDate(getDateSelectionne());
            btnListeVisiteurDateEmbauche.Visible = true;
        }

        private void btnListeVisiteurDateEmbauche_Click(object sender, EventArgs e)
        {
            dtgListeVisiteurDateEmbauche.Visible = false;
            dtgListeVisiteur.Visible = true;
            btnListeVisiteurDateEmbauche.Visible = false;
        }

        private void btnListeVisiteurDateEmbauche_Click_1(object sender, EventArgs e)
        {
            NombreVisiteur();
            dtgListeVisiteurDateEmbauche.Visible = false;
            dtgListeVisiteur.Visible = true;
            btnListeVisiteurDateEmbauche.Visible = false;
        }

        private void gbxDetailVisiteur_Enter(object sender, EventArgs e)
        {

        }

        private void dtgListeVisiteurDateEmbauche_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String monMatricule;

            gbxDetailVisiteur.Visible = true;
            monMatricule = dtgListeVisiteurDateEmbauche.CurrentRow.Cells["VIS_MATRICULE"].Value.ToString();
            DetailVisiteur(monMatricule);
        }
    }
}
