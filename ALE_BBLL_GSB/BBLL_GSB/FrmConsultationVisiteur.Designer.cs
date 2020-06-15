namespace BBLL_GSB
{
    partial class FrmConsultationVisiteur
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
            this.dtgListeVisiteur = new System.Windows.Forms.DataGridView();
            this.lblListeVisiteur = new System.Windows.Forms.Label();
            this.gbxVisiteur = new System.Windows.Forms.GroupBox();
            this.btnListeVisiteurDateEmbauche = new System.Windows.Forms.Button();
            this.dtgListeVisiteurDateEmbauche = new System.Windows.Forms.DataGridView();
            this.lblNbVisiteur = new System.Windows.Forms.Label();
            this.CalDate = new System.Windows.Forms.MonthCalendar();
            this.btnQuitterVisite = new System.Windows.Forms.Button();
            this.gbxDetailVisiteur = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.lblDetailEmbauche = new System.Windows.Forms.Label();
            this.lblDetailPrenom = new System.Windows.Forms.Label();
            this.lblDetailNom = new System.Windows.Forms.Label();
            this.lblDetailVille = new System.Windows.Forms.Label();
            this.lblDetailCP = new System.Windows.Forms.Label();
            this.lblDetailAdresse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeVisiteur)).BeginInit();
            this.gbxVisiteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeVisiteurDateEmbauche)).BeginInit();
            this.gbxDetailVisiteur.SuspendLayout();
            this.SuspendLayout();
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
            this.dtgListeVisiteur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListeVisiteur_CellClick);
            this.dtgListeVisiteur.SelectionChanged += new System.EventHandler(this.dtgListeVisiteur_SelectionChanged);
            // 
            // lblListeVisiteur
            // 
            this.lblListeVisiteur.AutoSize = true;
            this.lblListeVisiteur.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeVisiteur.Location = new System.Drawing.Point(4, 30);
            this.lblListeVisiteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListeVisiteur.Name = "lblListeVisiteur";
            this.lblListeVisiteur.Size = new System.Drawing.Size(133, 13);
            this.lblListeVisiteur.TabIndex = 1;
            this.lblListeVisiteur.Text = "Liste des visiteurs :";
            // 
            // gbxVisiteur
            // 
            this.gbxVisiteur.Controls.Add(this.btnListeVisiteurDateEmbauche);
            this.gbxVisiteur.Controls.Add(this.dtgListeVisiteurDateEmbauche);
            this.gbxVisiteur.Controls.Add(this.dtgListeVisiteur);
            this.gbxVisiteur.Controls.Add(this.lblListeVisiteur);
            this.gbxVisiteur.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVisiteur.Location = new System.Drawing.Point(250, 10);
            this.gbxVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.gbxVisiteur.Name = "gbxVisiteur";
            this.gbxVisiteur.Padding = new System.Windows.Forms.Padding(2);
            this.gbxVisiteur.Size = new System.Drawing.Size(680, 314);
            this.gbxVisiteur.TabIndex = 4;
            this.gbxVisiteur.TabStop = false;
            this.gbxVisiteur.Text = "Informations sur les visiteurs";
            this.gbxVisiteur.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnListeVisiteurDateEmbauche
            // 
            this.btnListeVisiteurDateEmbauche.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnListeVisiteurDateEmbauche.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListeVisiteurDateEmbauche.Location = new System.Drawing.Point(591, 18);
            this.btnListeVisiteurDateEmbauche.Name = "btnListeVisiteurDateEmbauche";
            this.btnListeVisiteurDateEmbauche.Size = new System.Drawing.Size(75, 37);
            this.btnListeVisiteurDateEmbauche.TabIndex = 0;
            this.btnListeVisiteurDateEmbauche.Text = "Retour";
            this.btnListeVisiteurDateEmbauche.UseVisualStyleBackColor = false;
            this.btnListeVisiteurDateEmbauche.Click += new System.EventHandler(this.btnListeVisiteurDateEmbauche_Click_1);
            // 
            // dtgListeVisiteurDateEmbauche
            // 
            this.dtgListeVisiteurDateEmbauche.Location = new System.Drawing.Point(4, 73);
            this.dtgListeVisiteurDateEmbauche.Name = "dtgListeVisiteurDateEmbauche";
            this.dtgListeVisiteurDateEmbauche.Size = new System.Drawing.Size(671, 236);
            this.dtgListeVisiteurDateEmbauche.TabIndex = 1;
            this.dtgListeVisiteurDateEmbauche.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListeVisiteurDateEmbauche_CellClick_1);
            // 
            // lblNbVisiteur
            // 
            this.lblNbVisiteur.AutoSize = true;
            this.lblNbVisiteur.Font = new System.Drawing.Font("Consolas", 14.25743F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbVisiteur.Location = new System.Drawing.Point(11, 389);
            this.lblNbVisiteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbVisiteur.Name = "lblNbVisiteur";
            this.lblNbVisiteur.Size = new System.Drawing.Size(226, 24);
            this.lblNbVisiteur.TabIndex = 4;
            this.lblNbVisiteur.Text = "Nombre de visiteur";
            this.lblNbVisiteur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNbVisiteur.Click += new System.EventHandler(this.lblNbVisiteur_Click);
            // 
            // CalDate
            // 
            this.CalDate.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.CalDate.Location = new System.Drawing.Point(4, 10);
            this.CalDate.Margin = new System.Windows.Forms.Padding(7);
            this.CalDate.Name = "CalDate";
            this.CalDate.TabIndex = 5;
            this.CalDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalDate_DateSelected);
            // 
            // btnQuitterVisite
            // 
            this.btnQuitterVisite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuitterVisite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitterVisite.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterVisite.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitterVisite.Location = new System.Drawing.Point(854, 473);
            this.btnQuitterVisite.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitterVisite.Name = "btnQuitterVisite";
            this.btnQuitterVisite.Size = new System.Drawing.Size(76, 39);
            this.btnQuitterVisite.TabIndex = 7;
            this.btnQuitterVisite.Text = "Fermer";
            this.btnQuitterVisite.UseVisualStyleBackColor = false;
            this.btnQuitterVisite.Click += new System.EventHandler(this.btnQuitterVisite_Click);
            // 
            // gbxDetailVisiteur
            // 
            this.gbxDetailVisiteur.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxDetailVisiteur.Controls.Add(this.label5);
            this.gbxDetailVisiteur.Controls.Add(this.label4);
            this.gbxDetailVisiteur.Controls.Add(this.label3);
            this.gbxDetailVisiteur.Controls.Add(this.label2);
            this.gbxDetailVisiteur.Controls.Add(this.label1);
            this.gbxDetailVisiteur.Controls.Add(this.label0);
            this.gbxDetailVisiteur.Controls.Add(this.lblDetailEmbauche);
            this.gbxDetailVisiteur.Controls.Add(this.lblDetailPrenom);
            this.gbxDetailVisiteur.Controls.Add(this.lblDetailNom);
            this.gbxDetailVisiteur.Controls.Add(this.lblDetailVille);
            this.gbxDetailVisiteur.Controls.Add(this.lblDetailCP);
            this.gbxDetailVisiteur.Controls.Add(this.lblDetailAdresse);
            this.gbxDetailVisiteur.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetailVisiteur.Location = new System.Drawing.Point(250, 328);
            this.gbxDetailVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetailVisiteur.Name = "gbxDetailVisiteur";
            this.gbxDetailVisiteur.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetailVisiteur.Size = new System.Drawing.Size(680, 141);
            this.gbxDetailVisiteur.TabIndex = 8;
            this.gbxDetailVisiteur.TabStop = false;
            this.gbxDetailVisiteur.Text = "Détail du visiteur";
            this.gbxDetailVisiteur.Enter += new System.EventHandler(this.gbxDetailVisiteur_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date d\'embauche :";
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
            // lblDetailEmbauche
            // 
            this.lblDetailEmbauche.AutoSize = true;
            this.lblDetailEmbauche.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailEmbauche.Location = new System.Drawing.Point(182, 103);
            this.lblDetailEmbauche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetailEmbauche.Name = "lblDetailEmbauche";
            this.lblDetailEmbauche.Size = new System.Drawing.Size(162, 19);
            this.lblDetailEmbauche.TabIndex = 5;
            this.lblDetailEmbauche.Text = "Date d\'embauche :";
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
            // FrmConsultationVisiteur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(941, 523);
            this.ControlBox = false;
            this.Controls.Add(this.gbxDetailVisiteur);
            this.Controls.Add(this.lblNbVisiteur);
            this.Controls.Add(this.btnQuitterVisite);
            this.Controls.Add(this.CalDate);
            this.Controls.Add(this.gbxVisiteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultationVisiteur";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultationVisiteur";
            this.Load += new System.EventHandler(this.FrmConsultationVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeVisiteur)).EndInit();
            this.gbxVisiteur.ResumeLayout(false);
            this.gbxVisiteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeVisiteurDateEmbauche)).EndInit();
            this.gbxDetailVisiteur.ResumeLayout(false);
            this.gbxDetailVisiteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListeVisiteur;
        private System.Windows.Forms.Label lblListeVisiteur;
        private System.Windows.Forms.GroupBox gbxVisiteur;
        private System.Windows.Forms.MonthCalendar CalDate;
        private System.Windows.Forms.Button btnQuitterVisite;
        private System.Windows.Forms.Label lblNbVisiteur;
        private System.Windows.Forms.GroupBox gbxDetailVisiteur;
        private System.Windows.Forms.Label lblDetailVille;
        private System.Windows.Forms.Label lblDetailCP;
        private System.Windows.Forms.Label lblDetailEmbauche;
        private System.Windows.Forms.Label lblDetailPrenom;
        private System.Windows.Forms.Label lblDetailNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListeVisiteurDateEmbauche;
        private System.Windows.Forms.Label lblDetailAdresse;
        private System.Windows.Forms.DataGridView dtgListeVisiteurDateEmbauche;
    }
}