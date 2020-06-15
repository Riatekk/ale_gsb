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
    public partial class FrmConsultationMedicament : Form
    {
        public FrmConsultationMedicament()
        {
            InitializeComponent();
        }

        private void FrmConsultationCompteRendus_Load(object sender, EventArgs e)
        {
            GrpBoxRechercheDate.Visible = true;
            ListeMedicaments();
            ListeNbMedic();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeNbMedic()
        {
            outils.MaConnexion();
            lblNbMedicament.Text += '\n' + outils.ExecuteScalar("EXEC PSS_NombreMedic");
            outils.MaDeconnexion();
        }
        private void ListeMedicaments()
        {
            outils.MaConnexion();
            DtgListeMedicament.DataSource = outils.ExecReader_DataTable("EXEC PSS_ListeMedic");
            outils.MaDeconnexion();
        }

        private void ListeDesPraParMedic(string unPraNum, DataGridView unDtg)
        {
            outils.MaConnexion();
            unDtg.DataSource = outils.ExecReader_DataTable("EXEC PSS_ListePraMedic '" + unPraNum + "'");
            outils.MaDeconnexion();
        }

        private void DtgListeMedicament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String monNumMedic;

            monNumMedic = DtgListeMedicament.CurrentRow.Cells["MED_DEPOTLEGAL"].Value.ToString();
            ListeDesPraParMedic(monNumMedic, DtgListePraticiens);
        }
    }
}
