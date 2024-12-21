using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_DossierMedical
{
    partial class ListPrescriptionPassees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPrescriptionPassees));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dtgListePrescription = new DataGridView();
            IDE = new DataGridViewTextBoxColumn();
            Medicament = new DataGridViewTextBoxColumn();
            Dosage = new DataGridViewTextBoxColumn();
            Instruction = new DataGridViewTextBoxColumn();
            Duree = new DataGridViewTextBoxColumn();
            ConsultationId = new DataGridViewTextBoxColumn();
            etat = new DataGridViewTextBoxColumn();
            btn_fermer = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListePrescription).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(20, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 40);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_fermer);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(728, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(138, 40);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgListePrescription);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(20, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(866, 411);
            panel3.TabIndex = 1;
            // 
            // dtgListePrescription
            // 
            dtgListePrescription.AllowUserToAddRows = false;
            dtgListePrescription.AllowUserToDeleteRows = false;
            dtgListePrescription.BackgroundColor = Color.White;
            dtgListePrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListePrescription.Columns.AddRange(new DataGridViewColumn[] { IDE, Medicament, Dosage, Instruction, Duree, ConsultationId, etat });
            dtgListePrescription.Dock = DockStyle.Fill;
            dtgListePrescription.GridColor = Color.WhiteSmoke;
            dtgListePrescription.Location = new Point(0, 0);
            dtgListePrescription.MultiSelect = false;
            dtgListePrescription.Name = "dtgListePrescription";
            dtgListePrescription.ReadOnly = true;
            dtgListePrescription.Size = new Size(866, 411);
            dtgListePrescription.TabIndex = 8;
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
            // btn_fermer
            // 
            btn_fermer.BackColor = Color.FromArgb(255, 82, 82);
            btn_fermer.FlatAppearance.BorderSize = 0;
            btn_fermer.FlatStyle = FlatStyle.Flat;
            btn_fermer.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_fermer.ForeColor = Color.White;
            btn_fermer.Image = (Image)resources.GetObject("btn_fermer.Image");
            btn_fermer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fermer.Location = new Point(16, 5);
            btn_fermer.Name = "btn_fermer";
            btn_fermer.Size = new Size(107, 30);
            btn_fermer.TabIndex = 4;
            btn_fermer.Text = "Fermer";
            btn_fermer.TextAlign = ContentAlignment.MiddleRight;
            btn_fermer.UseVisualStyleBackColor = false;
            btn_fermer.Click += btn_fermer_Click;
            // 
            // ListPrescriptionPassees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 531);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ListPrescriptionPassees";
            Text = "Liste des prescriptions passées";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgListePrescription).EndInit();
            ResumeLayout(false);
        }

        private void StyleDataGridView(DataGridView dgv)
        {

            // Style général
            dgv.BackgroundColor = Color.White;

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
        #endregion
        private Panel panel1;
        private Panel panel2;
     
        private Panel panel3;
        private DataGridView dtgListePrescription;
        private DataGridViewTextBoxColumn IDE;
        private DataGridViewTextBoxColumn Medicament;
        private DataGridViewTextBoxColumn Dosage;
        private DataGridViewTextBoxColumn Instruction;
        private DataGridViewTextBoxColumn Duree;
        private DataGridViewTextBoxColumn ConsultationId;
        private DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.Button btn_fermer;
    }
}