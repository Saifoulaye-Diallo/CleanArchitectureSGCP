using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Patient;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_DossierMedical
{
    partial class ListPatientDossierMedial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPatientDossierMedial));
            panel_Titre = new Panel();
            lbl_GestionPatient = new Label();
            pannell_bas_page = new Panel();
            panelBoutons = new Panel();
            btn_prescriptions = new Button();
            btn_fermer = new Button();
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
            toolTip = new ToolTip(components);
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
            lbl_GestionPatient.Text = "Gestion du dossier medical";
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
            panelBoutons.Controls.Add(btn_prescriptions);
            panelBoutons.Controls.Add(btn_fermer);
            panelBoutons.Dock = DockStyle.Right;
            panelBoutons.Location = new Point(845, 0);
            panelBoutons.Name = "panelBoutons";
            panelBoutons.Size = new Size(383, 43);
            panelBoutons.TabIndex = 3;
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
            btn_prescriptions.Location = new Point(19, 6);
            btn_prescriptions.Name = "btn_prescriptions";
            btn_prescriptions.Size = new Size(221, 30);
            btn_prescriptions.TabIndex = 4;
            btn_prescriptions.Text = "Presciptions passées";
            btn_prescriptions.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_prescriptions, "Cliquez ici pour consulter la fiche du patient selectionnée.");
            btn_prescriptions.UseVisualStyleBackColor = false;
            btn_prescriptions.Click += btn_prescriptions_Click;
            // 
            // btn_fermer
            // 
            btn_fermer.BackColor = Color.FromArgb(255, 82, 82);
            btn_fermer.FlatAppearance.BorderSize = 0;
            btn_fermer.FlatStyle = FlatStyle.Flat;
            btn_fermer.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_fermer.ForeColor = Color.White;
            btn_fermer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fermer.Location = new Point(265, 6);
            btn_fermer.Name = "btn_fermer";
            btn_fermer.Size = new Size(107, 30);
            btn_fermer.TabIndex = 3;
            btn_fermer.Text = "Fermer";
            btn_fermer.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_fermer, "Cliquez ici pour enregistrer l'ajout de la nouvelle consultation.");
            btn_fermer.UseVisualStyleBackColor = false;
            btn_fermer.Click += btn_fermer_Click;
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
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;
            // 
            // ListPatientDossierMedial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_List);
            Controls.Add(pannell_bas_page);
            Controls.Add(panel_Titre);
            Name = "ListPatientDossierMedial";
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

        private Panel panel_Titre;
        private Panel pannell_bas_page;
        private Panel panel_List;
        private Label lbl_GestionPatient;
        private DataGridView dtgPatientList;
        private BindingSource patientBindingSource;
        private Panel panelBoutons;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn Dossier;
        private DataGridViewTextBoxColumn prenom;
        private DataGridViewTextBoxColumn dateDeNaissance;
        private DataGridViewTextBoxColumn adresse;
        private DataGridViewTextBoxColumn telephone;
        private DataGridViewTextBoxColumn courriel;
        private DataGridViewTextBoxColumn ID;
        private Button btn_fermer;
        private ToolTip toolTip;
        private Button btn_prescriptions;
    }
}
