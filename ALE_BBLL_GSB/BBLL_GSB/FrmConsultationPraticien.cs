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
    public partial class FrmConsultationPraticien : Form
    {
        public FrmConsultationPraticien()
        {
            InitializeComponent();
        }

        private void FrmConsultationVisiteur_Load(object sender, EventArgs e)
        {
            NombrePraticien();
            ListePraticien();
            gbxDetailPraticien.Visible = false;
            dtgListePraticien.ReadOnly = true;
        }

        private void NombrePraticien()
        {
            outils.MaConnexion();
            lblNbPraticien.Text = "Nombre de praticien\n" + outils.ExecuteScalar("EXECUTE PSS_NombrePraticien");
            outils.MaDeconnexion();
        }

        private void ListePraticien()
        {
            outils.MaConnexion();
            try
            {
                string requête;
                requête = ("EXECUTE PSS_ListePraticien");
                dtgListePraticien.DataSource = outils.ExecReader_DataTable(requête);
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

        private void DetailPraticien(String UnMatricule)
        {
            outils.MaConnexion();
            SqlDataReader MonDataReader;
            // On récupère le matricule du visiteur où la ligne est sélectionnée.
            MonDataReader = outils.ExecuteReader("EXECUTE PSS_DetailPraticien " + "'" + UnMatricule + "'");
            // Tant qu'il y a une ligne ...
            while (MonDataReader.Read())
            {
                lblDetailNom.Text = MonDataReader[0].ToString();
                lblDetailPrenom.Text = MonDataReader[1].ToString();
                lblDetailAdresse.Text = MonDataReader[2].ToString();
                lblDetailCP.Text = MonDataReader[3].ToString();
                lblDetailVille.Text = MonDataReader[4].ToString();
                lblDetailFonction.Text = MonDataReader[5].ToString();
                LblDetailLieuFonction.Text = MonDataReader[6].ToString();
            }
            outils.MaDeconnexion();
        }

        private void btnQuitterVisite_Click(object sender, EventArgs e)
        {
            // Bouton permettant de quitter la fenêtre d'affiche des visiteurs.
            this.Close();
        }

        private void dtgListePraticien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String monNumPra;

            gbxDetailPraticien.Visible = true;
            monNumPra = dtgListePraticien.CurrentRow.Cells["PRA_NUM"].Value.ToString();
            DetailPraticien(monNumPra);
        }
    }
}
