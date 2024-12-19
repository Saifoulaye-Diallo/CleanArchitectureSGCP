namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Patient
{
    partial class ViewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatient));
            PannelPrincipal = new Panel();
            splitContainer_ajout = new SplitContainer();
            labelCourriel = new Label();
            labelTelephone = new Label();
            labelDateNaiss = new Label();
            labelAdresse = new Label();
            labelPrenom = new Label();
            label_nom = new Label();
            TxtCourriel = new Label();
            TxtTelephone = new Label();
            TxtDate = new Label();
            TxtAdresse = new Label();
            TxtPrenom = new Label();
            TxtNom = new Label();
            btn_annuler = new Button();
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
            PannelPrincipal.Size = new Size(450, 321);
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
            splitContainer_ajout.Panel2.Controls.Add(TxtCourriel);
            splitContainer_ajout.Panel2.Controls.Add(TxtTelephone);
            splitContainer_ajout.Panel2.Controls.Add(TxtDate);
            splitContainer_ajout.Panel2.Controls.Add(TxtAdresse);
            splitContainer_ajout.Panel2.Controls.Add(TxtPrenom);
            splitContainer_ajout.Panel2.Controls.Add(TxtNom);
            splitContainer_ajout.Panel2.Controls.Add(btn_annuler);
            splitContainer_ajout.Size = new Size(450, 321);
            splitContainer_ajout.SplitterDistance = 169;
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
            // TxtCourriel
            // 
            TxtCourriel.AutoSize = true;
            TxtCourriel.BackColor = Color.Transparent;
            TxtCourriel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtCourriel.ForeColor = Color.DarkSlateGray;
            TxtCourriel.Location = new Point(22, 221);
            TxtCourriel.Name = "TxtCourriel";
            TxtCourriel.Size = new Size(63, 19);
            TxtCourriel.TabIndex = 12;
            TxtCourriel.Text = "Courriel";
            TxtCourriel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtTelephone
            // 
            TxtTelephone.AutoSize = true;
            TxtTelephone.BackColor = Color.Transparent;
            TxtTelephone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtTelephone.ForeColor = Color.DarkSlateGray;
            TxtTelephone.Location = new Point(22, 185);
            TxtTelephone.Name = "TxtTelephone";
            TxtTelephone.Size = new Size(78, 19);
            TxtTelephone.TabIndex = 11;
            TxtTelephone.Text = "Téléphone";
            TxtTelephone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtDate
            // 
            TxtDate.AutoSize = true;
            TxtDate.BackColor = Color.Transparent;
            TxtDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtDate.ForeColor = Color.DarkSlateGray;
            TxtDate.Location = new Point(21, 112);
            TxtDate.Name = "TxtDate";
            TxtDate.Size = new Size(128, 19);
            TxtDate.TabIndex = 10;
            TxtDate.Text = "Date de naissance";
            TxtDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtAdresse
            // 
            TxtAdresse.AutoSize = true;
            TxtAdresse.BackColor = Color.Transparent;
            TxtAdresse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtAdresse.ForeColor = Color.DarkSlateGray;
            TxtAdresse.Location = new Point(22, 151);
            TxtAdresse.Name = "TxtAdresse";
            TxtAdresse.Size = new Size(62, 19);
            TxtAdresse.TabIndex = 9;
            TxtAdresse.Text = "Adresse";
            TxtAdresse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtPrenom
            // 
            TxtPrenom.AutoSize = true;
            TxtPrenom.BackColor = Color.Transparent;
            TxtPrenom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtPrenom.ForeColor = Color.DarkSlateGray;
            TxtPrenom.Location = new Point(21, 72);
            TxtPrenom.Name = "TxtPrenom";
            TxtPrenom.Size = new Size(62, 19);
            TxtPrenom.TabIndex = 8;
            TxtPrenom.Text = "Prénom";
            TxtPrenom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNom
            // 
            TxtNom.AutoSize = true;
            TxtNom.BackColor = Color.Transparent;
            TxtNom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtNom.ForeColor = Color.DarkSlateGray;
            TxtNom.Location = new Point(22, 37);
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new Size(42, 19);
            TxtNom.TabIndex = 7;
            TxtNom.Text = "Nom";
            TxtNom.TextAlign = ContentAlignment.MiddleLeft;
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
            btn_annuler.Location = new Point(21, 265);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(112, 35);
            btn_annuler.TabIndex = 0;
            btn_annuler.Text = "Fermer";
            btn_annuler.TextAlign = ContentAlignment.MiddleRight;
            btn_annuler.UseVisualStyleBackColor = false;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // ViewPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 401);
            Controls.Add(PannelPrincipal);
            Name = "ViewPatient";
            Text = "Consulter une fiche patient";
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
        private Button btn_annuler;
        private Label TxtCourriel;
        private Label TxtTelephone;
        private Label TxtDate;
        private Label TxtAdresse;
        private Label TxtPrenom;
        private Label TxtNom;

    }
}