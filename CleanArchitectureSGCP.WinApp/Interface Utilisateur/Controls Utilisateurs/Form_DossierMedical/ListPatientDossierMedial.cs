// Importation des bibliothèques nécessaires
using CleanArchitectureSGCP.Core.Entities; // Modèles d'entités
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour les services


namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_DossierMedical
{
    // Classe pour afficher la liste des patients et leurs dossiers médicaux
    public partial class ListPatientDossierMedial : UserControl
    {
        // Déclaration des services nécessaires pour la gestion des données
        private readonly IGestionPatientService _gestionPatientService; // Gestion des patients
        private readonly IGestionPrescriptionService _gestionPrescriptionService; // Gestion des prescriptions

        // Instance du patient sélectionné
        CleanArchitectureSGCP.Core.Entities.Patient _patient;

        // Constructeur avec injection des dépendances
        public ListPatientDossierMedial(
            IGestionMedecinService gestionMedecinService,
            IGestionPatientService gestionPatientService,
            IGestionPrescriptionService gestionPrescriptionService)
        {
            // Initialisation des services
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));
            _gestionPrescriptionService = gestionPrescriptionService;

            // Initialisation des composants graphiques
            InitializeComponent();

            // Configuration du DataGridView
            dtgPatientList.MultiSelect = false; // Empêche la sélection multiple
            dtgPatientList.AutoGenerateColumns = false; // Désactive la génération automatique des colonnes
            StyleDataGridView(dtgPatientList); // Applique un style personnalisé au DataGridView

            // Chargement des patients
            LoadPatients();

            // Abonnement aux événements
            dtgPatientList.SelectionChanged += DtgPatientList_SelectionChanged;
        }

        // Méthode pour charger la liste des patients dans le DataGridView
        private async void LoadPatients()
        {
            // Récupère l'ID du médecin connecté
            var medecinId = Session.Instance.Medecin.Id;

            // Charge la liste des patients associés au médecin
            var patients = await _gestionPatientService.GetPatientsByMedecinIdAsync(medecinId);

            // Mise à jour des données dans le DataGridView
            dtgPatientList.DataSource = null; // Réinitialisation
            dtgPatientList.DataSource = patients; // Rechargement des données
            dtgPatientList.Refresh(); // Rafraîchissement de l'affichage

            // Désélectionne toutes les lignes après chargement
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
                // Désactive le bouton de prescription
                btn_prescriptions.Enabled = false;
                _patient = null; // Réinitialise l'objet patient
                return;
            }

            // Récupère la première ligne sélectionnée
            DataGridViewRow row = dtgPatientList.SelectedRows[0];

            // Crée un nouvel objet Patient à partir des données de la ligne sélectionnée
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

            // Mise à jour de l'objet patient
            _patient = _patientSelect;

            // Active le bouton de prescription
            btn_prescriptions.Enabled = true;
        }

        // Événement appelé lors du changement de sélection dans le DataGridView
        private void DtgPatientList_SelectionChanged(object sender, EventArgs e)
        {
            VerifierSelection(); // Vérifie la sélection actuelle
        }

        // Gestion du clic sur le bouton "Fermer"
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Ferme complètement l'application
        }

        // Gestion du clic sur le bouton "Prescriptions"
        private void btn_prescriptions_Click(object sender, EventArgs e)
        {
            // Ouvre la fenêtre des prescriptions passées pour le patient sélectionné
            var traitementpasse = new ListPrescriptionPassees(_gestionPrescriptionService, _patient);
            traitementpasse.ShowDialog();
        }
    }
}
