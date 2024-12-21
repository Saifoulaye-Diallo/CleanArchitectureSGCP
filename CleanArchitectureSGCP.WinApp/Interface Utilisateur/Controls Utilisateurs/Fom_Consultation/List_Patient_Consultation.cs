// Importation des bibliothèques nécessaires
using CleanArchitectureSGCP.Core.Entities; // Entités du domaine
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour la gestion des données


namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Fom_Consultation
{
    // Classe pour gérer la liste des patients et leurs consultations
    public partial class List_Patient_Consultation : UserControl
    {
        // Déclaration des services nécessaires
        private readonly IGestionMedecinService _gestionMedecinService; // Gestion des médecins
        private readonly IGestionPatientService _gestionPatientService; // Gestion des patients
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService; // Gestion des dossiers médicaux
        private readonly IGestionConsultationsService _gestionConsultationService; // Gestion des consultations

        // Instance du patient sélectionné
        Core.Entities.Patient _patient;

        // Constructeur avec injection des dépendances
        public List_Patient_Consultation(
            IGestionMedecinService gestionMedecinService,
            IGestionPatientService gestionPatientService,
            IGestionDossierMedicalService gestionDossierMedicalService,
            IGestionConsultationsService gestionConsultationService)
        {
            // Initialisation des services
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));
            _gestionDossierMedicalService = gestionDossierMedicalService;
            _gestionConsultationService = gestionConsultationService;

            // Initialisation des composants graphiques
            InitializeComponent();

            // Chargement des données des patients
            LoadPatients();

            // Configuration du DataGridView
            dtgPatientList.MultiSelect = false; // Empêche la sélection multiple
            dtgPatientList.AutoGenerateColumns = false; // Désactive la génération automatique des colonnes
            StyleDataGridView(dtgPatientList); // Applique un style personnalisé au DataGridView

            // Abonne les événements au DataGridView
            dtgPatientList.SelectionChanged += DtgPatientList_SelectionChanged;
        }

        // Méthode pour charger la liste des patients dans le DataGridView
        private async void LoadPatients()
        {
            // Récupère l'ID du médecin connecté
            var medecinId = Session.Instance.Medecin.Id;

            // Charge les patients associés au médecin
            var patients = await _gestionPatientService.GetPatientsByMedecinIdAsync(medecinId);

            // Réinitialise et recharge les données dans le DataGridView
            dtgPatientList.DataSource = null;
            dtgPatientList.DataSource = patients;
            dtgPatientList.Refresh(); // Rafraîchit l'affichage

            // Désélectionne toutes les lignes après le chargement
            dtgPatientList.ClearSelection();
            dtgPatientList.AutoGenerateColumns = false;
            dtgPatientList.ClearSelection();
        }

        // Vérifie la sélection actuelle dans le DataGridView
        private void VerifierSelection()
        {
            // Si aucune ligne n'est sélectionnée
            if (dtgPatientList.SelectedRows.Count == 0)
            {
                // Désactiver les boutons d'action
                btn_consulter_historique.Enabled = false;
                btn_ajouter_consultation.Enabled = false;
                _patient = null; // Réinitialiser l'objet Patient
                return;
            }

            // Récupérer la ligne sélectionnée
            DataGridViewRow row = dtgPatientList.SelectedRows[0];

            // Crée un nouvel objet Patient avec les données sélectionnées
            CleanArchitectureSGCP.Core.Entities.Patient _patientSelect = new CleanArchitectureSGCP.Core.Entities.Patient
            {
                Id = (int)row.Cells["ID"].Value,
                Nom = row.Cells["Nom"].Value?.ToString(),
                Prenom = row.Cells["Prenom"].Value?.ToString(),
                Addresse = row.Cells["adresse"].Value?.ToString(),
                AddresseCourriel = row.Cells["Courriel"].Value?.ToString(),
                NumeroTelephones = row.Cells["Telephone"].Value?.ToString(),
                DateDeNaissance = row.Cells["DateDeNaissance"].Value is DateTime date ? date : DateTime.MinValue
            };

            // Met à jour l'objet Patient
            _patient = _patientSelect;

            // Active les boutons
            btn_consulter_historique.Enabled = true;
            btn_ajouter_consultation.Enabled = true;
        }

        // Événement appelé lors du changement de sélection dans le DataGridView
        private void DtgPatientList_SelectionChanged(object sender, EventArgs e)
        {
            VerifierSelection(); // Vérifie la nouvelle sélection
        }

        // Gestion du clic sur "Ajouter Consultation"
        private void btn_ajouter_consultation_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire d'ajout de consultation
            var addConsultation = new Add_Consultation(_gestionPatientService, _patient, _gestionDossierMedicalService);
            var result = addConsultation.ShowDialog();

            // Recharge la liste des patients après ajout
            if (result == DialogResult.OK)
            {
                LoadPatients();
                dtgPatientList.ClearSelection();
            }
        }

        // Gestion du clic sur "Consulter Historique"
        private void btn_consulter_historique_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire d'historique des consultations
            var historyConsultation = new History_Consultation(_patient, _gestionConsultationService);
            var result = historyConsultation.ShowDialog();

            // Recharge la liste des patients après consultation
            if (result == DialogResult.OK)
            {
                LoadPatients();
                dtgPatientList.ClearSelection();
            }
        }

        // Gestion du clic sur "Fermer"
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Ferme complètement l'application
        }
    }
}
