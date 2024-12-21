// Importation des bibliothèques nécessaires
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour les services de gestion
using MetroFramework.Forms; // Formulaires modernes avec MetroFramework

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Fom_Consultation
{
    // Classe pour afficher l'historique des consultations d'un patient. Hérite de MetroForm.
    public partial class History_Consultation : MetroForm
    {
        // Déclaration des services pour la gestion des patients, des dossiers médicaux et des consultations
        private readonly IGestionPatientService _gestionPatientService; // Gestion des patients
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService; // Gestion des dossiers médicaux
        private readonly IGestionConsultationsService _gestionConsultationsService; // Gestion des consultations

        // Instance du patient dont l'historique des consultations sera affiché
        Core.Entities.Patient _patient;

        // Constructeur avec injection des dépendances nécessaires
        public History_Consultation(Core.Entities.Patient patient, IGestionConsultationsService gestionConsultationsService)
        {
            // Désactiver le bouton Maximiser et centrer la fenêtre lors de son affichage
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialisation des variables avec les données fournies
            _patient = patient; // Stocke l'objet Patient
            _gestionConsultationsService = gestionConsultationsService; // Stocke le service des consultations

            // Initialisation des composants graphiques
            InitializeComponent();

            // Chargement des informations du patient dans les champs
            InitFichePatient();

            // Chargement des consultations dans le tableau
            LoadConsultation();

            // Applique un style personnalisé au DataGridView
            StyleDataGridView(dtgConsultationHistorytList);
        }

        // Méthode pour afficher les informations du patient sélectionné
        private void InitFichePatient()
        {
            // Vérifie si l'objet Patient n'est pas nul
            if (_patient != null)
            {
                // Remplit les champs avec les informations du patient
                TxtNom.Text = _patient.Nom; // Nom
                TxtPrenom.Text = _patient.Prenom; // Prénom
                TxtAddresse.Text = _patient.Addresse; // Adresse
                TxtCourriel.Text = _patient.AddresseCourriel; // Courriel

                // Formate et affiche la date de naissance au format AAAA/MM/JJ
                TxtDate.Text = _patient.DateDeNaissance.ToString("yyyy/MM/dd"); // Correction du format pour afficher correctement la date

                TxtTelephone.Text = _patient.NumeroTelephones; // Numéro de téléphone
            }
        }

        // Méthode pour charger les consultations dans le DataGridView
        private async void LoadConsultation()
        {
            // Charge la liste des consultations associées au patient via son ID
            var consultations = await _gestionConsultationsService.GetConsultationsByPatientIdAsync(_patient.Id);

            // Vérifie si des consultations existent
            if (consultations != null && consultations.Any())
            {
                // Réinitialise les données existantes dans le DataGridView
                dtgConsultationHistorytList.DataSource = null;

                // Recharge les consultations dans le DataGridView
                dtgConsultationHistorytList.DataSource = consultations;

                // Rafraîchit l'affichage pour montrer les nouvelles données
                dtgConsultationHistorytList.Refresh();

                // Désactive la génération automatique des colonnes pour un contrôle personnalisé
                dtgConsultationHistorytList.AutoGenerateColumns = false;

                // Désélectionne toutes les lignes au démarrage
                dtgConsultationHistorytList.ClearSelection();
            }
            else
            {
                // Affiche un message si aucune consultation n'est disponible pour ce patient
                MessageBox.Show("La liste de consultations de ce patient est vide.",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        // Méthode pour fermer la fenêtre lorsque le bouton "Fermer" est cliqué
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme simplement la fenêtre
        }
    }
}
