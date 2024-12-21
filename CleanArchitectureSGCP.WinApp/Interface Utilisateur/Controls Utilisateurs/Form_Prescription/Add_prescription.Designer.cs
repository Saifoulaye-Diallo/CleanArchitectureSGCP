using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Prescription
{
    partial class Add_prescription
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_prescription));
            PannelPrincipal = new Panel();
            splitContainer_ajout = new SplitContainer();
            label_duree = new Label();
            label_instruction = new Label();
            label_Dosage = new Label();
            label_Medicament = new Label();
            btn_annuler = new Button();
            btn_save = new Button();
            Dosage = new TextBox();
            Instruction = new TextBox();
            Duree = new TextBox();
            Medicament = new TextBox();
            toolTip = new ToolTip(components);
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
            PannelPrincipal.Size = new Size(487, 239);
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
            splitContainer_ajout.Panel1.Controls.Add(label_duree);
            splitContainer_ajout.Panel1.Controls.Add(label_instruction);
            splitContainer_ajout.Panel1.Controls.Add(label_Dosage);
            splitContainer_ajout.Panel1.Controls.Add(label_Medicament);
            // 
            // splitContainer_ajout.Panel2
            // 
            splitContainer_ajout.Panel2.Controls.Add(btn_annuler);
            splitContainer_ajout.Panel2.Controls.Add(btn_save);
            splitContainer_ajout.Panel2.Controls.Add(Dosage);
            splitContainer_ajout.Panel2.Controls.Add(Instruction);
            splitContainer_ajout.Panel2.Controls.Add(Duree);
            splitContainer_ajout.Panel2.Controls.Add(Medicament);
            splitContainer_ajout.Size = new Size(487, 239);
            splitContainer_ajout.SplitterDistance = 148;
            splitContainer_ajout.TabIndex = 0;
            // 
            // label_duree
            // 
            label_duree.AutoSize = true;
            label_duree.BackColor = Color.Transparent;
            label_duree.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_duree.ForeColor = Color.DarkSlateGray;
            label_duree.Location = new Point(27, 147);
            label_duree.Name = "label_duree";
            label_duree.Size = new Size(49, 19);
            label_duree.TabIndex = 4;
            label_duree.Text = "Durée";
            label_duree.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_instruction
            // 
            label_instruction.AutoSize = true;
            label_instruction.BackColor = Color.Transparent;
            label_instruction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_instruction.ForeColor = Color.DarkSlateGray;
            label_instruction.Location = new Point(27, 113);
            label_instruction.Name = "label_instruction";
            label_instruction.Size = new Size(79, 19);
            label_instruction.TabIndex = 2;
            label_instruction.Text = "Instruction";
            label_instruction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Dosage
            // 
            label_Dosage.AutoSize = true;
            label_Dosage.BackColor = Color.Transparent;
            label_Dosage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_Dosage.ForeColor = Color.DarkSlateGray;
            label_Dosage.Location = new Point(26, 72);
            label_Dosage.Name = "label_Dosage";
            label_Dosage.Size = new Size(60, 19);
            label_Dosage.TabIndex = 1;
            label_Dosage.Text = "Dosoge";
            label_Dosage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Medicament
            // 
            label_Medicament.AutoSize = true;
            label_Medicament.BackColor = Color.Transparent;
            label_Medicament.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_Medicament.ForeColor = Color.DarkSlateGray;
            label_Medicament.Location = new Point(27, 37);
            label_Medicament.Name = "label_Medicament";
            label_Medicament.Size = new Size(100, 19);
            label_Medicament.TabIndex = 0;
            label_Medicament.Text = "Medicament :";
            label_Medicament.TextAlign = ContentAlignment.MiddleLeft;
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
            btn_annuler.Location = new Point(161, 185);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(120, 35);
            btn_annuler.TabIndex = 0;
            btn_annuler.Text = "Annuler";
            btn_annuler.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_annuler, "Cliquer pour annuler");
            btn_annuler.UseVisualStyleBackColor = false;
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
            btn_save.Location = new Point(16, 185);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(139, 35);
            btn_save.TabIndex = 1;
            btn_save.Text = "Enregistrer";
            btn_save.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_save, "Cliquez pour enregistrer");
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // Dosage
            // 
            Dosage.Location = new Point(16, 68);
            Dosage.Name = "Dosage";
            Dosage.Size = new Size(265, 23);
            Dosage.TabIndex = 5;
            // 
            // Instruction
            // 
            Instruction.Location = new Point(16, 109);
            Instruction.Name = "Instruction";
            Instruction.Size = new Size(265, 23);
            Instruction.TabIndex = 4;
            // 
            // Duree
            // 
            Duree.Location = new Point(16, 143);
            Duree.Name = "Duree";
            Duree.Size = new Size(265, 23);
            Duree.TabIndex = 3;
            // 
            // Medicament
            // 
            Medicament.Location = new Point(16, 33);
            Medicament.Name = "Medicament";
            Medicament.Size = new Size(265, 23);
            Medicament.TabIndex = 0;
            Medicament.Tag = "";
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;
            // 
            // Add_prescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 319);
            Controls.Add(PannelPrincipal);
            Name = "Add_prescription";
            Text = "Ajouter une nouvelle prescription";
            PannelPrincipal.ResumeLayout(false);
            splitContainer_ajout.Panel1.ResumeLayout(false);
            splitContainer_ajout.Panel1.PerformLayout();
            splitContainer_ajout.Panel2.ResumeLayout(false);
            splitContainer_ajout.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_ajout).EndInit();
            splitContainer_ajout.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel PannelPrincipal;
        private SplitContainer splitContainer_ajout;
        private Label label_duree;
        private Label label_instruction;
        private Label label_Dosage;
        private Label label_Medicament;
        private TextBox Medicament;
        private TextBox Dosage;
        private TextBox Instruction;
        private TextBox Duree;
        private Button btn_annuler;
        private Button btn_save;
        private ToolTip toolTip;
    }
}