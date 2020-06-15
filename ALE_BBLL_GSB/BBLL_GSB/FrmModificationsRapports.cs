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
    public partial class FrmModificationsRapports : Form
    {
        /*Controle du formulaire*/
        public FrmModificationsRapports()
        {
            InitializeComponent();
        }
        private void FrmModificationsRapports_Load(object sender, EventArgs e)
        {
            NombreRapports();
            ListeDesRapports();

            cbxListe("EXEC PSS_MatriculeVis", CbxMatriculeVis);
            cbxListe("EXEC PSS_NumPraticien", CbxNumPra);
            cbxListe("EXEC PSS_ListeMedicament", CbxNomMedic);

        }

        private void NombreRapports()
        {
            outils.MaConnexion();
            LblNbRapports.Text = outils.ExecuteScalar("EXECUTE PSS_NombreRapports");
            outils.MaDeconnexion();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Mise a jour de la dtg*/
        private void ListeDesRapports()
        {
            outils.MaConnexion();
            dtgListeRapport.DataSource = outils.ExecReader_DataTable("EXEC PSS_ListeMajRapports");
            outils.MaDeconnexion();
        }

        /*Ajout d'un rapport*/
        private void InsertionRapport()
        {
            outils.MaConnexion();
            //dtgListeRapport.DataSource = outils.ExecReader_DataTable("EXEC PSS_ListeRapports");
            outils.MaDeconnexion();
        }
        private void AjoutRapport()
        {
            outils.MaConnexion();

            outils.MaDeconnexion();
        }
        private void btnInsertion_Click(object sender, EventArgs e)
        {
            if (GbxAjoutRap.Visible == false)
            {
                if (GbxModification.Visible == true)
                {
                    GbxModification.Visible = false;
                }
                GbxAjoutRap.Visible = true;

                cbxListe("EXEC PSS_MatriculeVis", CbxMatriculeVis);
                cbxListe("EXEC PSS_NumPraticien", CbxNumPra);
                cbxListe("EXEC PSS_ListeMedicament", CbxNomMedic);
            }
            else
            {
                GbxAjoutRap.Visible = false;
            }
        }
        private String RecupId(ComboBox Cbx)
        {
            #region Récumération de l'id
            // declaration des variables
            string laLettre, Num;
            int i;
            i = 0;
            laLettre = "";
            Num = "";

            //Recuperation du numéro du praticien
            while (laLettre != "(")
            {
                laLettre = Cbx.Text.Substring(i, 1);
                
                if (laLettre != "(" && laLettre != " ")
                {
                    Num = Num + Cbx.Text.Substring(i, 1);
                }
                //MessageBox.Show(laLettre);
                i += 1;
            }
            #endregion
            return Num;
        }
        private void BtnValiderAjout_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CbxMatriculeVis.Text))
            {
                if (!String.IsNullOrEmpty(CbxNumPra.Text))
                {
                    if (!String.IsNullOrEmpty(CbxNomMedic.Text))
                    {
                        if (!String.IsNullOrEmpty(RTxtBxBilan.Text))
                        {
                            if (!String.IsNullOrEmpty(RTxtBxMotif.Text))
                            {
                                #region envoie de la requete SQL vers la BD
                                outils.MaConnexion();
                                string requeteSQL = "EXEC PSI_unRapport" + " '" + RecupId(CbxMatriculeVis) + "'," + int.Parse(RecupId(CbxNumPra)) + ",'" + RTxtBxBilan.Text + "','" + RTxtBxMotif.Text + "' , '" + RecupId(CbxNomMedic) + "' ," + NumUpDownQteMedic.Value;
                                outils.Exec_NonQuery(requeteSQL);
                                outils.MaDeconnexion();
                                #endregion
                            }
                            else
                            {
                                MessageBox.Show(this, "Le motif n\'est pas renseigné", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Le bilan n\'est pas renseigné", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Le numéro du medicament n\'est pas renseigné", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Le numéro du praticien n\'est pas renseigné", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Le numéro de matricule du visiteur n\'est pas renseigné", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //On actualise la liste des rapport
            ListeDesRapports();
            NombreRapports();
        }
        private void cbxListe(string maRequete, ComboBox maComboBox)
        {
            DataTable enregistrement;

            outils.MaConnexion();
            enregistrement = outils.ExecReader_DataTable(maRequete);
            outils.MaDeconnexion();

            foreach (DataRow res in enregistrement.Rows)
            {
                maComboBox.Items.Add(res[1].ToString());
            }
        }
        /*Suppression d'un rapport*/
        private void SuppressionRapport()
        {
            outils.MaConnexion();
            String MonMatricule;
            // On récupère le matricule du visiteur où la ligne est sélectionnée.
            MonMatricule = dtgListeRapport.CurrentRow.Cells["RAP_NUM"].Value.ToString();
            outils.Exec_NonQuery("EXEC PSD_SuppressionRapport" + " " + MonMatricule );
            outils.MaDeconnexion();
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //ModificationVisible();
            DialogResult resultat;
            resultat = MessageBox.Show("Voulez-vous supprimer le rapport ?", "Message de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultat == DialogResult.Yes)
            {
                SuppressionRapport();
                resultat = MessageBox.Show("Votre rapport été supprimé !", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListeDesRapports();
            NombreRapports();

        }
        private void ModificationDesRapports()
        {
            String UnRapport;
            String strRequete;
            String Motif = TxtMotif.Text;
            String Bilan = TxtBilan.Text;
            // On récupère le matricule du visiteur où la ligne est sélectionnée.
            UnRapport = dtgListeRapport.CurrentRow.Cells["RAP_NUM"].Value.ToString();

            if (!String.IsNullOrEmpty(UnRapport))
            {
                if (!String.IsNullOrEmpty(TxtMotif.Text))
                {
                    if (!String.IsNullOrEmpty(TxtBilan.Text))
                    {
                        outils.MaConnexion();
                        strRequete = "execute PSU_MajRapports " + UnRapport + ",'" + Motif + "','" + Bilan + "'";
                        outils.ExecuteReader(strRequete);
                        dtgListeRapport.Refresh();
                        outils.MaDeconnexion();
                    }
                    else
                    {
                        MessageBox.Show(this, "Le bilan n\'est pas renseigné", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Le motif n\'est pas renseigné", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Veuillez sélectionner un rapport", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (GbxModification.Visible == false)
            {
                if (GbxAjoutRap.Visible == true)
                {
                    GbxAjoutRap.Visible = false;
                }

                GbxModification.Visible = true;

                cbxListe("EXEC PSS_MatriculeVis", CbxMatriculeVis);
                cbxListe("EXEC PSS_NumPraticien", CbxNumPra);
            }
            else
            {
                GbxModification.Visible = false;
            }

            ListeDesRapports();
        }
        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            ModificationDesRapports();
            ListeDesRapports();
        }

        private void dtgListeRapport_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String MonMotif;
            String MonBilan;
            MonMotif = dtgListeRapport.CurrentRow.Cells["RAP_MOTIF"].Value.ToString();
            MonBilan = dtgListeRapport.CurrentRow.Cells["RAP_BILAN"].Value.ToString();
            TxtMotif.Text = MonMotif;
            TxtBilan.Text = MonBilan;
        }
    }
}
