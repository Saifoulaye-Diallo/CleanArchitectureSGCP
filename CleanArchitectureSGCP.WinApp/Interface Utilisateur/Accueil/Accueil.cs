// Importations des bibliothèques et espaces de noms nécessaires
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour les services
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Fom_Consultation; // Gestion des consultations
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_DossierMedical; // Gestion des dossiers médicaux
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Patient; // Gestion des patients
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Form_Prescription; // Gestion des prescriptions
using MetroFramework; // Framework Metro pour les styles
using MetroFramework.Forms; // Formulaires stylisés avec Metro


namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Accueil
{
    // Classe principale héritant de MetroForm pour un style moderne
    public partial class Accueil : MetroForm
    {
        // Déclaration des services nécessaires pour la gestion des données
        private readonly IGestionPatientService _gestionPatientService; // Service pour la gestion des patients
        private readonly IGestionMedecinService _gestionMedecinService; // Service pour la gestion des médecins
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService; // Service pour les dossiers médicaux
        private readonly IGestionConsultationsService _gestionConsultationsService; // Service pour les consultations
        private readonly IGestionPrescriptionService _gestionPrescriptionService; // Service pour les prescriptions

        // Constructeur avec injection des services nécessaires
        public Accueil(
            IGestionPatientService gestionPatientService,
            IGestionMedecinService gestionMedecinService,
            IGestionDossierMedicalService gestionDossierMedicalService,
            IGestionConsultationsService gestionConsultationsService,
            IGestionPrescriptionService gestionPrescriptionService)
        {
            // Initialisation des services avec gestion des erreurs en cas de null
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));
            _gestionMedecinService = gestionMedecinService ?? throw new ArgumentNullException(nameof(gestionMedecinService));
            _gestionDossierMedicalService = gestionDossierMedicalService;
            _gestionConsultationsService = gestionConsultationsService;
            _gestionPrescriptionService = gestionPrescriptionService;

            // Initialisation des composants graphiques
            InitializeComponent();

            // Applique un thème clair et une couleur au formulaire
            this.Theme = MetroThemeStyle.Light;
            this.Style = MetroColorStyle.Blue;

            // Initialiser les composants spécifiques du formulaire
            AjouterIconesMenu();
            StyleMenuStrip(MenuPrincipatl);

            // Définir le titre de la fenêtre
            this.Text = "SGCP";

            // Ajouter un gestionnaire pour fermer l'application lors de la fermeture du formulaire
            this.FormClosed += MainForm_FormClosed;
        }

     

        // Ajoute des icônes aux éléments du menu
        private void AjouterIconesMenu()
        {
            gestionDesPatientsToolStripMenuItem.Image = Properties.Resources.gestion_hospitalisation;
            gestionDossierMedicalToolStripMenuItem.Image = Properties.Resources.destion_dossier_medical_icon;
            gestionDesConsultationsToolStripMenuItem.Image = Properties.Resources.gestion_consultation;
            gestionDesPrescritptionToolStripMenuItem.Image = Properties.Resources.gestion_prescription_icon;
        }

        // Applique un style personnalisé au MenuStrip
        private void StyleMenuStrip(MenuStrip menu)
        {
            menu.BackColor = Color.White;
            menu.ForeColor = Color.Black;
            menu.RenderMode = ToolStripRenderMode.Professional;

            // Applique un style aux sous-menus
            foreach (ToolStripMenuItem menuItem in menu.Items)
            {
                StyleMenuItems(menuItem);
            }
        }

        // Applique un style aux éléments des sous-menus
        private void StyleMenuItems(ToolStripMenuItem menuItem)
        {
            menuItem.ForeColor = Color.Black;
            menuItem.BackColor = Color.White;

            // Gestion des survols pour les sous-menus
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

        // Charge un UserControl dans le panneau principal
        private void LoadUserControl(UserControl uc)
        {
            PannelPrincipal.Controls.Clear(); // Supprime le contenu existant
            PannelPrincipal.Controls.Add(uc); // Ajoute le nouveau contrôle
            uc.Dock = DockStyle.Fill; // Remplit tout l'espace disponible
        }

        // Gestion du clic sur l'élément "Gestion des Patients"
        private void gestionDesPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionDesPatientsToolStripMenuItem.BackColor = Color.LightBlue; // Change la couleur sélectionnée

            var listPatients = new ListPatients(_gestionMedecinService, _gestionPatientService);
            LoadUserControl(listPatients); // Charge la liste des patients
        }

        // Ferme l'application lors de la fermeture du formulaire
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Gestion des consultations
        private void gestionDesConsultationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listPatientConsultation = new List_Patient_Consultation(
                _gestionMedecinService,
                _gestionPatientService,
                _gestionDossierMedicalService,
                _gestionConsultationsService);

            LoadUserControl(listPatientConsultation); // Charge la gestion des consultations
        }

        // Gestion des prescriptions
        private void gestionDesPrescritptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionPrescription = new Form_gestion_Prescription(
                _gestionPatientService,
                _gestionMedecinService,
                _gestionConsultationsService,
                _gestionPrescriptionService);

            LoadUserControl(gestionPrescription);
        }

        // Gestion des dossiers médicaux
        private void gestionDossierMedicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionDossierMedical = new ListPatientDossierMedial(
                _gestionMedecinService,
                _gestionPatientService,
                _gestionPrescriptionService);

            LoadUserControl(gestionDossierMedical);
        }

        // Change la couleur des menus sélectionnés
        private void ChangeMenuColor(ToolStripMenuItem selectedMenu)
        {
            foreach (ToolStripMenuItem item in MenuPrincipatl.Items)
            {
                item.BackColor = Color.White;
                item.ForeColor = Color.Black;
            }

            selectedMenu.BackColor = Color.LightBlue;
            selectedMenu.ForeColor = Color.DarkBlue;
        }

        // Gestion des clics sur les menus
        private void Menu_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem selectedMenu)
            {
                ChangeMenuColor(selectedMenu); // Applique la couleur
            }
        }
    }
}
