using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Patient;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Prescription
{
    partial class View_prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_prescription));
            PannelPrincipal = new Panel();
            splitContainer_ajout = new SplitContainer();
            labelDateNaiss = new Label();
            labelPrenom = new Label();
            label_nom = new Label();
            TxtInstruction = new Label();
            TxtDosage = new Label();
            TxtMedicament = new Label();
            btn_annuler = new Button();
            TxtDuree = new Label();
            labelAdresse = new Label();
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
            PannelPrincipal.Size = new Size(454, 241);
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
            splitContainer_ajout.Panel1.Controls.Add(labelDateNaiss);
            splitContainer_ajout.Panel1.Controls.Add(labelAdresse);
            splitContainer_ajout.Panel1.Controls.Add(labelPrenom);
            splitContainer_ajout.Panel1.Controls.Add(label_nom);
            // 
            // splitContainer_ajout.Panel2
            // 
            splitContainer_ajout.Panel2.Controls.Add(TxtInstruction);
            splitContainer_ajout.Panel2.Controls.Add(TxtDuree);
            splitContainer_ajout.Panel2.Controls.Add(TxtDosage);
            splitContainer_ajout.Panel2.Controls.Add(TxtMedicament);
            splitContainer_ajout.Panel2.Controls.Add(btn_annuler);
            splitContainer_ajout.Size = new Size(454, 241);
            splitContainer_ajout.SplitterDistance = 170;
            splitContainer_ajout.TabIndex = 0;
            // 
            // labelDateNaiss
            // 
            labelDateNaiss.AutoSize = true;
            labelDateNaiss.BackColor = Color.Transparent;
            labelDateNaiss.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDateNaiss.ForeColor = Color.DarkSlateGray;
            labelDateNaiss.Location = new Point(26, 112);
            labelDateNaiss.Name = "labelDateNaiss";
            labelDateNaiss.Size = new Size(91, 19);
            labelDateNaiss.TabIndex = 3;
            labelDateNaiss.Text = "Instruction : ";
            labelDateNaiss.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.BackColor = Color.Transparent;
            labelPrenom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPrenom.ForeColor = Color.DarkSlateGray;
            labelPrenom.Location = new Point(26, 72);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(71, 19);
            labelPrenom.TabIndex = 1;
            labelPrenom.Text = "Dosage : ";
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
            label_nom.Size = new Size(100, 19);
            label_nom.TabIndex = 0;
            label_nom.Text = "Medicament :";
            label_nom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtInstruction
            // 
            TxtInstruction.AutoSize = true;
            TxtInstruction.BackColor = Color.Transparent;
            TxtInstruction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtInstruction.ForeColor = Color.DarkSlateGray;
            TxtInstruction.Location = new Point(21, 112);
            TxtInstruction.Name = "TxtInstruction";
            TxtInstruction.Size = new Size(128, 19);
            TxtInstruction.TabIndex = 10;
            TxtInstruction.Text = "Date de naissance";
            TxtInstruction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtDosage
            // 
            TxtDosage.AutoSize = true;
            TxtDosage.BackColor = Color.Transparent;
            TxtDosage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtDosage.ForeColor = Color.DarkSlateGray;
            TxtDosage.Location = new Point(21, 72);
            TxtDosage.Name = "TxtDosage";
            TxtDosage.Size = new Size(62, 19);
            TxtDosage.TabIndex = 8;
            TxtDosage.Text = "Prénom";
            TxtDosage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtMedicament
            // 
            TxtMedicament.AutoSize = true;
            TxtMedicament.BackColor = Color.Transparent;
            TxtMedicament.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtMedicament.ForeColor = Color.DarkSlateGray;
            TxtMedicament.Location = new Point(22, 37);
            TxtMedicament.Name = "TxtMedicament";
            TxtMedicament.Size = new Size(42, 19);
            TxtMedicament.TabIndex = 7;
            TxtMedicament.Text = "Nom";
            TxtMedicament.TextAlign = ContentAlignment.MiddleLeft;
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
            btn_annuler.Location = new Point(21, 190);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(112, 35);
            btn_annuler.TabIndex = 0;
            btn_annuler.Text = "Fermer";
            btn_annuler.TextAlign = ContentAlignment.MiddleRight;
            btn_annuler.UseVisualStyleBackColor = false;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // TxtDuree
            // 
            TxtDuree.AutoSize = true;
            TxtDuree.BackColor = Color.Transparent;
            TxtDuree.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TxtDuree.ForeColor = Color.DarkSlateGray;
            TxtDuree.Location = new Point(22, 151);
            TxtDuree.Name = "TxtDuree";
            TxtDuree.Size = new Size(62, 19);
            TxtDuree.TabIndex = 9;
            TxtDuree.Text = "Adresse";
            TxtDuree.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.BackColor = Color.Transparent;
            labelAdresse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelAdresse.ForeColor = Color.DarkSlateGray;
            labelAdresse.Location = new Point(27, 151);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(61, 19);
            labelAdresse.TabIndex = 2;
            labelAdresse.Text = "Duree : ";
            labelAdresse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // View_prescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 321);
            Controls.Add(PannelPrincipal);
            Name = "View_prescription";
            Text = "Consulter une prescription";
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
        private Label labelDateNaiss;
        private Label labelPrenom;
        private Label label_nom;
        private Button btn_annuler;
        private Label TxtInstruction;
        private Label TxtDosage;
        private Label TxtMedicament;
        private Label labelAdresse;
        private Label TxtDuree;
    }
}