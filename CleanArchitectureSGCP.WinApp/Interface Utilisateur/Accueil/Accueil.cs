using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Fom_Consultation;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Patient;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Form_Prescription;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using System.Windows.Forms;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Accueil
{

    public partial class Accueil : MetroForm
    {
        private readonly IGestionPatientService _gestionPatientService;
        private readonly IGestionMedecinService _gestionMedecinService;
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService;
        private readonly IGestionConsultationsService _gestionConsultationsService;
        private readonly IGestionPrescriptionService _gestionPrescriptionService;
        public Accueil(IGestionPatientService gestionPatientService, IGestionMedecinService gestionMedecinService, IGestionDossierMedicalService gestionDossierMedicalService, IGestionConsultationsService gestionConsultationsService, IGestionPrescriptionService gestionPrescriptionService)
        {
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));
            _gestionMedecinService = gestionMedecinService ?? throw new ArgumentNullException(nameof(gestionMedecinService));
            _gestionDossierMedicalService = gestionDossierMedicalService;
            _gestionConsultationsService = gestionConsultationsService;
            _gestionPrescriptionService = gestionPrescriptionService;
            InitializeComponent();

            // Applique un thème clair Metro
            this.Theme = MetroThemeStyle.Light;
            this.Style = MetroColorStyle.Blue;

            // Initialiser le Panel pour les UserControls
            InitializePanelContainer();

            // Ajouter les icônes aux éléments du MenuStrip
            AjouterIconesMenu();

            // Styliser le MenuStrip
            StyleMenuStrip(MenuPrincipatl);
            this.Text = "SGCP";


            this.FormClosed += MainForm_FormClosed;
           
        }

        private void InitializePanelContainer()
        {


            // Ajouter le Panel au formulaire
            // this.Controls.Add(PannelPrincipal);

            // Charger un UserControl par défaut
            // LoadUserControl(new UC_Accueil());
        }

        private void AjouterIconesMenu()
        {
            // Exemple d'ajout d'icônes aux éléments du menu
            gestionDesPatientsToolStripMenuItem.Image = Properties.Resources.gestion_hospitalisation;

            gestionDossierMedicalToolStripMenuItem.Image = Properties.Resources.destion_dossier_medical_icon;

            gestionDesConsultationsToolStripMenuItem.Image = Properties.Resources.gestion_consultation;

            gestionDesPrescritptionToolStripMenuItem.Image = Properties.Resources.gestion_prescription_icon;
        }

        private void StyleMenuStrip(MenuStrip menu)
        {
            menu.BackColor = Color.White;
            menu.ForeColor = Color.Black;
            menu.RenderMode = ToolStripRenderMode.Professional;

            foreach (ToolStripMenuItem menuItem in menu.Items)
            {
                StyleMenuItems(menuItem);
            }
        }

        private void StyleMenuItems(ToolStripMenuItem menuItem)
        {
            menuItem.ForeColor = Color.Black;
            menuItem.BackColor = Color.White;

            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem)
                {
                    subItem.ForeColor = Color.Black;
                    subItem.BackColor = Color.White;

                    ToolStripMenuItem subMenuItem = (ToolStripMenuItem)subItem;
                    subMenuItem.MouseEnter += (s, e) => subMenuItem.BackColor = Color.LightGray;
                    subMenuItem.MouseLeave += (s, e) => subMenuItem.BackColor = Color.White;
                }
            }
        }

        // Méthode pour charger un UserControl dans le PannelPrincipal
        private void LoadUserControl(UserControl uc)
        {
            PannelPrincipal.Controls.Clear(); // Vider le contenu actuel
            PannelPrincipal.Controls.Add(uc); // Ajouter le UserControl
            uc.Dock = DockStyle.Fill;                        // uc.Dock = DockStyle.Fill; // Remplir tout l'espace disponible
        }


        private void gestionDesPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listPatients = new ListPatients(_gestionMedecinService, _gestionPatientService);
            LoadUserControl(listPatients);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gestionDesConsultationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listPatientConsultation = new List_Patient_Consultation(_gestionMedecinService, _gestionPatientService, _gestionDossierMedicalService, _gestionConsultationsService);
            LoadUserControl(listPatientConsultation);
        }

        private void gestionDesPrescritptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionPrescription = new Form_gestion_Prescription(_gestionPatientService,_gestionMedecinService,_gestionConsultationsService,_gestionPrescriptionService);
            LoadUserControl(gestionPrescription);
        }
    }
}
