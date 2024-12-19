using MetroFramework;
using System.Windows.Forms;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Patient
{
    partial class ListPatients
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPatients));
            panel_Titre = new Panel();
            lbl_GestionPatient = new Label();
            pannell_bas_page = new Panel();
            panelBoutons = new Panel();
            btn_ajouter = new Button();
            btn_Modifier = new Button();
            btn_consulter = new Button();
            panel_List = new Panel();
            dtgPatientList = new DataGridView();
            nom = new DataGridViewTextBoxColumn();
            Dossier = new DataGridViewTextBoxColumn();
            prenom = new DataGridViewTextBoxColumn();
            dateDeNaissance = new DataGridViewTextBoxColumn();
            adresse = new DataGridViewTextBoxColumn();
            telephone = new DataGridViewTextBoxColumn();
            courriel = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            patientBindingSource = new BindingSource(components);
            panel_Titre.SuspendLayout();
            pannell_bas_page.SuspendLayout();
            panelBoutons.SuspendLayout();
            panel_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPatientList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
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
            lbl_GestionPatient.Text = "Gestion des Patients";
            lbl_GestionPatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pannell_bas_page
            // 
            pannell_bas_page.BackColor = Color.White;
            pannell_bas_page.Controls.Add(panelBoutons);
            pannell_bas_page.Dock = DockStyle.Bottom;
            pannell_bas_page.Location = new Point(0, 664);
            pannell_bas_page.Name = "pannell_bas_page";
            pannell_bas_page.Size = new Size(1228, 43);
            pannell_bas_page.TabIndex = 1;
            // 
            // panelBoutons
            // 
            panelBoutons.BackColor = Color.White;
            panelBoutons.Controls.Add(btn_ajouter);
            panelBoutons.Controls.Add(btn_Modifier);
            panelBoutons.Controls.Add(btn_consulter);
            panelBoutons.Dock = DockStyle.Right;
            panelBoutons.Location = new Point(731, 0);
            panelBoutons.Name = "panelBoutons";
            panelBoutons.Size = new Size(497, 43);
            panelBoutons.TabIndex = 3;
            // 
            // btn_ajouter
            // 
            btn_ajouter.BackColor = Color.FromArgb(76, 175, 80);
            btn_ajouter.FlatAppearance.BorderSize = 0;
            btn_ajouter.FlatStyle = FlatStyle.Flat;
            btn_ajouter.Font = new Font("Segoe UI", 14F);
            btn_ajouter.ForeColor = Color.White;
            btn_ajouter.Image = (Image)resources.GetObject("btn_ajouter.Image");
            btn_ajouter.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ajouter.Location = new Point(20, 6);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(115, 30);
            btn_ajouter.TabIndex = 0;
            btn_ajouter.Text = "Ajouter";
            btn_ajouter.TextAlign = ContentAlignment.MiddleRight;
            btn_ajouter.UseVisualStyleBackColor = false;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // btn_Modifier
            // 
            btn_Modifier.BackColor = Color.FromArgb(255, 152, 0);
            btn_Modifier.FlatAppearance.BorderSize = 0;
            btn_Modifier.FlatStyle = FlatStyle.Flat;
            btn_Modifier.Font = new Font("Segoe UI", 14F);
            btn_Modifier.ForeColor = Color.White;
            btn_Modifier.Image = (Image)resources.GetObject("btn_Modifier.Image");
            btn_Modifier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Modifier.Location = new Point(180, 6);
            btn_Modifier.Name = "btn_Modifier";
            btn_Modifier.Size = new Size(120, 30);
            btn_Modifier.TabIndex = 1;
            btn_Modifier.Text = "Modifier";
            btn_Modifier.TextAlign = ContentAlignment.MiddleRight;
            btn_Modifier.UseVisualStyleBackColor = false;
            btn_Modifier.Click += btn_Modifier_Click;
            // 
            // btn_consulter
            // 
            btn_consulter.BackColor = Color.FromArgb(33, 150, 243);
            btn_consulter.FlatAppearance.BorderSize = 0;
            btn_consulter.FlatStyle = FlatStyle.Flat;
            btn_consulter.Font = new Font("Segoe UI", 14F);
            btn_consulter.ForeColor = Color.White;
            btn_consulter.Image = (Image)resources.GetObject("btn_consulter.Image");
            btn_consulter.ImageAlign = ContentAlignment.MiddleLeft;
            btn_consulter.Location = new Point(340, 6);
            btn_consulter.Name = "btn_consulter";
            btn_consulter.Size = new Size(135, 30);
            btn_consulter.TabIndex = 2;
            btn_consulter.Text = "Consulter";
            btn_consulter.TextAlign = ContentAlignment.MiddleRight;
            btn_consulter.UseVisualStyleBackColor = false;
            btn_consulter.Click += btn_consulter_Click;
            // 
            // panel_List
            // 
            panel_List.Controls.Add(dtgPatientList);
            panel_List.Dock = DockStyle.Fill;
            panel_List.Location = new Point(0, 40);
            panel_List.Name = "panel_List";
            panel_List.Size = new Size(1228, 624);
            panel_List.TabIndex = 3;
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
            dtgPatientList.Name = "dtgPatientList";
            dtgPatientList.Size = new Size(1228, 624);
            dtgPatientList.TabIndex = 0;
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
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Core.Entities.Patient);
            // 
            // ListPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_List);
            Controls.Add(pannell_bas_page);
            Controls.Add(panel_Titre);
            Name = "ListPatients";
            Size = new Size(1228, 707);
            panel_Titre.ResumeLayout(false);
            pannell_bas_page.ResumeLayout(false);
            panelBoutons.ResumeLayout(false);
            panel_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgPatientList).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
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
        private DataGridView dtgPatientList;
        private BindingSource patientBindingSource;
        private Button btn_consulter;
        private Panel panelBoutons;
        private Button btn_ajouter;
        private Button btn_Modifier;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn Dossier;
        private DataGridViewTextBoxColumn prenom;
        private DataGridViewTextBoxColumn dateDeNaissance;
        private DataGridViewTextBoxColumn adresse;
        private DataGridViewTextBoxColumn telephone;
        private DataGridViewTextBoxColumn courriel;
        private DataGridViewTextBoxColumn ID;
    }
}
