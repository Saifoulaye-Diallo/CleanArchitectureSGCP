namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Accueil
{
    partial class Accueil
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
            MenuPrincipatl = new MenuStrip();
            gestionDesPatientsToolStripMenuItem = new ToolStripMenuItem();
            gestionDossierMedicalToolStripMenuItem = new ToolStripMenuItem();
            gestionDesConsultationsToolStripMenuItem = new ToolStripMenuItem();
            gestionDesPrescritptionToolStripMenuItem = new ToolStripMenuItem();
            PannelPrincipal = new Panel();
            MenuPrincipatl.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPrincipatl
            // 
            MenuPrincipatl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuPrincipatl.Items.AddRange(new ToolStripItem[] { gestionDesPatientsToolStripMenuItem, gestionDossierMedicalToolStripMenuItem, gestionDesConsultationsToolStripMenuItem, gestionDesPrescritptionToolStripMenuItem });
            MenuPrincipatl.Location = new Point(20, 60);
            MenuPrincipatl.Name = "MenuPrincipatl";
            MenuPrincipatl.Size = new Size(1228, 29);
            MenuPrincipatl.TabIndex = 0;
            MenuPrincipatl.Text = "menuStrip1";
            // 
            // gestionDesPatientsToolStripMenuItem
            // 
            gestionDesPatientsToolStripMenuItem.Name = "gestionDesPatientsToolStripMenuItem";
            gestionDesPatientsToolStripMenuItem.Size = new Size(165, 25);
            gestionDesPatientsToolStripMenuItem.Text = "Gestion des Patients ";
            gestionDesPatientsToolStripMenuItem.Click += gestionDesPatientsToolStripMenuItem_Click;
            // 
            // gestionDossierMedicalToolStripMenuItem
            // 
            gestionDossierMedicalToolStripMenuItem.Name = "gestionDossierMedicalToolStripMenuItem";
            gestionDossierMedicalToolStripMenuItem.Size = new Size(234, 25);
            gestionDossierMedicalToolStripMenuItem.Text = "Gestion des dossiers medicaux";
            // 
            // gestionDesConsultationsToolStripMenuItem
            // 
            gestionDesConsultationsToolStripMenuItem.Name = "gestionDesConsultationsToolStripMenuItem";
            gestionDesConsultationsToolStripMenuItem.Size = new Size(199, 25);
            gestionDesConsultationsToolStripMenuItem.Text = "Gestion des consultations";
            gestionDesConsultationsToolStripMenuItem.Click += gestionDesConsultationsToolStripMenuItem_Click;
            // 
            // gestionDesPrescritptionToolStripMenuItem
            // 
            gestionDesPrescritptionToolStripMenuItem.Name = "gestionDesPrescritptionToolStripMenuItem";
            gestionDesPrescritptionToolStripMenuItem.Size = new Size(202, 25);
            gestionDesPrescritptionToolStripMenuItem.Text = "Gestion des prescritptions";
            gestionDesPrescritptionToolStripMenuItem.Click += gestionDesPrescritptionToolStripMenuItem_Click;
            // 
            // PannelPrincipal
            // 
            PannelPrincipal.BackColor = Color.FromArgb(224, 224, 224);
            PannelPrincipal.Dock = DockStyle.Fill;
            PannelPrincipal.Location = new Point(20, 89);
            PannelPrincipal.Name = "PannelPrincipal";
            PannelPrincipal.Size = new Size(1228, 720);
            PannelPrincipal.TabIndex = 1;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 829);
            Controls.Add(PannelPrincipal);
            Controls.Add(MenuPrincipatl);
            MainMenuStrip = MenuPrincipatl;
            Name = "Accueil";
            Text = "Accueil";
            MenuPrincipatl.ResumeLayout(false);
            MenuPrincipatl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPrincipatl;
        private ToolStripMenuItem gestionDesPatientsToolStripMenuItem;
        private ToolStripMenuItem gestionDossierMedicalToolStripMenuItem;
        private ToolStripMenuItem gestionDesConsultationsToolStripMenuItem;
        private ToolStripMenuItem gestionDesPrescritptionToolStripMenuItem;
        private Panel PannelPrincipal;
    }
}