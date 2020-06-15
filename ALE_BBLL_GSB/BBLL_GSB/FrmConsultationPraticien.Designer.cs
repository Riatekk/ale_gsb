namespace BBLL_GSB
{
    partial class FrmConsultationPraticien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNbPraticien = new System.Windows.Forms.Label();
            this.btnQuitterVisite = new System.Windows.Forms.Button();
            this.gbxDetailPraticien = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.lblDetailFonction = new System.Windows.Forms.Label();
            this.lblDetailPrenom = new System.Windows.Forms.Label();
            this.lblDetailNom = new System.Windows.Forms.Label();
            this.lblDetailVille = new System.Windows.Forms.Label();
            this.lblDetailCP = new System.Windows.Forms.Label();
            this.lblDetailAdresse = new System.Windows.Forms.Label();
            this.dtgListeVisiteur = new System.Windows.Forms.DataGridView();
            this.dtgListePraticien = new System.Windows.Forms.DataGridView();
            this.gbxVisiteur = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblDetailLieuFonction = new System.Windows.Forms.Label();
            this.gbxDetailPraticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListePraticien)).BeginInit();
            this.gbxVisiteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNbPraticien
            // 
            this.lblNbPraticien.AutoSize = true;
            this.lblNbPraticien.Font = new System.Drawing.Font("Consolas", 14.25743F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPraticien.Location = new System.Drawing.Point(711, 29);
            this.lblNbPraticien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPraticien.Name = "lblNbPraticien";
            this.lblNbPraticien.Size = new System.Drawing.Size(238, 24);
            this.lblNbPraticien.TabIndex = 4;
            this.lblNbPraticien.Text = "Nombre de praticien";
            this.lblNbPraticien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnQuitterVisite
            // 
            this.btnQuitterVisite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuitterVisite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitterVisite.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterVisite.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitterVisite.Location = new System.Drawing.Point(891, 556);
            this.btnQuitterVisite.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitterVisite.Name = "btnQuitterVisite";
            this.btnQuitterVisite.Size = new System.Drawing.Size(76, 39);
            this.btnQuitterVisite.TabIndex = 7;
            this.btnQuitterVisite.Text = "Fermer";
            this.btnQuitterVisite.UseVisualStyleBackColor = false;
            this.btnQuitterVisite.Click += new System.EventHandler(this.btnQuitterVisite_Click);
            // 
            // gbxDetailPraticien
            // 
            this.gbxDetailPraticien.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxDetailPraticien.Controls.Add(this.LblDetailLieuFonction);
            this.gbxDetailPraticien.Controls.Add(this.label6);
            this.gbxDetailPraticien.Controls.Add(this.label5);
            this.gbxDetailPraticien.Controls.Add(this.label4);
            this.gbxDetailPraticien.Controls.Add(this.label3);
            this.gbxDetailPraticien.Controls.Add(this.label2);
            this.gbxDetailPraticien.Controls.Add(this.label1);
            this.gbxDetailPraticien.Controls.Add(this.label0);
            this.gbxDetailPraticien.Controls.Add(this.lblDetailFonction);
            this.gbxDetailPraticien.Controls.Add(this.lblDetailPrenom);
            this.gbxDetailPraticien.Controls.Add(this.lblDetailNom);
            this.gbxDetailPraticien.Controls.Add(this.lblDetailVille);
            this.gbxDetailPraticien.Controls.Add(this.lblDetailCP);
            this.gbxDetailPraticien.Controls.Add(this.lblDetailAdresse);
            this.gbxDetailPraticien.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetailPraticien.Location = new System.Drawing.Point(15, 329);
            this.gbxDetailPraticien.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetailPraticien.Name = "gbxDetailPraticien";
            this.gbxDetailPraticien.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetailPraticien.Size = new System.Drawing.Size(680, 250);
            this.gbxDetailPraticien.TabIndex = 8;
            this.gbxDetailPraticien.TabStop = false;
            this.gbxDetailPraticien.Text = "Détail du praticien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fonction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ville :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "CP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adresse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prénom :";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(12, 28);
            this.label0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(54, 19);
            this.label0.TabIndex = 6;
            this.label0.Text = "Nom :";
            // 
            // lblDetailFonction
            // 
            this.lblDetailFonction.AutoSize = true;
            this.lblDetailFonction.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailFonction.Location = new System.Drawing.Point(182, 165);
            this.lblDetailFonction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailFonction.Name = "lblDetailFonction";
            this.lblDetailFonction.Size = new System.Drawing.Size(135, 19);
            this.lblDetailFonction.TabIndex = 5;
            this.lblDetailFonction.Text = "detailFonction";
            // 
            // lblDetailPrenom
            // 
            this.lblDetailPrenom.AutoSize = true;
            this.lblDetailPrenom.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailPrenom.Location = new System.Drawing.Point(182, 66);
            this.lblDetailPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailPrenom.Name = "lblDetailPrenom";
            this.lblDetailPrenom.Size = new System.Drawing.Size(117, 19);
            this.lblDetailPrenom.TabIndex = 4;
            this.lblDetailPrenom.Text = "detailPrénom";
            // 
            // lblDetailNom
            // 
            this.lblDetailNom.AutoSize = true;
            this.lblDetailNom.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailNom.Location = new System.Drawing.Point(182, 28);
            this.lblDetailNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailNom.Name = "lblDetailNom";
            this.lblDetailNom.Size = new System.Drawing.Size(90, 19);
            this.lblDetailNom.TabIndex = 3;
            this.lblDetailNom.Text = "detailNom";
            // 
            // lblDetailVille
            // 
            this.lblDetailVille.AutoSize = true;
            this.lblDetailVille.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailVille.Location = new System.Drawing.Point(457, 103);
            this.lblDetailVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailVille.Name = "lblDetailVille";
            this.lblDetailVille.Size = new System.Drawing.Size(108, 19);
            this.lblDetailVille.TabIndex = 2;
            this.lblDetailVille.Text = "detailVille";
            // 
            // lblDetailCP
            // 
            this.lblDetailCP.AutoSize = true;
            this.lblDetailCP.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailCP.Location = new System.Drawing.Point(457, 66);
            this.lblDetailCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailCP.Name = "lblDetailCP";
            this.lblDetailCP.Size = new System.Drawing.Size(81, 19);
            this.lblDetailCP.TabIndex = 1;
            this.lblDetailCP.Text = "detailCP";
            // 
            // lblDetailAdresse
            // 
            this.lblDetailAdresse.AutoSize = true;
            this.lblDetailAdresse.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailAdresse.Location = new System.Drawing.Point(457, 28);
            this.lblDetailAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailAdresse.Name = "lblDetailAdresse";
            this.lblDetailAdresse.Size = new System.Drawing.Size(126, 19);
            this.lblDetailAdresse.TabIndex = 0;
            this.lblDetailAdresse.Text = "detailAdresse";
            // 
            // dtgListeVisiteur
            // 
            this.dtgListeVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListeVisiteur.Location = new System.Drawing.Point(4, 73);
            this.dtgListeVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.dtgListeVisiteur.Name = "dtgListeVisiteur";
            this.dtgListeVisiteur.RowTemplate.Height = 24;
            this.dtgListeVisiteur.Size = new System.Drawing.Size(671, 237);
            this.dtgListeVisiteur.TabIndex = 0;
            // 
            // dtgListePraticien
            // 
            this.dtgListePraticien.Location = new System.Drawing.Point(4, 18);
            this.dtgListePraticien.Name = "dtgListePraticien";
            this.dtgListePraticien.Size = new System.Drawing.Size(671, 291);
            this.dtgListePraticien.TabIndex = 1;
            this.dtgListePraticien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListePraticien_CellClick);
            // 
            // gbxVisiteur
            // 
            this.gbxVisiteur.Controls.Add(this.dtgListePraticien);
            this.gbxVisiteur.Controls.Add(this.dtgListeVisiteur);
            this.gbxVisiteur.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVisiteur.Location = new System.Drawing.Point(11, 11);
            this.gbxVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.gbxVisiteur.Name = "gbxVisiteur";
            this.gbxVisiteur.Padding = new System.Windows.Forms.Padding(2);
            this.gbxVisiteur.Size = new System.Drawing.Size(680, 314);
            this.gbxVisiteur.TabIndex = 4;
            this.gbxVisiteur.TabStop = false;
            this.gbxVisiteur.Text = "Informations sur les praticiens";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lieu";
            // 
            // LblDetailLieuFonction
            // 
            this.LblDetailLieuFonction.AutoSize = true;
            this.LblDetailLieuFonction.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetailLieuFonction.Location = new System.Drawing.Point(182, 208);
            this.LblDetailLieuFonction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetailLieuFonction.Name = "LblDetailLieuFonction";
            this.LblDetailLieuFonction.Size = new System.Drawing.Size(171, 19);
            this.LblDetailLieuFonction.TabIndex = 13;
            this.LblDetailLieuFonction.Text = "detailLieuFonction";
            // 
            // FrmConsultationPraticien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 606);
            this.ControlBox = false;
            this.Controls.Add(this.gbxDetailPraticien);
            this.Controls.Add(this.lblNbPraticien);
            this.Controls.Add(this.btnQuitterVisite);
            this.Controls.Add(this.gbxVisiteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultationPraticien";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultationVisiteur";
            this.Load += new System.EventHandler(this.FrmConsultationVisiteur_Load);
            this.gbxDetailPraticien.ResumeLayout(false);
            this.gbxDetailPraticien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListePraticien)).EndInit();
            this.gbxVisiteur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuitterVisite;
        private System.Windows.Forms.Label lblNbPraticien;
        private System.Windows.Forms.GroupBox gbxDetailPraticien;
        private System.Windows.Forms.Label lblDetailVille;
        private System.Windows.Forms.Label lblDetailCP;
        private System.Windows.Forms.Label lblDetailFonction;
        private System.Windows.Forms.Label lblDetailPrenom;
        private System.Windows.Forms.Label lblDetailNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetailAdresse;
        private System.Windows.Forms.DataGridView dtgListeVisiteur;
        private System.Windows.Forms.DataGridView dtgListePraticien;
        private System.Windows.Forms.GroupBox gbxVisiteur;
        private System.Windows.Forms.Label LblDetailLieuFonction;
        private System.Windows.Forms.Label label6;
    }
}