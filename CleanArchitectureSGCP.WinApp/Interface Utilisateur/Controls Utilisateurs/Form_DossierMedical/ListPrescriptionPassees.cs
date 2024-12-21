using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour les services
using MetroFramework.Forms; // Bibliothèque pour les formulaires stylisés MetroFramework


namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_DossierMedical
{
    // Classe pour afficher la liste des prescriptions passées d'un patient
    public partial class ListPrescriptionPassees : MetroForm
    {
        // Déclaration des services et variables nécessaires
        private readonly IGestionPrescriptionService _gestionPrescriptionService; // Gestion des prescriptions
        Core.Entities.Patient _patient; // Patient sélectionné

        // Constructeur avec injection des dépendances
        public ListPrescriptionPassees(
            IGestionPrescriptionService gestionPrescriptionService,
            Core.Entities.Patient patient)
        {
            // Initialisation des composants graphiques
            InitializeComponent();

            // Initialisation des services et des données
            _gestionPrescriptionService = gestionPrescriptionService;
            _patient = patient;

            // Chargement des prescriptions passées
            LoadPresciption(_patient.Id);
        }

        // Méthode pour formater l'état des prescriptions dans le DataGridView
        private void ConvertEtat(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Vérifie si la colonne est "etat"
            if (dtgListePrescription.Columns[e.ColumnIndex].Name == "etat")
            {
                // Si la valeur est "1", affiche "En cours"
                if (e.Value != null && e.Value.ToString() == "1")
                {
                    e.Value = "En cours";
                    e.FormattingApplied = true; // Indique que le formatage est appliqué
                }
                // Si la valeur est "0", affiche "Cloturée"
                else if (e.Value != null && e.Value.ToString() == "0")
                {
                    e.Value = "Cloturée";
                    e.FormattingApplied = true;
                }
            }
        }

        // Méthode pour charger la liste des prescriptions passées dans le DataGridView
        private async void LoadPresciption(int patientId)
        {
            // Appel asynchrone pour récupérer les prescriptions passées
            var prescriptions = await _gestionPrescriptionService.GetPrescriptionsPasseesByPatientIdAsync(patientId);

            // Met à jour le DataGridView avec les données récupérées
            dtgListePrescription.DataSource = prescriptions;
            dtgListePrescription.ClearSelection(); // Désélectionne toutes les lignes
            dtgListePrescription.AutoGenerateColumns = false; // Désactive la génération automatique des colonnes

            // Applique un style personnalisé au DataGridView
            StyleDataGridView(dtgListePrescription);
        }

        // Gestion du clic sur le bouton "Fermer"
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme la fenêtre
        }
    }
}
