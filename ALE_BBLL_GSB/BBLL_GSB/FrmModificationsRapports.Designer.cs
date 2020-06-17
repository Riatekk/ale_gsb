namespace BBLL_GSB
{
    partial class FrmModificationsRapports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificationsRapports));
            this.dtgListeRapport = new System.Windows.Forms.DataGridView();
            this.rtxtAide = new System.Windows.Forms.RichTextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.GbxModification = new System.Windows.Forms.GroupBox();
            this.LblMessageModif = new System.Windows.Forms.Label();
            this.LblModification = new System.Windows.Forms.Label();
            this.BtnConfirmer = new System.Windows.Forms.Button();
            this.LblMotif = new System.Windows.Forms.Label();
            this.LblBilan = new System.Windows.Forms.Label();
            this.TxtMotif = new System.Windows.Forms.TextBox();
            this.TxtBilan = new System.Windows.Forms.TextBox();
            this.GbxAjoutRap = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumUpDownQteMedic = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxNomMedic = new System.Windows.Forms.ComboBox();
            this.CbxMatriculeVis = new System.Windows.Forms.ComboBox();
            this.CbxNumPra = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RTxtBxMotif = new System.Windows.Forms.RichTextBox();
            this.RTxtBxBilan = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnValiderAjout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNbRapportsTxt = new System.Windows.Forms.Label();
            this.LblNbRapport = new System.Windows.Forms.Label();
            this.LblNbRapports = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeRapport)).BeginInit();
            this.GbxModification.SuspendLayout();
            this.GbxAjoutRap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownQteMedic)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListeRapport
            // 
            this.dtgListeRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListeRapport.Location = new System.Drawing.Point(15, 190);
            this.dtgListeRapport.Margin = new System.Windows.Forms.Padding(2);
            this.dtgListeRapport.Name = "dtgListeRapport";
            this.dtgListeRapport.RowTemplate.Height = 24;
            this.dtgListeRapport.Size = new System.Drawing.Size(621, 273);
            this.dtgListeRapport.TabIndex = 0;
            this.dtgListeRapport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListeRapport_CellClick_1);
            // 
            // rtxtAide
            // 
            this.rtxtAide.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxtAide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAide.Location = new System.Drawing.Point(9, 11);
            this.rtxtAide.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtAide.Name = "rtxtAide";
            this.rtxtAide.Size = new System.Drawing.Size(627, 123);
            this.rtxtAide.TabIndex = 2;
            this.rtxtAide.Text = resources.GetString("rtxtAide.Text");
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModifier.Font = new System.Drawing.Font("Consolas", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifier.Location = new System.Drawing.Point(15, 475);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(131, 41);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Blue;
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.Font = new System.Drawing.Font("Consolas", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSupprimer.Location = new System.Drawing.Point(149, 475);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(107, 41);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInsertion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInsertion.Font = new System.Drawing.Font("Consolas", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertion.Location = new System.Drawing.Point(494, 475);
            this.btnInsertion.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(142, 41);
            this.btnInsertion.TabIndex = 5;
            this.btnInsertion.Text = "Nouveau rapport";
            this.btnInsertion.UseVisualStyleBackColor = false;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFermer.Location = new System.Drawing.Point(868, 482);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(62, 34);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // GbxModification
            // 
            this.GbxModification.Controls.Add(this.LblMessageModif);
            this.GbxModification.Controls.Add(this.LblModification);
            this.GbxModification.Controls.Add(this.BtnConfirmer);
            this.GbxModification.Controls.Add(this.LblMotif);
            this.GbxModification.Controls.Add(this.LblBilan);
            this.GbxModification.Controls.Add(this.TxtMotif);
            this.GbxModification.Controls.Add(this.TxtBilan);
            this.GbxModification.Location = new System.Drawing.Point(662, 11);
            this.GbxModification.Margin = new System.Windows.Forms.Padding(2);
            this.GbxModification.Name = "GbxModification";
            this.GbxModification.Padding = new System.Windows.Forms.Padding(2);
            this.GbxModification.Size = new System.Drawing.Size(241, 467);
            this.GbxModification.TabIndex = 7;
            this.GbxModification.TabStop = false;
            this.GbxModification.Visible = false;
            // 
            // LblMessageModif
            // 
            this.LblMessageModif.AutoSize = true;
            this.LblMessageModif.Location = new System.Drawing.Point(12, 187);
            this.LblMessageModif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMessageModif.Name = "LblMessageModif";
            this.LblMessageModif.Size = new System.Drawing.Size(229, 15);
            this.LblMessageModif.TabIndex = 6;
            this.LblMessageModif.Text = "*Seul le motif et le bilan sont modifiables";
            // 
            // LblModification
            // 
            this.LblModification.AutoSize = true;
            this.LblModification.Location = new System.Drawing.Point(89, 42);
            this.LblModification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblModification.Name = "LblModification";
            this.LblModification.Size = new System.Drawing.Size(92, 15);
            this.LblModification.TabIndex = 5;
            this.LblModification.Text = "MODIFICATION";
            // 
            // BtnConfirmer
            // 
            this.BtnConfirmer.Location = new System.Drawing.Point(152, 148);
            this.BtnConfirmer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirmer.Name = "BtnConfirmer";
            this.BtnConfirmer.Size = new System.Drawing.Size(77, 37);
            this.BtnConfirmer.TabIndex = 4;
            this.BtnConfirmer.Text = "Confirmer";
            this.BtnConfirmer.UseVisualStyleBackColor = true;
            this.BtnConfirmer.Click += new System.EventHandler(this.BtnConfirmer_Click);
            // 
            // LblMotif
            // 
            this.LblMotif.AutoSize = true;
            this.LblMotif.Location = new System.Drawing.Point(12, 76);
            this.LblMotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMotif.Name = "LblMotif";
            this.LblMotif.Size = new System.Drawing.Size(40, 15);
            this.LblMotif.TabIndex = 3;
            this.LblMotif.Text = "Motif :";
            // 
            // LblBilan
            // 
            this.LblBilan.AutoSize = true;
            this.LblBilan.Location = new System.Drawing.Point(11, 111);
            this.LblBilan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBilan.Name = "LblBilan";
            this.LblBilan.Size = new System.Drawing.Size(41, 15);
            this.LblBilan.TabIndex = 2;
            this.LblBilan.Text = "Bilan :";
            // 
            // TxtMotif
            // 
            this.TxtMotif.Location = new System.Drawing.Point(51, 76);
            this.TxtMotif.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMotif.Name = "TxtMotif";
            this.TxtMotif.Size = new System.Drawing.Size(179, 20);
            this.TxtMotif.TabIndex = 1;
            // 
            // TxtBilan
            // 
            this.TxtBilan.Location = new System.Drawing.Point(51, 109);
            this.TxtBilan.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBilan.Name = "TxtBilan";
            this.TxtBilan.Size = new System.Drawing.Size(179, 20);
            this.TxtBilan.TabIndex = 0;
            // 
            // GbxAjoutRap
            // 
            this.GbxAjoutRap.Controls.Add(this.label6);
            this.GbxAjoutRap.Controls.Add(this.NumUpDownQteMedic);
            this.GbxAjoutRap.Controls.Add(this.label5);
            this.GbxAjoutRap.Controls.Add(this.CbxNomMedic);
            this.GbxAjoutRap.Controls.Add(this.CbxMatriculeVis);
            this.GbxAjoutRap.Controls.Add(this.CbxNumPra);
            this.GbxAjoutRap.Controls.Add(this.label12);
            this.GbxAjoutRap.Controls.Add(this.label1);
            this.GbxAjoutRap.Controls.Add(this.RTxtBxMotif);
            this.GbxAjoutRap.Controls.Add(this.RTxtBxBilan);
            this.GbxAjoutRap.Controls.Add(this.label2);
            this.GbxAjoutRap.Controls.Add(this.BtnValiderAjout);
            this.GbxAjoutRap.Controls.Add(this.label3);
            this.GbxAjoutRap.Controls.Add(this.label4);
            this.GbxAjoutRap.Location = new System.Drawing.Point(662, 14);
            this.GbxAjoutRap.Margin = new System.Windows.Forms.Padding(2);
            this.GbxAjoutRap.Name = "GbxAjoutRap";
            this.GbxAjoutRap.Padding = new System.Windows.Forms.Padding(2);
            this.GbxAjoutRap.Size = new System.Drawing.Size(241, 464);
            this.GbxAjoutRap.TabIndex = 8;
            this.GbxAjoutRap.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantité";
            // 
            // NumUpDownQteMedic
            // 
            this.NumUpDownQteMedic.Location = new System.Drawing.Point(63, 207);
            this.NumUpDownQteMedic.Name = "NumUpDownQteMedic";
            this.NumUpDownQteMedic.Size = new System.Drawing.Size(44, 20);
            this.NumUpDownQteMedic.TabIndex = 14;
            this.NumUpDownQteMedic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Médicament nom commercial";
            // 
            // CbxNomMedic
            // 
            this.CbxNomMedic.FormattingEnabled = true;
            this.CbxNomMedic.Location = new System.Drawing.Point(5, 180);
            this.CbxNomMedic.Name = "CbxNomMedic";
            this.CbxNomMedic.Size = new System.Drawing.Size(231, 21);
            this.CbxNomMedic.TabIndex = 12;
            // 
            // CbxMatriculeVis
            // 
            this.CbxMatriculeVis.FormattingEnabled = true;
            this.CbxMatriculeVis.Location = new System.Drawing.Point(5, 68);
            this.CbxMatriculeVis.Name = "CbxMatriculeVis";
            this.CbxMatriculeVis.Size = new System.Drawing.Size(231, 21);
            this.CbxMatriculeVis.TabIndex = 11;
            // 
            // CbxNumPra
            // 
            this.CbxNumPra.FormattingEnabled = true;
            this.CbxNumPra.Location = new System.Drawing.Point(5, 125);
            this.CbxNumPra.Name = "CbxNumPra";
            this.CbxNumPra.Size = new System.Drawing.Size(231, 21);
            this.CbxNumPra.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Numéro du Praticien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matricule du visiteur";
            // 
            // RTxtBxMotif
            // 
            this.RTxtBxMotif.Location = new System.Drawing.Point(51, 250);
            this.RTxtBxMotif.Name = "RTxtBxMotif";
            this.RTxtBxMotif.Size = new System.Drawing.Size(185, 70);
            this.RTxtBxMotif.TabIndex = 7;
            this.RTxtBxMotif.Text = "";
            // 
            // RTxtBxBilan
            // 
            this.RTxtBxBilan.Location = new System.Drawing.Point(52, 326);
            this.RTxtBxBilan.Name = "RTxtBxBilan";
            this.RTxtBxBilan.Size = new System.Drawing.Size(185, 96);
            this.RTxtBxBilan.TabIndex = 6;
            this.RTxtBxBilan.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ajouter un rapport";
            // 
            // BtnValiderAjout
            // 
            this.BtnValiderAjout.Location = new System.Drawing.Point(85, 427);
            this.BtnValiderAjout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnValiderAjout.Name = "BtnValiderAjout";
            this.BtnValiderAjout.Size = new System.Drawing.Size(73, 33);
            this.BtnValiderAjout.TabIndex = 4;
            this.BtnValiderAjout.Text = "Valider";
            this.BtnValiderAjout.UseVisualStyleBackColor = true;
            this.BtnValiderAjout.Click += new System.EventHandler(this.BtnValiderAjout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Motif :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bilan :";
            // 
            // lblNbRapportsTxt
            // 
            this.lblNbRapportsTxt.AutoSize = true;
            this.lblNbRapportsTxt.Font = new System.Drawing.Font("Consolas", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbRapportsTxt.Location = new System.Drawing.Point(11, 154);
            this.lblNbRapportsTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbRapportsTxt.Name = "lblNbRapportsTxt";
            this.lblNbRapportsTxt.Size = new System.Drawing.Size(262, 24);
            this.lblNbRapportsTxt.TabIndex = 9;
            this.lblNbRapportsTxt.Text = "Nombre de rapports : ";
            // 
            // LblNbRapport
            // 
            this.LblNbRapport.AutoSize = true;
            this.LblNbRapport.Location = new System.Drawing.Point(146, 231);
            this.LblNbRapport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNbRapport.Name = "LblNbRapport";
            this.LblNbRapport.Size = new System.Drawing.Size(0, 15);
            this.LblNbRapport.TabIndex = 10;
            // 
            // LblNbRapports
            // 
            this.LblNbRapports.AutoSize = true;
            this.LblNbRapports.Font = new System.Drawing.Font("Consolas", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNbRapports.Location = new System.Drawing.Point(277, 150);
            this.LblNbRapports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNbRapports.Name = "LblNbRapports";
            this.LblNbRapports.Size = new System.Drawing.Size(30, 32);
            this.LblNbRapports.TabIndex = 11;
            this.LblNbRapports.Text = "0";
            // 
            // FrmModificationsRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 523);
            this.ControlBox = false;
            this.Controls.Add(this.LblNbRapports);
            this.Controls.Add(this.LblNbRapport);
            this.Controls.Add(this.lblNbRapportsTxt);
            this.Controls.Add(this.GbxAjoutRap);
            this.Controls.Add(this.GbxModification);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.rtxtAide);
            this.Controls.Add(this.dtgListeRapport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmModificationsRapports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification rapports";
            this.Load += new System.EventHandler(this.FrmModificationsRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeRapport)).EndInit();
            this.GbxModification.ResumeLayout(false);
            this.GbxModification.PerformLayout();
            this.GbxAjoutRap.ResumeLayout(false);
            this.GbxAjoutRap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownQteMedic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListeRapport;
        private System.Windows.Forms.RichTextBox rtxtAide;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox GbxModification;
        private System.Windows.Forms.Label LblMessageModif;
        private System.Windows.Forms.Label LblModification;
        private System.Windows.Forms.Button BtnConfirmer;
        private System.Windows.Forms.Label LblMotif;
        private System.Windows.Forms.Label LblBilan;
        private System.Windows.Forms.TextBox TxtMotif;
        private System.Windows.Forms.TextBox TxtBilan;
        private System.Windows.Forms.GroupBox GbxAjoutRap;
        private System.Windows.Forms.ComboBox CbxMatriculeVis;
        private System.Windows.Forms.ComboBox CbxNumPra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTxtBxMotif;
        private System.Windows.Forms.RichTextBox RTxtBxBilan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnValiderAjout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNbRapportsTxt;
        private System.Windows.Forms.Label LblNbRapport;
        private System.Windows.Forms.Label LblNbRapports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxNomMedic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumUpDownQteMedic;
    }
}