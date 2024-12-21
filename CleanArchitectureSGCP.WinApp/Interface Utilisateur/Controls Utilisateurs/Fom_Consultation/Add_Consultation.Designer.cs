using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Fom_Consultation
{
    partial class Add_Consultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Consultation));
            PannelPrincipal = new Panel();
            Txt_diagnostic = new TextBox();
            lbl_diagnostic = new Label();
            Txt_obsevation = new TextBox();
            lbl_observation = new Label();
            Txt_motif = new TextBox();
            lbl_motif = new Label();
            TxtCourriel = new Label();
            TxtNom = new Label();
            TxtPrenom = new Label();
            TxtTelephone = new Label();
            TxtDate = new Label();
            TxtAddresse = new Label();
            label1 = new Label();
            label_Detail_Patient = new Label();
            btn_annuler = new Button();
            labelCourriel = new Label();
            label_nom = new Label();
            btn_save = new Button();
            labelPrenom = new Label();
            labelTelephone = new Label();
            labelDateNaiss = new Label();
            labelAdresse = new Label();
            Date = new DateTimePicker();
            Prenom = new TextBox();
            Adresse = new TextBox();
            Telephone = new TextBox();
            Courriel = new TextBox();
            toolTip = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            PannelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // PannelPrincipal
            // 
            PannelPrincipal.Controls.Add(Txt_diagnostic);
            PannelPrincipal.Controls.Add(lbl_diagnostic);
            PannelPrincipal.Controls.Add(Txt_obsevation);
            PannelPrincipal.Controls.Add(lbl_observation);
            PannelPrincipal.Controls.Add(Txt_motif);
            PannelPrincipal.Controls.Add(lbl_motif);
            PannelPrincipal.Controls.Add(TxtCourriel);
            PannelPrincipal.Controls.Add(TxtNom);
            PannelPrincipal.Controls.Add(TxtPrenom);
            PannelPrincipal.Controls.Add(TxtTelephone);
            PannelPrincipal.Controls.Add(TxtDate);
            PannelPrincipal.Controls.Add(TxtAddresse);
            PannelPrincipal.Controls.Add(label1);
            PannelPrincipal.Controls.Add(label_Detail_Patient);
            PannelPrincipal.Controls.Add(btn_annuler);
            PannelPrincipal.Controls.Add(labelCourriel);
            PannelPrincipal.Controls.Add(label_nom);
            PannelPrincipal.Controls.Add(btn_save);
            PannelPrincipal.Controls.Add(labelPrenom);
            PannelPrincipal.Controls.Add(labelTelephone);
            PannelPrincipal.Controls.Add(labelDateNaiss);
            PannelPrincipal.Controls.Add(labelAdresse);
            PannelPrincipal.Dock = DockStyle.Fill;
            PannelPrincipal.Location = new Point(20, 60);
            PannelPrincipal.Name = "PannelPrincipal";
            PannelPrincipal.Size = new Size(806, 433);
            PannelPrincipal.TabIndex = 0;
            // 
            // Txt_diagnostic
            // 
            Txt_diagnostic.Location = new Point(544, 229);
            Txt_diagnostic.Multiline = true;
            Txt_diagnostic.Name = "Txt_diagnostic";
            Txt_diagnostic.Size = new Size(244, 128);
            Txt_diagnostic.TabIndex = 17;
            Txt_diagnostic.Tag = "";
            // 
            // lbl_diagnostic
            // 
            lbl_diagnostic.AutoSize = true;
            lbl_diagnostic.BackColor = Color.Transparent;
            lbl_diagnostic.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_diagnostic.ForeColor = Color.Black;
            lbl_diagnostic.Location = new Point(544, 209);
            lbl_diagnostic.Name = "lbl_diagnostic";
            lbl_diagnostic.Size = new Size(71, 17);
            lbl_diagnostic.TabIndex = 18;
            lbl_diagnostic.Text = "Diagnostic";
            lbl_diagnostic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Txt_obsevation
            // 
            Txt_obsevation.Location = new Point(275, 229);
            Txt_obsevation.Multiline = true;
            Txt_obsevation.Name = "Txt_obsevation";
            Txt_obsevation.Size = new Size(254, 128);
            Txt_obsevation.TabIndex = 15;
            Txt_obsevation.Tag = "";
            // 
            // lbl_observation
            // 
            lbl_observation.AutoSize = true;
            lbl_observation.BackColor = Color.Transparent;
            lbl_observation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_observation.ForeColor = Color.Black;
            lbl_observation.Location = new Point(275, 209);
            lbl_observation.Name = "lbl_observation";
            lbl_observation.Size = new Size(83, 17);
            lbl_observation.TabIndex = 16;
            lbl_observation.Text = "Observation";
            lbl_observation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Txt_motif
            // 
            Txt_motif.Location = new Point(22, 229);
            Txt_motif.Multiline = true;
            Txt_motif.Name = "Txt_motif";
            Txt_motif.Size = new Size(233, 128);
            Txt_motif.TabIndex = 0;
            Txt_motif.Tag = "";
            // 
            // lbl_motif
            // 
            lbl_motif.AutoSize = true;
            lbl_motif.BackColor = Color.Transparent;
            lbl_motif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_motif.ForeColor = Color.Black;
            lbl_motif.Location = new Point(22, 209);
            lbl_motif.Name = "lbl_motif";
            lbl_motif.Size = new Size(40, 17);
            lbl_motif.TabIndex = 14;
            lbl_motif.Text = "Motif";
            lbl_motif.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCourriel
            // 
            TxtCourriel.AutoSize = true;
            TxtCourriel.BackColor = Color.Transparent;
            TxtCourriel.Font = new Font("Segoe UI", 9.75F);
            TxtCourriel.ForeColor = Color.Black;
            TxtCourriel.Location = new Point(627, 51);
            TxtCourriel.Name = "TxtCourriel";
            TxtCourriel.Size = new Size(54, 17);
            TxtCourriel.TabIndex = 13;
            TxtCourriel.Text = "Courriel";
            TxtCourriel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNom
            // 
            TxtNom.AutoSize = true;
            TxtNom.BackColor = Color.Transparent;
            TxtNom.Font = new Font("Segoe UI", 9.75F);
            TxtNom.ForeColor = Color.Black;
            TxtNom.Location = new Point(86, 51);
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new Size(34, 17);
            TxtNom.TabIndex = 8;
            TxtNom.Text = "nom";
            TxtNom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtPrenom
            // 
            TxtPrenom.AutoSize = true;
            TxtPrenom.BackColor = Color.Transparent;
            TxtPrenom.Font = new Font("Segoe UI", 9.75F);
            TxtPrenom.ForeColor = Color.Black;
            TxtPrenom.Location = new Point(86, 101);
            TxtPrenom.Name = "TxtPrenom";
            TxtPrenom.Size = new Size(53, 17);
            TxtPrenom.TabIndex = 9;
            TxtPrenom.Text = "Prénom";
            TxtPrenom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtTelephone
            // 
            TxtTelephone.AutoSize = true;
            TxtTelephone.BackColor = Color.Transparent;
            TxtTelephone.Font = new Font("Segoe UI", 9.75F);
            TxtTelephone.ForeColor = Color.Black;
            TxtTelephone.Location = new Point(384, 101);
            TxtTelephone.Name = "TxtTelephone";
            TxtTelephone.Size = new Size(68, 17);
            TxtTelephone.TabIndex = 12;
            TxtTelephone.Text = "Téléphone";
            TxtTelephone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtDate
            // 
            TxtDate.AutoSize = true;
            TxtDate.BackColor = Color.Transparent;
            TxtDate.Font = new Font("Segoe UI", 9.75F);
            TxtDate.ForeColor = Color.Black;
            TxtDate.Location = new Point(384, 51);
            TxtDate.Name = "TxtDate";
            TxtDate.Size = new Size(114, 17);
            TxtDate.TabIndex = 11;
            TxtDate.Text = "Date de naissance";
            TxtDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtAddresse
            // 
            TxtAddresse.AutoSize = true;
            TxtAddresse.BackColor = Color.Transparent;
            TxtAddresse.Font = new Font("Segoe UI", 9.75F);
            TxtAddresse.ForeColor = Color.Black;
            TxtAddresse.Location = new Point(627, 101);
            TxtAddresse.Name = "TxtAddresse";
            TxtAddresse.Size = new Size(63, 17);
            TxtAddresse.TabIndex = 10;
            TxtAddresse.Text = "Addresse";
            TxtAddresse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 161);
            label1.Name = "label1";
            label1.Size = new Size(306, 25);
            label1.TabIndex = 7;
            label1.Text = "Formulaire nouvelle consultation";
            // 
            // label_Detail_Patient
            // 
            label_Detail_Patient.AutoSize = true;
            label_Detail_Patient.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Detail_Patient.Location = new Point(22, 10);
            label_Detail_Patient.Name = "label_Detail_Patient";
            label_Detail_Patient.Size = new Size(125, 25);
            label_Detail_Patient.TabIndex = 0;
            label_Detail_Patient.Text = "Fiche patient";
            // 
            // btn_annuler
            // 
            btn_annuler.BackColor = Color.FromArgb(255, 82, 82);
            btn_annuler.FlatAppearance.BorderSize = 0;
            btn_annuler.FlatStyle = FlatStyle.Flat;
            btn_annuler.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_annuler.ForeColor = Color.White;
            btn_annuler.Image = (Image)resources.GetObject("btn_annuler.Image");
            btn_annuler.ImageAlign = ContentAlignment.MiddleLeft;
            btn_annuler.Location = new Point(668, 386);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(120, 35);
            btn_annuler.TabIndex = 0;
            btn_annuler.Text = "Annuler";
            btn_annuler.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_annuler, "Cliquez pour annuler");
            btn_annuler.UseVisualStyleBackColor = false;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // labelCourriel
            // 
            labelCourriel.AutoSize = true;
            labelCourriel.BackColor = Color.Transparent;
            labelCourriel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelCourriel.ForeColor = Color.Black;
            labelCourriel.Location = new Point(563, 51);
            labelCourriel.Name = "labelCourriel";
            labelCourriel.Size = new Size(62, 17);
            labelCourriel.TabIndex = 6;
            labelCourriel.Text = "Courriel :";
            labelCourriel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.BackColor = Color.Transparent;
            label_nom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label_nom.ForeColor = Color.Black;
            label_nom.Location = new Point(22, 51);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(45, 17);
            label_nom.TabIndex = 0;
            label_nom.Text = "Nom :";
            label_nom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(76, 175, 80);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_save.ForeColor = Color.White;
            btn_save.Image = (Image)resources.GetObject("btn_save.Image");
            btn_save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_save.Location = new Point(499, 386);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(139, 35);
            btn_save.TabIndex = 1;
            btn_save.Text = "Enregistrer";
            btn_save.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_save, "Cliquez pour enregistrer");
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.BackColor = Color.Transparent;
            labelPrenom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelPrenom.ForeColor = Color.Black;
            labelPrenom.Location = new Point(22, 101);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(63, 17);
            labelPrenom.TabIndex = 1;
            labelPrenom.Text = "Prénom :";
            labelPrenom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.BackColor = Color.Transparent;
            labelTelephone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelTelephone.ForeColor = Color.Black;
            labelTelephone.Location = new Point(261, 101);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(81, 17);
            labelTelephone.TabIndex = 4;
            labelTelephone.Text = "Téléphone : ";
            labelTelephone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDateNaiss
            // 
            labelDateNaiss.AutoSize = true;
            labelDateNaiss.BackColor = Color.Transparent;
            labelDateNaiss.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelDateNaiss.ForeColor = Color.Black;
            labelDateNaiss.Location = new Point(261, 51);
            labelDateNaiss.Name = "labelDateNaiss";
            labelDateNaiss.Size = new Size(124, 17);
            labelDateNaiss.TabIndex = 3;
            labelDateNaiss.Text = "Date de naissance :";
            labelDateNaiss.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.BackColor = Color.Transparent;
            labelAdresse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelAdresse.ForeColor = Color.Black;
            labelAdresse.Location = new Point(563, 101);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(59, 17);
            labelAdresse.TabIndex = 2;
            labelAdresse.Text = "Adresse:";
            labelAdresse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Date
            // 
            Date.Location = new Point(16, 108);
            Date.Name = "Date";
            Date.Size = new Size(265, 23);
            Date.TabIndex = 6;
            // 
            // Prenom
            // 
            Prenom.Location = new Point(16, 68);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(265, 23);
            Prenom.TabIndex = 5;
            // 
            // Adresse
            // 
            Adresse.Location = new Point(16, 147);
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(265, 23);
            Adresse.TabIndex = 4;
            // 
            // Telephone
            // 
            Telephone.Location = new Point(16, 181);
            Telephone.Name = "Telephone";
            Telephone.Size = new Size(265, 23);
            Telephone.TabIndex = 3;
            // 
            // Courriel
            // 
            Courriel.Location = new Point(16, 217);
            Courriel.Name = "Courriel";
            Courriel.Size = new Size(265, 23);
            Courriel.TabIndex = 1;
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Add_Consultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 513);
            Controls.Add(PannelPrincipal);
            Name = "Add_Consultation";
            Text = "Ajouter une nouvelle consultation";
            PannelPrincipal.ResumeLayout(false);
            PannelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PannelPrincipal;
        private Label labelCourriel;
        private Label labelTelephone;
        private Label labelDateNaiss;
        private Label labelAdresse;
        private Label labelPrenom;
        private Label label_nom;
        private TextBox Txt_motif;
        private TextBox Prenom;
        private TextBox Adresse;
        private TextBox Telephone;
        private TextBox Courriel;
        private DateTimePicker Date;
        private Button btn_annuler;
        private Button btn_save;
        private ToolTip toolTip;
        private Label label_Detail_Patient;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label TxtCourriel;
        private Label TxtNom;
        private Label TxtPrenom;
        private Label TxtTelephone;
        private Label TxtDate;
        private Label TxtAddresse;
        private Label lbl_motif;
        private TextBox Txt_diagnostic;
        private Label lbl_diagnostic;
        private TextBox Txt_obsevation;
        private Label lbl_observation;
    }
}