using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Patient;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Form_Prescription
{
    partial class Form_gestion_Prescription
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_gestion_Prescription));
            panel_Titre = new Panel();
            lbl_GestionPatient = new Label();
            panel_List = new Panel();
            tabControlGestionPrescription = new TabControl();
            tablistePatients = new TabPage();
            panel_principal = new Panel();
            dtgPatientList = new DataGridView();
            nom = new DataGridViewTextBoxColumn();
            Dossier = new DataGridViewTextBoxColumn();
            prenom = new DataGridViewTextBoxColumn();
            dateDeNaissance = new DataGridViewTextBoxColumn();
            adresse = new DataGridViewTextBoxColumn();
            telephone = new DataGridViewTextBoxColumn();
            courriel = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            panel_bouton = new Panel();
            panelBoutons = new Panel();
            btn_fermer = new Button();
            btn_consultation = new Button();
            panel_sub_tittle = new Panel();
            label1 = new Label();
            tabConsultation = new TabPage();
            panel4 = new Panel();
            panel3 = new Panel();
            dtgConsultationHistorytList = new DataGridView();
            IDConsultation = new DataGridViewTextBoxColumn();
            Motif = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Observation = new DataGridViewTextBoxColumn();
            Diagnostic = new DataGridViewTextBoxColumn();
            DossierMedicalId = new DataGridViewTextBoxColumn();
            SessionId = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label2 = new Label();
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
            pannell_bas_page = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            btn_prescriptions = new Button();
            tabPrescription = new TabPage();
            dtgListePrescription = new DataGridView();
            IDE = new DataGridViewTextBoxColumn();
            Medicament = new DataGridViewTextBoxColumn();
            Dosage = new DataGridViewTextBoxColumn();
            Instruction = new DataGridViewTextBoxColumn();
            Duree = new DataGridViewTextBoxColumn();
            ConsultationId = new DataGridViewTextBoxColumn();
            etat = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            panel8 = new Panel();
            button2 = new Button();
            btn_ajouter_prescription = new Button();
            btn_cloturer_prescription = new Button();
            btn_consulter_prescription = new Button();
            panel6 = new Panel();
            label3 = new Label();
            panel_consultation_prescription = new Panel();
            TxtDateConsultation = new Label();
            TxtDiagnostic = new Label();
            TxtObservation = new Label();
            TxtMotif = new Label();
            label9 = new Label();
            label_Date = new Label();
            label_observation = new Label();
            label_ob = new Label();
            lable_Motif = new Label();
            patientBindingSource = new BindingSource(components);
            toolTip = new ToolTip(components);
            bindingSource1 = new BindingSource(components);
            toolTip1 = new ToolTip(components);
            test = new DataGridViewTextBoxColumn();
            panel_Titre.SuspendLayout();
            panel_List.SuspendLayout();
            tabControlGestionPrescription.SuspendLayout();
            tablistePatients.SuspendLayout();
            panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPatientList).BeginInit();
            panel_bouton.SuspendLayout();
            panelBoutons.SuspendLayout();
            panel_sub_tittle.SuspendLayout();
            tabConsultation.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgConsultationHistorytList).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pannell_bas_page.SuspendLayout();
            panel5.SuspendLayout();
            tabPrescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListePrescription).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel_consultation_prescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel_Titre
            // 
            panel_Titre.BackColor = Color.FromArgb(255, 255, 255);
            panel_Titre.BorderStyle = BorderStyle.FixedSingle;
            panel_Titre.Controls.Add(lbl_GestionPatient);
            panel_Titre.Dock = DockStyle.Top;
            panel_Titre.Location = new Point(0, 0);
            panel_Titre.Name = "panel_Titre";
            panel_Titre.Size = new Size(1228, 40);
            panel_Titre.TabIndex = 4;
            // 
            // lbl_GestionPatient
            // 
            lbl_GestionPatient.Dock = DockStyle.Fill;
            lbl_GestionPatient.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_GestionPatient.Location = new Point(0, 0);
            lbl_GestionPatient.Name = "lbl_GestionPatient";
            lbl_GestionPatient.Size = new Size(1226, 38);
            lbl_GestionPatient.TabIndex = 0;
            lbl_GestionPatient.Text = "Gestion des Prescriptions";
            lbl_GestionPatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_List
            // 
            panel_List.Controls.Add(tabControlGestionPrescription);
            panel_List.Dock = DockStyle.Fill;
            panel_List.Location = new Point(0, 40);
            panel_List.Name = "panel_List";
            panel_List.Size = new Size(1228, 667);
            panel_List.TabIndex = 3;
            // 
            // tabControlGestionPrescription
            // 
            tabControlGestionPrescription.Appearance = TabAppearance.Buttons;
            tabControlGestionPrescription.Controls.Add(tablistePatients);
            tabControlGestionPrescription.Controls.Add(tabConsultation);
            tabControlGestionPrescription.Controls.Add(tabPrescription);
            tabControlGestionPrescription.Dock = DockStyle.Fill;
            tabControlGestionPrescription.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlGestionPrescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControlGestionPrescription.ItemSize = new Size(120, 30);
            tabControlGestionPrescription.Location = new Point(0, 0);
            tabControlGestionPrescription.Name = "tabControlGestionPrescription";
            tabControlGestionPrescription.SelectedIndex = 0;
            tabControlGestionPrescription.Size = new Size(1228, 667);
            tabControlGestionPrescription.SizeMode = TabSizeMode.Fixed;
            tabControlGestionPrescription.TabIndex = 0;
            tabControlGestionPrescription.DrawItem += TabControlGestionPrescription_DrawItem;
            tabControlGestionPrescription.Selecting += DisableTabConsultation;
            tabControlGestionPrescription.Selecting += DisableTabPrescription; 
            
            // 
            // tablistePatients
            // 
            tablistePatients.BackColor = Color.White;
            tablistePatients.Controls.Add(panel_principal);
            tablistePatients.Controls.Add(panel_bouton);
            tablistePatients.Controls.Add(panel_sub_tittle);
            tablistePatients.Location = new Point(4, 34);
            tablistePatients.Name = "tablistePatients";
            tablistePatients.Padding = new Padding(3);
            tablistePatients.Size = new Size(1220, 629);
            tablistePatients.TabIndex = 0;
            tablistePatients.Text = "Patients";
            // 
            // panel_principal
            // 
            panel_principal.Controls.Add(dtgPatientList);
            panel_principal.Dock = DockStyle.Fill;
            panel_principal.Location = new Point(3, 40);
            panel_principal.Name = "panel_principal";
            panel_principal.Size = new Size(1214, 544);
            panel_principal.TabIndex = 2;
            // 
            // dtgPatientList
            // 
            dtgPatientList.BackgroundColor = Color.White;
            dtgPatientList.BorderStyle = BorderStyle.Fixed3D;
            dtgPatientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPatientList.Columns.AddRange(new DataGridViewColumn[] { nom, Dossier, prenom, dateDeNaissance, adresse, telephone, courriel, ID });
            dtgPatientList.Dock = DockStyle.Fill;
            dtgPatientList.GridColor = Color.WhiteSmoke;
            dtgPatientList.Location = new Point(0, 0);
            dtgPatientList.MultiSelect = false;
            dtgPatientList.Name = "dtgPatientList";
            dtgPatientList.Size = new Size(1214, 544);
            dtgPatientList.TabIndex = 1;
            dtgPatientList.CellClick += dtgPaitentList_CellClick;
            // 
            // nom
            // 
            nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nom.DataPropertyName = "Nom";
            nom.HeaderText = "Nom";
            nom.Name = "nom";
            // 
            // Dossier
            // 
            Dossier.DataPropertyName = "DossierMedical";
            Dossier.HeaderText = "Dossier";
            Dossier.Name = "Dossier";
            Dossier.Visible = false;
            // 
            // prenom
            // 
            prenom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prenom.DataPropertyName = "Prenom";
            prenom.HeaderText = "Prénom";
            prenom.Name = "prenom";
            // 
            // dateDeNaissance
            // 
            dateDeNaissance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateDeNaissance.DataPropertyName = "DateDeNaissance";
            dateDeNaissance.HeaderText = "Date de Naissance";
            dateDeNaissance.Name = "dateDeNaissance";
            // 
            // adresse
            // 
            adresse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            adresse.DataPropertyName = "Addresse";
            adresse.HeaderText = "Addresse";
            adresse.Name = "adresse";
            // 
            // telephone
            // 
            telephone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telephone.DataPropertyName = "NumeroTelephones";
            telephone.HeaderText = "Téléphone";
            telephone.Name = "telephone";
            // 
            // courriel
            // 
            courriel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            courriel.DataPropertyName = "AddresseCourriel";
            courriel.HeaderText = "Courriel";
            courriel.Name = "courriel";
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "Id";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // panel_bouton
            // 
            panel_bouton.Controls.Add(panelBoutons);
            panel_bouton.Dock = DockStyle.Bottom;
            panel_bouton.Location = new Point(3, 584);
            panel_bouton.Name = "panel_bouton";
            panel_bouton.Size = new Size(1214, 42);
            panel_bouton.TabIndex = 1;
            // 
            // panelBoutons
            // 
            panelBoutons.BackColor = Color.White;
            panelBoutons.Controls.Add(btn_fermer);
            panelBoutons.Controls.Add(btn_consultation);
            panelBoutons.Dock = DockStyle.Right;
            panelBoutons.Location = new Point(879, 0);
            panelBoutons.Name = "panelBoutons";
            panelBoutons.Size = new Size(335, 42);
            panelBoutons.TabIndex = 4;
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
            btn_fermer.Location = new Point(216, 6);
            btn_fermer.Name = "btn_fermer";
            btn_fermer.Size = new Size(112, 33);
            btn_fermer.TabIndex = 3;
            btn_fermer.Text = "Fermer";
            btn_fermer.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_fermer, "Cliquez pour fermer l'application");
            btn_fermer.UseVisualStyleBackColor = false;
            btn_fermer.Click += btn_fermer_Click;
            // 
            // btn_consultation
            // 
            btn_consultation.BackColor = Color.FromArgb(33, 150, 243);
            btn_consultation.FlatAppearance.BorderSize = 0;
            btn_consultation.FlatStyle = FlatStyle.Flat;
            btn_consultation.Font = new Font("Segoe UI", 14F);
            btn_consultation.ForeColor = Color.White;
            btn_consultation.Image = (Image)resources.GetObject("btn_consultation.Image");
            btn_consultation.ImageAlign = ContentAlignment.MiddleLeft;
            btn_consultation.Location = new Point(14, 6);
            btn_consultation.Name = "btn_consultation";
            btn_consultation.Size = new Size(183, 33);
            btn_consultation.TabIndex = 2;
            btn_consultation.Text = "Consultations....";
            btn_consultation.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_consultation, "Cliquez pour afficher la liste des consultations");
            btn_consultation.UseVisualStyleBackColor = false;
            btn_consultation.Click += btn_consultation_Click;
            // 
            // panel_sub_tittle
            // 
            panel_sub_tittle.Controls.Add(label1);
            panel_sub_tittle.Dock = DockStyle.Top;
            panel_sub_tittle.Location = new Point(3, 3);
            panel_sub_tittle.Name = "panel_sub_tittle";
            panel_sub_tittle.Size = new Size(1214, 37);
            panel_sub_tittle.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1214, 37);
            label1.TabIndex = 1;
            label1.Text = "Liste des patients";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabConsultation
            // 
            tabConsultation.BackColor = Color.White;
            tabConsultation.Controls.Add(panel4);
            tabConsultation.Controls.Add(pannell_bas_page);
            tabConsultation.Location = new Point(4, 34);
            tabConsultation.Name = "tabConsultation";
            tabConsultation.Padding = new Padding(3);
            tabConsultation.Size = new Size(1220, 629);
            tabConsultation.TabIndex = 2;
            tabConsultation.Text = "Consultations";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1214, 580);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgConsultationHistorytList);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(1214, 415);
            panel3.TabIndex = 3;
            // 
            // dtgConsultationHistorytList
            // 
            dtgConsultationHistorytList.AllowUserToAddRows = false;
            dtgConsultationHistorytList.AllowUserToDeleteRows = false;
            dtgConsultationHistorytList.BackgroundColor = Color.White;
            dtgConsultationHistorytList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgConsultationHistorytList.Columns.AddRange(new DataGridViewColumn[] { IDConsultation, Motif, Date, Observation, Diagnostic, DossierMedicalId, SessionId });
            dtgConsultationHistorytList.Dock = DockStyle.Fill;
            dtgConsultationHistorytList.GridColor = Color.WhiteSmoke;
            dtgConsultationHistorytList.Location = new Point(0, 0);
            dtgConsultationHistorytList.Name = "dtgConsultationHistorytList";
            dtgConsultationHistorytList.ReadOnly = true;
            dtgConsultationHistorytList.Size = new Size(1214, 415);
            dtgConsultationHistorytList.TabIndex = 0;
            dtgConsultationHistorytList.CellClick += dtgConulationtList_CellClick;
            // 
            // IDConsultation
            // 
            IDConsultation.DataPropertyName = "Id";
            IDConsultation.HeaderText = "ID";
            IDConsultation.Name = "IDConsultation";
            IDConsultation.ReadOnly = true;
            IDConsultation.Visible = false;
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
            // DossierMedicalId
            // 
            DossierMedicalId.DataPropertyName = "DossierMedicalId";
            DossierMedicalId.HeaderText = "DossierMedicalId";
            DossierMedicalId.Name = "DossierMedicalId";
            DossierMedicalId.ReadOnly = true;
            DossierMedicalId.Visible = false;
            // 
            // SessionId
            // 
            SessionId.DataPropertyName = "SessionId";
            SessionId.HeaderText = "SessionId";
            SessionId.Name = "SessionId";
            SessionId.ReadOnly = true;
            SessionId.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(1214, 33);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 3);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 22;
            label2.Text = "Liste des consultations";
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
            panel1.Size = new Size(1214, 132);
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
            TxtCourriel.Size = new Size(0, 17);
            TxtCourriel.TabIndex = 27;
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
            TxtNom.Size = new Size(0, 17);
            TxtNom.TabIndex = 22;
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
            TxtPrenom.Size = new Size(0, 17);
            TxtPrenom.TabIndex = 23;
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
            TxtTelephone.Size = new Size(0, 17);
            TxtTelephone.TabIndex = 26;
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
            TxtDate.Size = new Size(0, 17);
            TxtDate.TabIndex = 25;
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
            TxtAddresse.Size = new Size(0, 17);
            TxtAddresse.TabIndex = 24;
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
            // pannell_bas_page
            // 
            pannell_bas_page.BackColor = Color.White;
            pannell_bas_page.Controls.Add(panel5);
            pannell_bas_page.Dock = DockStyle.Bottom;
            pannell_bas_page.Location = new Point(3, 583);
            pannell_bas_page.Name = "pannell_bas_page";
            pannell_bas_page.Size = new Size(1214, 43);
            pannell_bas_page.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(button1);
            panel5.Controls.Add(btn_prescriptions);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(879, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(335, 43);
            panel5.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 82, 82);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(216, 6);
            button1.Name = "button1";
            button1.Size = new Size(112, 33);
            button1.TabIndex = 3;
            button1.Text = "Fermer";
            button1.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(button1, "Cliquez ici pour enregistrer l'ajout de la nouvelle consultation.");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_prescriptions
            // 
            btn_prescriptions.BackColor = Color.FromArgb(33, 150, 243);
            btn_prescriptions.FlatAppearance.BorderSize = 0;
            btn_prescriptions.FlatStyle = FlatStyle.Flat;
            btn_prescriptions.Font = new Font("Segoe UI", 14F);
            btn_prescriptions.ForeColor = Color.White;
            btn_prescriptions.Image = (Image)resources.GetObject("btn_prescriptions.Image");
            btn_prescriptions.ImageAlign = ContentAlignment.MiddleLeft;
            btn_prescriptions.Location = new Point(24, 6);
            btn_prescriptions.Name = "btn_prescriptions";
            btn_prescriptions.Size = new Size(173, 33);
            btn_prescriptions.TabIndex = 2;
            btn_prescriptions.Text = "Prescription....";
            btn_prescriptions.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_prescriptions, "Cliquez ici pour consulter la fiche du patient selectionnée.");
            btn_prescriptions.UseVisualStyleBackColor = false;
            btn_prescriptions.Click += btn_prescription_Click;
            // 
            // tabPrescription
            // 
            tabPrescription.Controls.Add(dtgListePrescription);
            tabPrescription.Controls.Add(panel7);
            tabPrescription.Controls.Add(panel6);
            tabPrescription.Controls.Add(panel_consultation_prescription);
            tabPrescription.Location = new Point(4, 34);
            tabPrescription.Name = "tabPrescription";
            tabPrescription.Padding = new Padding(3);
            tabPrescription.Size = new Size(1220, 629);
            tabPrescription.TabIndex = 3;
            tabPrescription.Text = "Presciptions";
            tabPrescription.UseVisualStyleBackColor = true;
            // 
            // dtgListePrescription
            // 
            dtgListePrescription.AllowUserToAddRows = false;
            dtgListePrescription.AllowUserToDeleteRows = false;
            dtgListePrescription.BackgroundColor = Color.White;
            dtgListePrescription.BorderStyle = BorderStyle.Fixed3D;
            dtgListePrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListePrescription.Columns.AddRange(new DataGridViewColumn[] { IDE, Medicament, Dosage, Instruction, Duree, ConsultationId, etat });
            dtgListePrescription.Dock = DockStyle.Fill;
            dtgListePrescription.GridColor = Color.WhiteSmoke;
            dtgListePrescription.Location = new Point(3, 168);
            dtgListePrescription.MultiSelect = false;
            dtgListePrescription.Name = "dtgListePrescription";
            dtgListePrescription.ReadOnly = true;
            dtgListePrescription.Size = new Size(1214, 415);
            dtgListePrescription.TabIndex = 7;
            dtgListePrescription.CellClick += dtgPrescriptionList_CellClick;
            dtgListePrescription.CellFormatting += ConvertEtat;
            // 
            // IDE
            // 
            IDE.DataPropertyName = "Id";
            IDE.HeaderText = "Id";
            IDE.Name = "IDE";
            IDE.ReadOnly = true;
            IDE.Visible = false;
            // 
            // Medicament
            // 
            Medicament.DataPropertyName = "Medicament";
            Medicament.HeaderText = "Medicament";
            Medicament.Name = "Medicament";
            Medicament.ReadOnly = true;
            // 
            // Dosage
            // 
            Dosage.DataPropertyName = "Dosage";
            Dosage.HeaderText = "Dosage";
            Dosage.Name = "Dosage";
            Dosage.ReadOnly = true;
            // 
            // Instruction
            // 
            Instruction.DataPropertyName = "Instruction";
            Instruction.HeaderText = "Instruction";
            Instruction.Name = "Instruction";
            Instruction.ReadOnly = true;
            // 
            // Duree
            // 
            Duree.DataPropertyName = "Duree";
            Duree.HeaderText = "Duree";
            Duree.Name = "Duree";
            Duree.ReadOnly = true;
            // 
            // ConsultationId
            // 
            ConsultationId.DataPropertyName = "ConsultationId";
            ConsultationId.HeaderText = "ConsultationId";
            ConsultationId.Name = "ConsultationId";
            ConsultationId.ReadOnly = true;
            ConsultationId.Visible = false;
            // 
            // etat
            // 
            etat.DataPropertyName = "etat";
            etat.HeaderText = "Etat";
            etat.Name = "etat";
            etat.ReadOnly = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(3, 583);
            panel7.Name = "panel7";
            panel7.Size = new Size(1214, 43);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(button2);
            panel8.Controls.Add(btn_ajouter_prescription);
            panel8.Controls.Add(btn_cloturer_prescription);
            panel8.Controls.Add(btn_consulter_prescription);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(592, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(622, 43);
            panel8.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 82, 82);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(512, 6);
            button2.Name = "button2";
            button2.Size = new Size(107, 30);
            button2.TabIndex = 3;
            button2.Text = "Fermer";
            button2.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(button2, "Cliquez ici pour enregistrer l'ajout de la nouvelle consultation.");
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_ajouter_prescription
            // 
            btn_ajouter_prescription.BackColor = Color.FromArgb(76, 175, 80);
            btn_ajouter_prescription.FlatAppearance.BorderSize = 0;
            btn_ajouter_prescription.FlatStyle = FlatStyle.Flat;
            btn_ajouter_prescription.Font = new Font("Segoe UI", 14F);
            btn_ajouter_prescription.ForeColor = Color.White;
            btn_ajouter_prescription.Image = (Image)resources.GetObject("btn_ajouter_prescription.Image");
            btn_ajouter_prescription.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ajouter_prescription.Location = new Point(20, 6);
            btn_ajouter_prescription.Name = "btn_ajouter_prescription";
            btn_ajouter_prescription.Size = new Size(115, 30);
            btn_ajouter_prescription.TabIndex = 0;
            btn_ajouter_prescription.Text = "Ajouter";
            btn_ajouter_prescription.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_ajouter_prescription, "Cliquez ici pour ajouter une nouvelle prescription");
            btn_ajouter_prescription.UseVisualStyleBackColor = false;
            btn_ajouter_prescription.Click += btn_ajouter_prescription_Click;
            // 
            // btn_cloturer_prescription
            // 
            btn_cloturer_prescription.BackColor = Color.FromArgb(255, 152, 0);
            btn_cloturer_prescription.FlatAppearance.BorderSize = 0;
            btn_cloturer_prescription.FlatStyle = FlatStyle.Flat;
            btn_cloturer_prescription.Font = new Font("Segoe UI", 14F);
            btn_cloturer_prescription.ForeColor = Color.White;
            btn_cloturer_prescription.Image = (Image)resources.GetObject("btn_cloturer_prescription.Image");
            btn_cloturer_prescription.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cloturer_prescription.Location = new Point(180, 6);
            btn_cloturer_prescription.Name = "btn_cloturer_prescription";
            btn_cloturer_prescription.Size = new Size(120, 30);
            btn_cloturer_prescription.TabIndex = 1;
            btn_cloturer_prescription.Text = "Cloturer";
            btn_cloturer_prescription.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_cloturer_prescription, "Cliquer ici pour cloturer la prescription selectionnee");
            btn_cloturer_prescription.UseVisualStyleBackColor = false;
            btn_cloturer_prescription.Click += btn_cloturer_prescription_Click;
            // 
            // btn_consulter_prescription
            // 
            btn_consulter_prescription.BackColor = Color.FromArgb(33, 150, 243);
            btn_consulter_prescription.FlatAppearance.BorderSize = 0;
            btn_consulter_prescription.FlatStyle = FlatStyle.Flat;
            btn_consulter_prescription.Font = new Font("Segoe UI", 14F);
            btn_consulter_prescription.ForeColor = Color.White;
            btn_consulter_prescription.Image = (Image)resources.GetObject("btn_consulter_prescription.Image");
            btn_consulter_prescription.ImageAlign = ContentAlignment.MiddleLeft;
            btn_consulter_prescription.Location = new Point(340, 6);
            btn_consulter_prescription.Name = "btn_consulter_prescription";
            btn_consulter_prescription.Size = new Size(135, 30);
            btn_consulter_prescription.TabIndex = 2;
            btn_consulter_prescription.Text = "Consulter";
            btn_consulter_prescription.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_consulter_prescription, "Cliquez ici pour consulter la prescription selectionnée.");
            btn_consulter_prescription.UseVisualStyleBackColor = false;
            btn_consulter_prescription.Click += btn_consulter_prescription_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 135);
            panel6.Name = "panel6";
            panel6.Size = new Size(1214, 33);
            panel6.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 3);
            label3.Name = "label3";
            label3.Size = new Size(208, 25);
            label3.TabIndex = 22;
            label3.Text = "Liste des prescriptions";
            // 
            // panel_consultation_prescription
            // 
            panel_consultation_prescription.BackColor = SystemColors.ControlLightLight;
            panel_consultation_prescription.Controls.Add(TxtDateConsultation);
            panel_consultation_prescription.Controls.Add(TxtDiagnostic);
            panel_consultation_prescription.Controls.Add(TxtObservation);
            panel_consultation_prescription.Controls.Add(TxtMotif);
            panel_consultation_prescription.Controls.Add(label9);
            panel_consultation_prescription.Controls.Add(label_Date);
            panel_consultation_prescription.Controls.Add(label_observation);
            panel_consultation_prescription.Controls.Add(label_ob);
            panel_consultation_prescription.Controls.Add(lable_Motif);
            panel_consultation_prescription.Dock = DockStyle.Top;
            panel_consultation_prescription.Location = new Point(3, 3);
            panel_consultation_prescription.Name = "panel_consultation_prescription";
            panel_consultation_prescription.Size = new Size(1214, 132);
            panel_consultation_prescription.TabIndex = 2;
            // 
            // TxtDateConsultation
            // 
            TxtDateConsultation.AutoSize = true;
            TxtDateConsultation.BackColor = Color.Transparent;
            TxtDateConsultation.Font = new Font("Segoe UI", 9.75F);
            TxtDateConsultation.ForeColor = Color.Black;
            TxtDateConsultation.Location = new Point(58, 45);
            TxtDateConsultation.Name = "TxtDateConsultation";
            TxtDateConsultation.Size = new Size(35, 17);
            TxtDateConsultation.TabIndex = 22;
            TxtDateConsultation.Text = "Date";
            TxtDateConsultation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtDiagnostic
            // 
            TxtDiagnostic.AutoSize = true;
            TxtDiagnostic.BackColor = Color.Transparent;
            TxtDiagnostic.Font = new Font("Segoe UI", 9.75F);
            TxtDiagnostic.ForeColor = Color.Black;
            TxtDiagnostic.Location = new Point(93, 95);
            TxtDiagnostic.Name = "TxtDiagnostic";
            TxtDiagnostic.Size = new Size(69, 17);
            TxtDiagnostic.TabIndex = 23;
            TxtDiagnostic.Text = "Diagnostic";
            TxtDiagnostic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtObservation
            // 
            TxtObservation.AutoSize = true;
            TxtObservation.BackColor = Color.Transparent;
            TxtObservation.Font = new Font("Segoe UI", 9.75F);
            TxtObservation.ForeColor = Color.Black;
            TxtObservation.Location = new Point(525, 95);
            TxtObservation.Name = "TxtObservation";
            TxtObservation.Size = new Size(19, 17);
            TxtObservation.TabIndex = 26;
            TxtObservation.Text = "Id";
            TxtObservation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtMotif
            // 
            TxtMotif.AutoSize = true;
            TxtMotif.BackColor = Color.Transparent;
            TxtMotif.Font = new Font("Segoe UI", 9.75F);
            TxtMotif.ForeColor = Color.Black;
            TxtMotif.Location = new Point(472, 45);
            TxtMotif.Name = "TxtMotif";
            TxtMotif.Size = new Size(39, 17);
            TxtMotif.TabIndex = 25;
            TxtMotif.Text = "Motif";
            TxtMotif.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 4);
            label9.Name = "label9";
            label9.Size = new Size(237, 25);
            label9.TabIndex = 14;
            label9.Text = "Details de la Consultation";
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.BackColor = Color.Transparent;
            label_Date.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_Date.ForeColor = Color.Black;
            label_Date.Location = new Point(9, 45);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(43, 17);
            label_Date.TabIndex = 15;
            label_Date.Text = "Date :";
            label_Date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_observation
            // 
            label_observation.AutoSize = true;
            label_observation.BackColor = Color.Transparent;
            label_observation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_observation.ForeColor = Color.Black;
            label_observation.Location = new Point(9, 95);
            label_observation.Name = "label_observation";
            label_observation.Size = new Size(78, 17);
            label_observation.TabIndex = 16;
            label_observation.Text = "Diagnostic :";
            label_observation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_ob
            // 
            label_ob.AutoSize = true;
            label_ob.BackColor = Color.Transparent;
            label_ob.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_ob.ForeColor = Color.Black;
            label_ob.Location = new Point(419, 95);
            label_ob.Name = "label_ob";
            label_ob.Size = new Size(100, 17);
            label_ob.TabIndex = 19;
            label_ob.Text = "Observations : ";
            label_ob.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lable_Motif
            // 
            lable_Motif.AutoSize = true;
            lable_Motif.BackColor = Color.Transparent;
            lable_Motif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lable_Motif.ForeColor = Color.Black;
            lable_Motif.Location = new Point(419, 45);
            lable_Motif.Name = "lable_Motif";
            lable_Motif.Size = new Size(47, 17);
            lable_Motif.TabIndex = 18;
            lable_Motif.Text = "Motif :";
            lable_Motif.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Patient);
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
            // 
            // test
            // 
            test.HeaderText = "Column1";
            test.Name = "test";
            test.ReadOnly = true;
            // 
            // Form_gestion_Prescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_List);
            Controls.Add(panel_Titre);
            Name = "Form_gestion_Prescription";
            Size = new Size(1228, 707);
            panel_Titre.ResumeLayout(false);
            panel_List.ResumeLayout(false);
            tabControlGestionPrescription.ResumeLayout(false);
            tablistePatients.ResumeLayout(false);
            panel_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgPatientList).EndInit();
            panel_bouton.ResumeLayout(false);
            panelBoutons.ResumeLayout(false);
            panel_sub_tittle.ResumeLayout(false);
            tabConsultation.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgConsultationHistorytList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pannell_bas_page.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tabPrescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgListePrescription).EndInit();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel_consultation_prescription.ResumeLayout(false);
            panel_consultation_prescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
          
            // Style général
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.Fixed3D;
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

            dgv.AutoGenerateColumns = false;
        }
        private void TabControlGestionPrescription_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabControl tabControl = sender as TabControl;
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            // Définir la couleur de l'onglet sélectionné
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Brush backBrush = isSelected
                ? new SolidBrush(Color.FromArgb(33, 150, 243)) // Bleu pour l'onglet sélectionné
                : new SolidBrush(Color.Gray); // Gris pour les onglets non sélectionnés
            Brush textBrush = Brushes.White; // Blanc pour le texte

            // Dessiner l'arrière-plan de l'onglet
            g.FillRectangle(backBrush, tabBounds);

            // Dessiner le texte de l'onglet
            using (Font font = new Font("Segoe UI", 10F, FontStyle.Bold))
            {
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // Dessiner le texte au centre de l'onglet
                g.DrawString(tabPage.Text, font, textBrush, tabBounds, stringFormat);
            }

            // Dessiner une bordure pour chaque onglet (facultatif)
            g.DrawRectangle(Pens.LightGray, tabBounds);
        }

    


        private Panel panel_Titre;
        private Panel panel_List;
        private Label lbl_GestionPatient;
        private BindingSource patientBindingSource;
        private ToolTip toolTip;
        private TabControl tabControlGestionPrescription;
        private TabPage tablistePatients;
        private TabPage tabConsultation;
        private Panel panel_principal;
        private Panel panel_bouton;
        private Panel panel_sub_tittle;
        private Label label1;
        private DataGridView dtgPatientList;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn Dossier;
        private DataGridViewTextBoxColumn prenom;
        private DataGridViewTextBoxColumn dateDeNaissance;
        private DataGridViewTextBoxColumn adresse;
        private DataGridViewTextBoxColumn telephone;
        private DataGridViewTextBoxColumn courriel;
        private DataGridViewTextBoxColumn ID;
        private Panel panelBoutons;
        private Button btn_fermer;
        private Button btn_consultation;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dtgConsultationHistorytList;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
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
        private Panel pannell_bas_page;
        private BindingSource bindingSource1;
        private ToolTip toolTip1;
        private Panel panel5;
        private Button button1;
        private Button btn_prescriptions;
        private TabPage tabPrescription;
        private Panel panel_consultation_prescription;
        private Label TxtDateConsultation;
        private Label TxtDiagnostic;
        private Label TxtObservation;
        private Label TxtMotif;
        private Label label9;
        private Label label_Date;
        private Label label_observation;
        private Label label_ob;
        private Label lable_Motif;
        private Panel panel7;
        private Panel panel6;
        private Label label3;
        private DataGridView dtgListePrescription;
        private Panel panel8;
        private Button button2;
        private Button btn_ajouter_prescription;
        private Button btn_cloturer_prescription;
        private Button btn_consulter_prescription;
        private DataGridViewTextBoxColumn test;
        private DataGridViewTextBoxColumn IDConsultation;
        private DataGridViewTextBoxColumn Motif;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Observation;
        private DataGridViewTextBoxColumn Diagnostic;
        private DataGridViewTextBoxColumn DossierMedicalId;
        private DataGridViewTextBoxColumn SessionId;
        private DataGridViewTextBoxColumn IDE;
        private DataGridViewTextBoxColumn Medicament;
        private DataGridViewTextBoxColumn Dosage;
        private DataGridViewTextBoxColumn Instruction;
        private DataGridViewTextBoxColumn Duree;
        private DataGridViewTextBoxColumn ConsultationId;
        private DataGridViewTextBoxColumn etat;
    }
}
