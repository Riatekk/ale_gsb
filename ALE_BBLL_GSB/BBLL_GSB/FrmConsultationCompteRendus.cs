using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acces_BDClassLibrary;

namespace BBLL_GSB
{
    public partial class FrmConsultationCompteRendus : Form
    {
        private const string grpboxMsgTT = "Liste des compte rendus";
        private const string grpboxMsgDate = "Liste des compte rendus par date de visite";
        public FrmConsultationCompteRendus()
        {
            InitializeComponent();
        }

        private void FrmConsultationCompteRendus_Load(object sender, EventArgs e)
        {
            GrpBoxRechercheDate.Visible = false;
            GrpBoxRechercheTT.Visible = true;
            ListeDesRapports();
            ListeNbRapports();
        }

        private void BtnRecherche_Click(object sender, EventArgs e)
        {
            if (GrpBoxRechercheTT.Visible)
            {
                BtnRecherche.Text = "Recherche tout les compte rendus";
                ListeNbRapports();
                GrpBoxRechercheDate.Visible = true;
                GrpBoxRechercheTT.Visible = false;
            }
            else
            {
                BtnRecherche.Text = "Recherche par date de visite";
                ListeNbRapportsParDate();
                GrpBoxRechercheDate.Visible = false;
                GrpBoxRechercheTT.Visible = true;
                ListeDesRapports();
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeNbRapports()
        {
            outils.MaConnexion();
            GrpBoxRechercheTT.Text = grpboxMsgTT + " : il y a " + outils.ExecuteScalar("EXEC PSS_NombreRapports") + " compte rendus";
            outils.MaDeconnexion();
        }
        private void ListeDesRapports()
        {
            outils.MaConnexion();
            DtgListeRapport.DataSource = outils.ExecReader_DataTable("EXEC PSS_ListeRapports");
            outils.MaDeconnexion();
        }
        private void ListeNbRapportsParDate()
        {
            outils.MaConnexion();
            GrpBoxRechercheDate.Text = grpboxMsgDate + " : il y a " + (DtgListeRapportDate.RowCount-1) + " compte rendus";
            outils.MaDeconnexion();
        }
        private void ListeDesRapportsParDate(string unedate)
        {
            outils.MaConnexion();
            DtgListeRapportDate.DataSource = outils.ExecReader_DataTable("EXEC PSS_DateRapports '" + getDateSelectionne() + "'");
            outils.MaDeconnexion();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            ListeDesRapportsParDate(getDateSelectionne());
            ListeNbRapportsParDate();
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

        private void ListeDesMedocParRap(string unRapNum, DataGridView unDtg)
        {
            outils.MaConnexion();
            unDtg.DataSource = outils.ExecReader_DataTable("EXEC PSS_ListeMedocRap " + unRapNum);
            outils.MaDeconnexion();
        }

        private void DtgListeRapport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String monRapNum;

            monRapNum = DtgListeRapport.CurrentRow.Cells["RAP_NUM"].Value.ToString();
            ListeDesMedocParRap(monRapNum, DtgListeRapMedoc);
        }

        private void DtgListeRapportDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String monRapNum;

            monRapNum = DtgListeRapportDate.CurrentRow.Cells["RAP_NUM"].Value.ToString();
            ListeDesMedocParRap(monRapNum, DtgListeRapMedocDate);
        }
    }
}
