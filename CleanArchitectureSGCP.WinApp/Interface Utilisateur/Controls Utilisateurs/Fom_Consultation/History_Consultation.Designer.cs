namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Fom_Consultation
{
    partial class History_Consultation
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Consultation));
            panel_Titre = new Panel();
            lbl_GestionPatient = new Label();
            toolTip = new ToolTip(components);
            btn_fermer = new Button();
            pannell_bas_page = new Panel();
            panelBoutons = new Panel();
            panel_List = new Panel();
            panel3 = new Panel();
            dtgConsultationHistorytList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Motif = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Observation = new DataGridViewTextBoxColumn();
            Diagnostic = new DataGridViewTextBoxColumn();
            DossierId = new DataGridViewTextBoxColumn();
            SessionId = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            TxtCourriel = new Label();
            TxtNom = new Label();
            TxtPrenom = new Label();
            TxtTelephone = new Label();
            TxtDate = new Label();
            TxtAddresse = new Label();
            label_Detail_Patient = new Label();
            labelCourriel = new Label();
            label_nom = new Label();
            labelPrenom = new Label();
            labelTelephone = new Label();
            labelDateNaiss = new Label();
            labelAdresse = new Label();
            patientBindingSource = new BindingSource(components);
            panel_Titre.SuspendLayout();
            pannell_bas_page.SuspendLayout();
            panelBoutons.SuspendLayout();
            panel_List.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgConsultationHistorytList).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_Titre
            // 
            panel_Titre.BackColor = Color.FromArgb(255, 255, 255);
            panel_Titre.Controls.Add(lbl_GestionPatient);
            panel_Titre.Dock = DockStyle.Top;
            panel_Titre.Location = new Point(20, 60);
            panel_Titre.Name = "panel_Titre";
            panel_Titre.Size = new Size(767, 40);
            panel_Titre.TabIndex = 4;
            // 
            // lbl_GestionPatient
            // 
            lbl_GestionPatient.Dock = DockStyle.Fill;
            lbl_GestionPatient.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_GestionPatient.Location = new Point(0, 0);
            lbl_GestionPatient.Name = "lbl_GestionPatient";
            lbl_GestionPatient.Size = new Size(767, 40);
            lbl_GestionPatient.TabIndex = 0;
            lbl_GestionPatient.Text = "Historique des consultations";
            lbl_GestionPatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;
            // 
            // btn_fermer
            // 
            btn_fermer.BackColor = Color.FromArgb(255, 82, 82);
            btn_fermer.FlatAppearance.BorderSize = 0;
            btn_fermer.FlatStyle = FlatStyle.Flat;
            btn_fermer.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_fermer.ForeColor = Color.White;
            btn_fermer.Image = (Image)resources.GetObject("btn_fermer.Image");
            btn_fermer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fermer.Location = new Point(20, 6);
            btn_fermer.Name = "btn_fermer";
            btn_fermer.Size = new Size(107, 35);
            btn_fermer.TabIndex = 1;
            btn_fermer.Text = "Fermer";
            btn_fermer.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_fermer, "Cliquez ici pour enregistrer l'ajout de la nouvelle consultation.");
            btn_fermer.UseVisualStyleBackColor = false;
            btn_fermer.Click += btn_fermer_Click;
            // 
            // pannell_bas_page
            // 
            pannell_bas_page.BackColor = Color.White;
            pannell_bas_page.Controls.Add(panelBoutons);
            pannell_bas_page.Dock = DockStyle.Bottom;
            pannell_bas_page.Location = new Point(20, 644);
            pannell_bas_page.Name = "pannell_bas_page";
            pannell_bas_page.Size = new Size(767, 43);
            pannell_bas_page.TabIndex = 1;
            // 
            // panelBoutons
            // 
            panelBoutons.BackColor = Color.White;
            panelBoutons.Controls.Add(btn_fermer);
            panelBoutons.Dock = DockStyle.Right;
            panelBoutons.Location = new Point(637, 0);
            panelBoutons.Name = "panelBoutons";
            panelBoutons.Size = new Size(130, 43);
            panelBoutons.TabIndex = 3;
            // 
            // panel_List
            // 
            panel_List.Controls.Add(panel3);
            panel_List.Controls.Add(panel2);
            panel_List.Controls.Add(panel1);
            panel_List.Dock = DockStyle.Fill;
            panel_List.Location = new Point(20, 100);
            panel_List.Name = "panel_List";
            panel_List.Size = new Size(767, 544);
            panel_List.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgConsultationHistorytList);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(767, 379);
            panel3.TabIndex = 3;
            // 
            // dtgConsultationHistorytList
            // 
            dtgConsultationHistorytList.AllowUserToAddRows = false;
            dtgConsultationHistorytList.AllowUserToDeleteRows = false;
            dtgConsultationHistorytList.BackgroundColor = Color.White;
            dtgConsultationHistorytList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgConsultationHistorytList.Columns.AddRange(new DataGridViewColumn[] { Id, Motif, Date, Observation, Diagnostic, DossierId, SessionId });
            dtgConsultationHistorytList.Dock = DockStyle.Fill;
            dtgConsultationHistorytList.GridColor = Color.WhiteSmoke;
            dtgConsultationHistorytList.Location = new Point(0, 0);
            dtgConsultationHistorytList.Name = "dtgConsultationHistorytList";
            dtgConsultationHistorytList.ReadOnly = true;
            dtgConsultationHistorytList.Size = new Size(767, 379);
            dtgConsultationHistorytList.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Motif
            // 
            Motif.DataPropertyName = "Motif";
            Motif.HeaderText = "Motif";
            Motif.Name = "Motif";
            Motif.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Observation
            // 
            Observation.DataPropertyName = "Observation";
            Observation.HeaderText = "Observation";
            Observation.Name = "Observation";
            Observation.ReadOnly = true;
            // 
            // Diagnostic
            // 
            Diagnostic.DataPropertyName = "Diagnostic";
            Diagnostic.HeaderText = "Diagnostic";
            Diagnostic.Name = "Diagnostic";
            Diagnostic.ReadOnly = true;
            // 
            // DossierId
            // 
            DossierId.DataPropertyName = "DossierMedicalId";
            DossierId.HeaderText = "DossierId";
            DossierId.Name = "DossierId";
            DossierId.ReadOnly = true;
            DossierId.Visible = false;
            // 
            // SessionId
            // 
            SessionId.DataPropertyName = "SessionId";
            SessionId.HeaderText = "SessionIdSessionId";
            SessionId.Name = "SessionId";
            SessionId.ReadOnly = true;
            SessionId.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 33);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 3);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 22;
            label1.Text = "Liste des consultations";
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtCourriel);
            panel1.Controls.Add(TxtNom);
            panel1.Controls.Add(TxtPrenom);
            panel1.Controls.Add(TxtTelephone);
            panel1.Controls.Add(TxtDate);
            panel1.Controls.Add(TxtAddresse);
            panel1.Controls.Add(label_Detail_Patient);
            panel1.Controls.Add(labelCourriel);
            panel1.Controls.Add(label_nom);
            panel1.Controls.Add(labelPrenom);
            panel1.Controls.Add(labelTelephone);
            panel1.Controls.Add(labelDateNaiss);
            panel1.Controls.Add(labelAdresse);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 132);
            panel1.TabIndex = 1;
            // 
            // TxtCourriel
            // 
            TxtCourriel.AutoSize = true;
            TxtCourriel.BackColor = Color.Transparent;
            TxtCourriel.Font = new Font("Segoe UI", 9.75F);
            TxtCourriel.ForeColor = Color.Black;
            TxtCourriel.Location = new Point(614, 45);
            TxtCourriel.Name = "TxtCourriel";
            TxtCourriel.Size = new Size(54, 17);
            TxtCourriel.TabIndex = 27;
            TxtCourriel.Text = "Courriel";
            TxtCourriel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNom
            // 
            TxtNom.AutoSize = true;
            TxtNom.BackColor = Color.Transparent;
            TxtNom.Font = new Font("Segoe UI", 9.75F);
            TxtNom.ForeColor = Color.Black;
            TxtNom.Location = new Point(73, 45);
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new Size(34, 17);
            TxtNom.TabIndex = 22;
            TxtNom.Text = "nom";
            TxtNom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtPrenom
            // 
            TxtPrenom.AutoSize = true;
            TxtPrenom.BackColor = Color.Transparent;
            TxtPrenom.Font = new Font("Segoe UI", 9.75F);
            TxtPrenom.ForeColor = Color.Black;
            TxtPrenom.Location = new Point(73, 95);
            TxtPrenom.Name = "TxtPrenom";
            TxtPrenom.Size = new Size(53, 17);
            TxtPrenom.TabIndex = 23;
            TxtPrenom.Text = "Prénom";
            TxtPrenom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtTelephone
            // 
            TxtTelephone.AutoSize = true;
            TxtTelephone.BackColor = Color.Transparent;
            TxtTelephone.Font = new Font("Segoe UI", 9.75F);
            TxtTelephone.ForeColor = Color.Black;
            TxtTelephone.Location = new Point(371, 95);
            TxtTelephone.Name = "TxtTelephone";
            TxtTelephone.Size = new Size(68, 17);
            TxtTelephone.TabIndex = 26;
            TxtTelephone.Text = "Téléphone";
            TxtTelephone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtDate
            // 
            TxtDate.AutoSize = true;
            TxtDate.BackColor = Color.Transparent;
            TxtDate.Font = new Font("Segoe UI", 9.75F);
            TxtDate.ForeColor = Color.Black;
            TxtDate.Location = new Point(371, 45);
            TxtDate.Name = "TxtDate";
            TxtDate.Size = new Size(114, 17);
            TxtDate.TabIndex = 25;
            TxtDate.Text = "Date de naissance";
            TxtDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtAddresse
            // 
            TxtAddresse.AutoSize = true;
            TxtAddresse.BackColor = Color.Transparent;
            TxtAddresse.Font = new Font("Segoe UI", 9.75F);
            TxtAddresse.ForeColor = Color.Black;
            TxtAddresse.Location = new Point(614, 95);
            TxtAddresse.Name = "TxtAddresse";
            TxtAddresse.Size = new Size(63, 17);
            TxtAddresse.TabIndex = 24;
            TxtAddresse.Text = "Addresse";
            TxtAddresse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Detail_Patient
            // 
            label_Detail_Patient.AutoSize = true;
            label_Detail_Patient.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Detail_Patient.Location = new Point(9, 4);
            label_Detail_Patient.Name = "label_Detail_Patient";
            label_Detail_Patient.Size = new Size(125, 25);
            label_Detail_Patient.TabIndex = 14;
            label_Detail_Patient.Text = "Fiche patient";
            // 
            // labelCourriel
            // 
            labelCourriel.AutoSize = true;
            labelCourriel.BackColor = Color.Transparent;
            labelCourriel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelCourriel.ForeColor = Color.Black;
            labelCourriel.Location = new Point(550, 45);
            labelCourriel.Name = "labelCourriel";
            labelCourriel.Size = new Size(62, 17);
            labelCourriel.TabIndex = 20;
            labelCourriel.Text = "Courriel :";
            labelCourriel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.BackColor = Color.Transparent;
            label_nom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_nom.ForeColor = Color.Black;
            label_nom.Location = new Point(9, 45);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(45, 17);
            label_nom.TabIndex = 15;
            label_nom.Text = "Nom :";
            label_nom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.BackColor = Color.Transparent;
            labelPrenom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelPrenom.ForeColor = Color.Black;
            labelPrenom.Location = new Point(9, 95);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(63, 17);
            labelPrenom.TabIndex = 16;
            labelPrenom.Text = "Prénom :";
            labelPrenom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.BackColor = Color.Transparent;
            labelTelephone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelTelephone.ForeColor = Color.Black;
            labelTelephone.Location = new Point(248, 95);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(81, 17);
            labelTelephone.TabIndex = 19;
            labelTelephone.Text = "Téléphone : ";
            labelTelephone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDateNaiss
            // 
            labelDateNaiss.AutoSize = true;
            labelDateNaiss.BackColor = Color.Transparent;
            labelDateNaiss.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelDateNaiss.ForeColor = Color.Black;
            labelDateNaiss.Location = new Point(248, 45);
            labelDateNaiss.Name = "labelDateNaiss";
            labelDateNaiss.Size = new Size(124, 17);
            labelDateNaiss.TabIndex = 18;
            labelDateNaiss.Text = "Date de naissance :";
            labelDateNaiss.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.BackColor = Color.Transparent;
            labelAdresse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelAdresse.ForeColor = Color.Black;
            labelAdresse.Location = new Point(550, 95);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(59, 17);
            labelAdresse.TabIndex = 17;
            labelAdresse.Text = "Adresse:";
            labelAdresse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // History_Consultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 707);
            Controls.Add(panel_List);
            Controls.Add(pannell_bas_page);
            Controls.Add(panel_Titre);
            Name = "History_Consultation";
            panel_Titre.ResumeLayout(false);
            pannell_bas_page.ResumeLayout(false);
            panelBoutons.ResumeLayout(false);
            panel_List.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgConsultationHistorytList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ResumeLayout(false);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            // Style général
            dgv.BackgroundColor = Color.White;
            //dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;

            // En-tête de colonnes
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Style des lignes
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false; // Masquer les en-têtes de ligne


            // Style des lignes alternées (zebra effect)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Taille des lignes
            dgv.RowTemplate.Height = 30;

            // Style de la bordure
            dgv.GridColor = Color.LightGray;

            // Alignement des cellules
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Bordures arrondies (optionnel si compatible)
            dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.OutsetDouble;

            // Suppression de l'affichage de la ligne d'ajout
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
        }

        #endregion

        private Panel panel_Titre;
        private Panel pannell_bas_page;
        private Panel panel_List;
        private Label lbl_GestionPatient;
        private DataGridView dtgConsultationHistorytList;
        private BindingSource patientBindingSource;
        private Panel panelBoutons;
        private ToolTip toolTip;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label TxtCourriel;
        private Label TxtNom;
        private Label TxtPrenom;
        private Label TxtTelephone;
        private Label TxtDate;
        private Label TxtAddresse;
        private Label label_Detail_Patient;
        private Label labelCourriel;
        private Label label_nom;
        private Label labelPrenom;
        private Label labelTelephone;
        private Label labelDateNaiss;
        private Label labelAdresse;
        private Button btn_fermer;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Motif;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Observation;
        private DataGridViewTextBoxColumn Diagnostic;
        private DataGridViewTextBoxColumn DossierId;
        private DataGridViewTextBoxColumn SessionId;
    }
}