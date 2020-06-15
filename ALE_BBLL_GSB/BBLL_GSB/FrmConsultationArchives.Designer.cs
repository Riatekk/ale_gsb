namespace BBLL_GSB
{
    partial class FrmConsultationArchives
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpBoxRechercheTT = new System.Windows.Forms.GroupBox();
            this.DtgListeRapMedoc = new System.Windows.Forms.DataGridView();
            this.DtgListeRapport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpBoxRechercheDate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtgListeRapMedocDate = new System.Windows.Forms.DataGridView();
            this.CalDate = new System.Windows.Forms.MonthCalendar();
            this.DtgListeRapportDate = new System.Windows.Forms.DataGridView();
            this.BtnRecherche = new System.Windows.Forms.Button();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GrpBoxRechercheTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeRapMedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeRapport)).BeginInit();
            this.GrpBoxRechercheDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeRapMedocDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeRapportDate)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxRechercheTT
            // 
            this.GrpBoxRechercheTT.Controls.Add(this.DtgListeRapMedoc);
            this.GrpBoxRechercheTT.Controls.Add(this.DtgListeRapport);
            this.GrpBoxRechercheTT.Controls.Add(this.label2);
            this.GrpBoxRechercheTT.Location = new System.Drawing.Point(6, 73);
            this.GrpBoxRechercheTT.Name = "GrpBoxRechercheTT";
            this.GrpBoxRechercheTT.Size = new System.Drawing.Size(917, 384);
            this.GrpBoxRechercheTT.TabIndex = 1;
            this.GrpBoxRechercheTT.TabStop = false;
            this.GrpBoxRechercheTT.Text = "Liste des compte rendus archivés";
            this.GrpBoxRechercheTT.Visible = false;
            // 
            // DtgListeRapMedoc
            // 
            this.DtgListeRapMedoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtgListeRapMedoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtgListeRapMedoc.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.DtgListeRapMedoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtgListeRapMedoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgListeRapMedoc.DefaultCellStyle = dataGridViewCellStyle9;
            this.DtgListeRapMedoc.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtgListeRapMedoc.Location = new System.Drawing.Point(6, 227);
            this.DtgListeRapMedoc.Name = "DtgListeRapMedoc";
            this.DtgListeRapMedoc.ReadOnly = true;
            this.DtgListeRapMedoc.Size = new System.Drawing.Size(905, 151);
            this.DtgListeRapMedoc.TabIndex = 5;
            // 
            // DtgListeRapport
            // 
            this.DtgListeRapport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtgListeRapport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtgListeRapport.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.DtgListeRapport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtgListeRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgListeRapport.DefaultCellStyle = dataGridViewCellStyle10;
            this.DtgListeRapport.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtgListeRapport.Location = new System.Drawing.Point(6, 19);
            this.DtgListeRapport.Name = "DtgListeRapport";
            this.DtgListeRapport.ReadOnly = true;
            this.DtgListeRapport.Size = new System.Drawing.Size(905, 169);
            this.DtgListeRapport.TabIndex = 4;
            this.DtgListeRapport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListeRapport_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Les medicaments concernés";
            // 
            // GrpBoxRechercheDate
            // 
            this.GrpBoxRechercheDate.Controls.Add(this.label1);
            this.GrpBoxRechercheDate.Controls.Add(this.DtgListeRapMedocDate);
            this.GrpBoxRechercheDate.Controls.Add(this.CalDate);
            this.GrpBoxRechercheDate.Controls.Add(this.DtgListeRapportDate);
            this.GrpBoxRechercheDate.Location = new System.Drawing.Point(6, 73);
            this.GrpBoxRechercheDate.Name = "GrpBoxRechercheDate";
            this.GrpBoxRechercheDate.Size = new System.Drawing.Size(917, 384);
            this.GrpBoxRechercheDate.TabIndex = 2;
            this.GrpBoxRechercheDate.TabStop = false;
            this.GrpBoxRechercheDate.Text = "Liste des compte rendus archivés par date de visite";
            this.GrpBoxRechercheDate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Les medicaments concernés";
            // 
            // DtgListeRapMedocDate
            // 
            this.DtgListeRapMedocDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtgListeRapMedocDate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtgListeRapMedocDate.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.DtgListeRapMedocDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtgListeRapMedocDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgListeRapMedocDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.DtgListeRapMedocDate.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtgListeRapMedocDate.Location = new System.Drawing.Point(265, 213);
            this.DtgListeRapMedocDate.Name = "DtgListeRapMedocDate";
            this.DtgListeRapMedocDate.ReadOnly = true;
            this.DtgListeRapMedocDate.Size = new System.Drawing.Size(646, 151);
            this.DtgListeRapMedocDate.TabIndex = 2;
            // 
            // CalDate
            // 
            this.CalDate.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.CalDate.Location = new System.Drawing.Point(12, 19);
            this.CalDate.Name = "CalDate";
            this.CalDate.TabIndex = 1;
            this.CalDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // DtgListeRapportDate
            // 
            this.DtgListeRapportDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtgListeRapportDate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtgListeRapportDate.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.DtgListeRapportDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtgListeRapportDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgListeRapportDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.DtgListeRapportDate.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtgListeRapportDate.Location = new System.Drawing.Point(265, 19);
            this.DtgListeRapportDate.Name = "DtgListeRapportDate";
            this.DtgListeRapportDate.ReadOnly = true;
            this.DtgListeRapportDate.Size = new System.Drawing.Size(646, 151);
            this.DtgListeRapportDate.TabIndex = 0;
            this.DtgListeRapportDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListeRapportDate_CellClick);
            // 
            // BtnRecherche
            // 
            this.BtnRecherche.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRecherche.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRecherche.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecherche.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRecherche.Location = new System.Drawing.Point(322, 11);
            this.BtnRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRecherche.Name = "BtnRecherche";
            this.BtnRecherche.Size = new System.Drawing.Size(284, 37);
            this.BtnRecherche.TabIndex = 3;
            this.BtnRecherche.Text = "Rechercher";
            this.BtnRecherche.UseVisualStyleBackColor = false;
            this.BtnRecherche.Click += new System.EventHandler(this.BtnRecherche_Click);
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnFermer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFermer.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFermer.Location = new System.Drawing.Point(844, 476);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(85, 35);
            this.BtnFermer.TabIndex = 4;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.82178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Archives";
            // 
            // FrmConsultationArchives
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(941, 523);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrpBoxRechercheDate);
            this.Controls.Add(this.BtnRecherche);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.GrpBoxRechercheTT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmConsultationArchives";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultationCompteRendus";
            this.Load += new System.EventHandler(this.FrmConsultationCompteRendus_Load);
            this.GrpBoxRechercheTT.ResumeLayout(false);
            this.GrpBoxRechercheTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeRapMedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeRapport)).EndInit();
            this.GrpBoxRechercheDate.ResumeLayout(false);
            this.GrpBoxRechercheDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeRapMedocDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeRapportDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxRechercheTT;
        private System.Windows.Forms.GroupBox GrpBoxRechercheDate;
        private System.Windows.Forms.MonthCalendar CalDate;
        private System.Windows.Forms.DataGridView DtgListeRapportDate;
        private System.Windows.Forms.Button BtnRecherche;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.DataGridView DtgListeRapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgListeRapMedocDate;
        private System.Windows.Forms.DataGridView DtgListeRapMedoc;
        private System.Windows.Forms.Label label3;
    }
}