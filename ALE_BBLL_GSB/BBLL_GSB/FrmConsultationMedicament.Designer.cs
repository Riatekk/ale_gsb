namespace BBLL_GSB
{
    partial class FrmConsultationMedicament
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.GrpBoxRechercheDate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtgListePraticiens = new System.Windows.Forms.DataGridView();
            this.DtgListeMedicament = new System.Windows.Forms.DataGridView();
            this.lblNbMedicament = new System.Windows.Forms.Label();
            this.GrpBoxRechercheDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListePraticiens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnFermer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFermer.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFermer.Location = new System.Drawing.Point(844, 402);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(85, 35);
            this.BtnFermer.TabIndex = 4;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // GrpBoxRechercheDate
            // 
            this.GrpBoxRechercheDate.Controls.Add(this.label1);
            this.GrpBoxRechercheDate.Controls.Add(this.DtgListePraticiens);
            this.GrpBoxRechercheDate.Controls.Add(this.DtgListeMedicament);
            this.GrpBoxRechercheDate.Location = new System.Drawing.Point(12, 12);
            this.GrpBoxRechercheDate.Name = "GrpBoxRechercheDate";
            this.GrpBoxRechercheDate.Size = new System.Drawing.Size(702, 384);
            this.GrpBoxRechercheDate.TabIndex = 2;
            this.GrpBoxRechercheDate.TabStop = false;
            this.GrpBoxRechercheDate.Text = "Liste des médicament offert aux praticiens";
            this.GrpBoxRechercheDate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Les praticiens concernés";
            // 
            // DtgListePraticiens
            // 
            this.DtgListePraticiens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtgListePraticiens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtgListePraticiens.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.DtgListePraticiens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtgListePraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgListePraticiens.DefaultCellStyle = dataGridViewCellStyle1;
            this.DtgListePraticiens.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtgListePraticiens.Location = new System.Drawing.Point(6, 227);
            this.DtgListePraticiens.Name = "DtgListePraticiens";
            this.DtgListePraticiens.ReadOnly = true;
            this.DtgListePraticiens.Size = new System.Drawing.Size(688, 151);
            this.DtgListePraticiens.TabIndex = 2;
            // 
            // DtgListeMedicament
            // 
            this.DtgListeMedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtgListeMedicament.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtgListeMedicament.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.DtgListeMedicament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtgListeMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgListeMedicament.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgListeMedicament.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtgListeMedicament.Location = new System.Drawing.Point(6, 19);
            this.DtgListeMedicament.Name = "DtgListeMedicament";
            this.DtgListeMedicament.ReadOnly = true;
            this.DtgListeMedicament.Size = new System.Drawing.Size(688, 151);
            this.DtgListeMedicament.TabIndex = 0;
            this.DtgListeMedicament.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgListeMedicament_CellClick);
            // 
            // lblNbMedicament
            // 
            this.lblNbMedicament.AutoSize = true;
            this.lblNbMedicament.Font = new System.Drawing.Font("Consolas", 14.25743F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbMedicament.Location = new System.Drawing.Point(731, 9);
            this.lblNbMedicament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbMedicament.Name = "lblNbMedicament";
            this.lblNbMedicament.Size = new System.Drawing.Size(250, 24);
            this.lblNbMedicament.TabIndex = 5;
            this.lblNbMedicament.Text = "Nombre de médicament";
            this.lblNbMedicament.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmConsultationMedicament
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(992, 445);
            this.ControlBox = false;
            this.Controls.Add(this.lblNbMedicament);
            this.Controls.Add(this.GrpBoxRechercheDate);
            this.Controls.Add(this.BtnFermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmConsultationMedicament";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultationCompteRendus";
            this.Load += new System.EventHandler(this.FrmConsultationCompteRendus_Load);
            this.GrpBoxRechercheDate.ResumeLayout(false);
            this.GrpBoxRechercheDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListePraticiens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.GroupBox GrpBoxRechercheDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgListePraticiens;
        private System.Windows.Forms.DataGridView DtgListeMedicament;
        private System.Windows.Forms.Label lblNbMedicament;
    }
}