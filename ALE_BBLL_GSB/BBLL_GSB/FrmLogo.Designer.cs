namespace BBLL_GSB
{
    partial class FrmLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogo));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.BtnConsulteRapports = new System.Windows.Forms.Button();
            this.BtnConsulteArchives = new System.Windows.Forms.Button();
            this.BtnConsulteVisiteurs = new System.Windows.Forms.Button();
            this.BtnGererRapports = new System.Windows.Forms.Button();
            this.BtnConsultePraticien = new System.Windows.Forms.Button();
            this.BtnConsulteMedic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 11);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(257, 216);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitter.Font = new System.Drawing.Font("Consolas", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitter.Location = new System.Drawing.Point(0, 643);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(129, 44);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter l\'application";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitterVisite_Click);
            // 
            // BtnConsulteRapports
            // 
            this.BtnConsulteRapports.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnConsulteRapports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConsulteRapports.Font = new System.Drawing.Font("Consolas", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulteRapports.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConsulteRapports.Location = new System.Drawing.Point(0, 387);
            this.BtnConsulteRapports.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsulteRapports.Name = "BtnConsulteRapports";
            this.BtnConsulteRapports.Size = new System.Drawing.Size(216, 58);
            this.BtnConsulteRapports.TabIndex = 10;
            this.BtnConsulteRapports.Text = "Consulter les rapports";
            this.BtnConsulteRapports.UseVisualStyleBackColor = false;
            this.BtnConsulteRapports.Click += new System.EventHandler(this.BtnConsulteRapports_Click);
            // 
            // BtnConsulteArchives
            // 
            this.BtnConsulteArchives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnConsulteArchives.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConsulteArchives.Font = new System.Drawing.Font("Consolas", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulteArchives.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConsulteArchives.Location = new System.Drawing.Point(0, 581);
            this.BtnConsulteArchives.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsulteArchives.Name = "BtnConsulteArchives";
            this.BtnConsulteArchives.Size = new System.Drawing.Size(216, 58);
            this.BtnConsulteArchives.TabIndex = 11;
            this.BtnConsulteArchives.Text = "Consulter les archives";
            this.BtnConsulteArchives.UseVisualStyleBackColor = false;
            this.BtnConsulteArchives.Click += new System.EventHandler(this.BtnConsulteArchives_Click);
            // 
            // BtnConsulteVisiteurs
            // 
            this.BtnConsulteVisiteurs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnConsulteVisiteurs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConsulteVisiteurs.Font = new System.Drawing.Font("Consolas", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulteVisiteurs.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConsulteVisiteurs.Location = new System.Drawing.Point(0, 336);
            this.BtnConsulteVisiteurs.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsulteVisiteurs.Name = "BtnConsulteVisiteurs";
            this.BtnConsulteVisiteurs.Size = new System.Drawing.Size(216, 56);
            this.BtnConsulteVisiteurs.TabIndex = 12;
            this.BtnConsulteVisiteurs.Text = "Consulter la liste des visiteurs";
            this.BtnConsulteVisiteurs.UseVisualStyleBackColor = false;
            this.BtnConsulteVisiteurs.Click += new System.EventHandler(this.BtnConsulteVisiteurs_Click);
            // 
            // BtnGererRapports
            // 
            this.BtnGererRapports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGererRapports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGererRapports.Font = new System.Drawing.Font("Consolas", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGererRapports.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGererRapports.Location = new System.Drawing.Point(0, 252);
            this.BtnGererRapports.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGererRapports.Name = "BtnGererRapports";
            this.BtnGererRapports.Size = new System.Drawing.Size(216, 58);
            this.BtnGererRapports.TabIndex = 13;
            this.BtnGererRapports.Text = "Gérer les rapports";
            this.BtnGererRapports.UseVisualStyleBackColor = false;
            this.BtnGererRapports.Click += new System.EventHandler(this.BtnGererRapports_Click);
            // 
            // BtnConsultePraticien
            // 
            this.BtnConsultePraticien.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnConsultePraticien.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConsultePraticien.Font = new System.Drawing.Font("Consolas", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultePraticien.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConsultePraticien.Location = new System.Drawing.Point(0, 449);
            this.BtnConsultePraticien.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsultePraticien.Name = "BtnConsultePraticien";
            this.BtnConsultePraticien.Size = new System.Drawing.Size(216, 58);
            this.BtnConsultePraticien.TabIndex = 14;
            this.BtnConsultePraticien.Text = "Consulter les praticiens";
            this.BtnConsultePraticien.UseVisualStyleBackColor = false;
            this.BtnConsultePraticien.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnConsulteMedic
            // 
            this.BtnConsulteMedic.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnConsulteMedic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConsulteMedic.Font = new System.Drawing.Font("Consolas", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulteMedic.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConsulteMedic.Location = new System.Drawing.Point(0, 501);
            this.BtnConsulteMedic.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsulteMedic.Name = "BtnConsulteMedic";
            this.BtnConsulteMedic.Size = new System.Drawing.Size(216, 58);
            this.BtnConsulteMedic.TabIndex = 15;
            this.BtnConsulteMedic.Text = "Consulter les médicaments";
            this.BtnConsulteMedic.UseVisualStyleBackColor = false;
            this.BtnConsulteMedic.Click += new System.EventHandler(this.BtnConsulteMedic_Click);
            // 
            // FrmLogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(288, 706);
            this.ControlBox = false;
            this.Controls.Add(this.BtnConsulteMedic);
            this.Controls.Add(this.BtnConsultePraticien);
            this.Controls.Add(this.BtnGererRapports);
            this.Controls.Add(this.BtnConsulteVisiteurs);
            this.Controls.Add(this.BtnConsulteArchives);
            this.Controls.Add(this.BtnConsulteRapports);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pbxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmLogo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button BtnConsulteRapports;
        private System.Windows.Forms.Button BtnConsulteArchives;
        private System.Windows.Forms.Button BtnConsulteVisiteurs;
        private System.Windows.Forms.Button BtnGererRapports;
        private System.Windows.Forms.Button BtnConsultePraticien;
        private System.Windows.Forms.Button BtnConsulteMedic;
    }
}