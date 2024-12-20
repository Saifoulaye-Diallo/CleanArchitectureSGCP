namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            PannelPrincipal = new Panel();
            splitContainer_ajout = new SplitContainer();
            labelCourriel = new Label();
            labelTelephone = new Label();
            labelDateNaiss = new Label();
            labelAdresse = new Label();
            labelPrenom = new Label();
            label_nom = new Label();
            btn_annuler = new Button();
            btn_save = new Button();
            Date = new DateTimePicker();
            Prenom = new TextBox();
            Adresse = new TextBox();
            Telephone = new TextBox();
            Courriel = new TextBox();
            Nom = new TextBox();
            // Créer une instance de ToolTip
            ToolTip toolTip = new ToolTip();
            // Configurer les propriétés
            toolTip.AutoPopDelay = 5000; // Durée d'affichage (en millisecondes)
            toolTip.InitialDelay = 200;  // Délai avant d'afficher le ToolTip
            toolTip.ReshowDelay = 100;   // Délai avant de réafficher si l'utilisateur passe à un autre contrôle
            toolTip.ShowAlways = true;   // Toujours afficher, même si le formulaire n'est pas actif

            PannelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_ajout).BeginInit();
            splitContainer_ajout.Panel1.SuspendLayout();
            splitContainer_ajout.Panel2.SuspendLayout();
            splitContainer_ajout.SuspendLayout();
            SuspendLayout();
            // 
            // PannelPrincipal
            // 
            PannelPrincipal.Controls.Add(splitContainer_ajout);
            PannelPrincipal.Dock = DockStyle.Fill;
            PannelPrincipal.Location = new Point(20, 60);
            PannelPrincipal.Name = "PannelPrincipal";
            PannelPrincipal.Size = new Size(548, 321);
            PannelPrincipal.TabIndex = 0;
            // 
            // splitContainer_ajout
            // 
            splitContainer_ajout.Dock = DockStyle.Fill;
            splitContainer_ajout.Location = new Point(0, 0);
            splitContainer_ajout.Name = "splitContainer_ajout";
            // 
            // splitContainer_ajout.Panel1
            // 
            splitContainer_ajout.Panel1.Controls.Add(labelCourriel);
            splitContainer_ajout.Panel1.Controls.Add(labelTelephone);
            splitContainer_ajout.Panel1.Controls.Add(labelDateNaiss);
            splitContainer_ajout.Panel1.Controls.Add(labelAdresse);
            splitContainer_ajout.Panel1.Controls.Add(labelPrenom);
            splitContainer_ajout.Panel1.Controls.Add(label_nom);
            // 
            // splitContainer_ajout.Panel2
            // 
            splitContainer_ajout.Panel2.Controls.Add(btn_annuler);
            splitContainer_ajout.Panel2.Controls.Add(btn_save);
            splitContainer_ajout.Panel2.Controls.Add(Date);
            splitContainer_ajout.Panel2.Controls.Add(Prenom);
            splitContainer_ajout.Panel2.Controls.Add(Adresse);
            splitContainer_ajout.Panel2.Controls.Add(Telephone);
            splitContainer_ajout.Panel2.Controls.Add(Courriel);
            splitContainer_ajout.Panel2.Controls.Add(Nom);
            splitContainer_ajout.Size = new Size(548, 321);
            splitContainer_ajout.SplitterDistance = 167;
            splitContainer_ajout.TabIndex = 0;
            // 
            // labelCourriel
            // 
            labelCourriel.AutoSize = true;
            labelCourriel.BackColor = Color.Transparent;
            labelCourriel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCourriel.ForeColor = Color.DarkSlateGray;
            labelCourriel.Location = new Point(27, 221);
            labelCourriel.Name = "labelCourriel";
            labelCourriel.Size = new Size(63, 19);
            labelCourriel.TabIndex = 6;
            labelCourriel.Text = "Courriel";
            labelCourriel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.BackColor = Color.Transparent;
            labelTelephone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTelephone.ForeColor = Color.DarkSlateGray;
            labelTelephone.Location = new Point(27, 185);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(78, 19);
            labelTelephone.TabIndex = 4;
            labelTelephone.Text = "Téléphone";
            labelTelephone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDateNaiss
            // 
            labelDateNaiss.AutoSize = true;
            labelDateNaiss.BackColor = Color.Transparent;
            labelDateNaiss.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDateNaiss.ForeColor = Color.DarkSlateGray;
            labelDateNaiss.Location = new Point(26, 112);
            labelDateNaiss.Name = "labelDateNaiss";
            labelDateNaiss.Size = new Size(128, 19);
            labelDateNaiss.TabIndex = 3;
            labelDateNaiss.Text = "Date de naissance";
            labelDateNaiss.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.BackColor = Color.Transparent;
            labelAdresse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelAdresse.ForeColor = Color.DarkSlateGray;
            labelAdresse.Location = new Point(27, 151);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(62, 19);
            labelAdresse.TabIndex = 2;
            labelAdresse.Text = "Adresse";
            labelAdresse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.BackColor = Color.Transparent;
            labelPrenom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPrenom.ForeColor = Color.DarkSlateGray;
            labelPrenom.Location = new Point(26, 72);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(62, 19);
            labelPrenom.TabIndex = 1;
            labelPrenom.Text = "Prénom";
            labelPrenom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.BackColor = Color.Transparent;
            label_nom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_nom.ForeColor = Color.DarkSlateGray;
            label_nom.Location = new Point(27, 37);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(42, 19);
            label_nom.TabIndex = 0;
            label_nom.Text = "Nom";
            label_nom.TextAlign = ContentAlignment.MiddleLeft;
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
            btn_annuler.Location = new Point(161, 259);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(120, 35);
            btn_annuler.TabIndex = 0;
            btn_annuler.Text = "Annuler";
            btn_annuler.TextAlign = ContentAlignment.MiddleRight;
            btn_annuler.UseVisualStyleBackColor = false;
            btn_annuler.Click += btn_annuler_Click;
            toolTip.SetToolTip(btn_annuler, "Cliquez ici pour annuler l'ajout du patient.");
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
            btn_save.Location = new Point(16, 259);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(139, 35);
            btn_save.TabIndex = 1;
            btn_save.Text = "Enregistrer";
            btn_save.TextAlign = ContentAlignment.MiddleRight;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            toolTip.SetToolTip(btn_annuler, "Cliquez ici pour enregistrer l'ajout du patient.");
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
            // Nom
            // 
            Nom.Location = new Point(16, 33);
            Nom.Name = "Nom";
            Nom.Size = new Size(265, 23);
            Nom.TabIndex = 0;
            Nom.Tag = "";
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 401);
            Controls.Add(PannelPrincipal);
            Name = "AddPatient";
            Text = "Ajouter un nouveau patient";
            PannelPrincipal.ResumeLayout(false);
            splitContainer_ajout.Panel1.ResumeLayout(false);
            splitContainer_ajout.Panel1.PerformLayout();
            splitContainer_ajout.Panel2.ResumeLayout(false);
            splitContainer_ajout.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_ajout).EndInit();
            splitContainer_ajout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PannelPrincipal;
        private SplitContainer splitContainer_ajout;
        private Label labelCourriel;
        private Label labelTelephone;
        private Label labelDateNaiss;
        private Label labelAdresse;
        private Label labelPrenom;
        private Label label_nom;
        private TextBox Nom;
        private TextBox Prenom;
        private TextBox Adresse;
        private TextBox Telephone;
        private TextBox Courriel;
        private DateTimePicker Date;
        private Button btn_annuler;
        private Button btn_save;
    }
}