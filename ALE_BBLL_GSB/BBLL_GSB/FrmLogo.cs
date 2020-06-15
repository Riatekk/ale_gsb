using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBLL_GSB
{
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();
        }

        private void btnQuitterVisite_Click(object sender, EventArgs e)
        {
            DialogResult resultat;
            resultat = MessageBox.Show("Voulez-vous quitter l'application ?", "Message de Fermeture d'application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnGererRapports_Click(object sender, EventArgs e)
        {
            //Déclaration et instanciation d'un formulaire
            Form FrmModificationsRapports = new FrmModificationsRapports();
            //Le formulaire FrmModificationsRapports a pour parent le formuaire courant = this (ici FrmMenu)
            FrmModificationsRapports.MdiParent = this.MdiParent;
            //Ouverture du formulaire
            FrmModificationsRapports.Show();
        }

        private void BtnConsulteVisiteurs_Click(object sender, EventArgs e)
        {
            //Déclaration et instanciation d'un formulaire
            Form FrmConsultationVisiteur = new FrmConsultationVisiteur();
            //Le formulaire FrmConsultationVisiteur a pour parent le formuaire courant = this (ici FrmMenu)
            FrmConsultationVisiteur.MdiParent = this.MdiParent;
            //Ouverture du formulaire
            FrmConsultationVisiteur.Show();
        }

        private void BtnConsulteRapports_Click(object sender, EventArgs e)
        {
            //Déclaration et instanciation d'un formulaire
            Form FrmConsultationCompteRendus = new FrmConsultationCompteRendus();
            //Le formulaire FrmConsultationCompteRendus a pour parent le formuaire courant = this (ici FrmMenu)
            FrmConsultationCompteRendus.MdiParent = this.MdiParent;
            //Ouverture du formulaire
            FrmConsultationCompteRendus.Show();
        }

        private void BtnConsulteArchives_Click(object sender, EventArgs e)
        {
            //Déclaration et instanciation d'un formulaire
            Form FrmConsultationArchive = new FrmConsultationArchives();
            //Le formulaire FrmConsultationArchive a pour parent le formuaire courant = this (ici FrmMenu)
            FrmConsultationArchive.MdiParent = this.MdiParent;
            //Ouverture du formulaire
            FrmConsultationArchive.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Déclaration et instanciation d'un formulaire
            Form FrmConsultationPraticien = new FrmConsultationPraticien();
            //Le formulaire FrmConsultationArchive a pour parent le formuaire courant = this (ici FrmMenu)
            FrmConsultationPraticien.MdiParent = this.MdiParent;
            //Ouverture du formulaire
            FrmConsultationPraticien.Show();
        }

        private void BtnConsulteMedic_Click(object sender, EventArgs e)
        {
            //Déclaration et instanciation d'un formulaire
            Form FrmConsultationMedicament = new FrmConsultationMedicament();
            //Le formulaire FrmConsultationArchive a pour parent le formuaire courant = this (ici FrmMenu)
            FrmConsultationMedicament.MdiParent = this.MdiParent;
            //Ouverture du formulaire
            FrmConsultationMedicament.Show();
        }
    }
}
