// Importation des bibliothèques et espaces de noms nécessaires
using CleanArchitectureSGCP.Core.Entities; // Modèles d'entités du domaine
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour les services de gestion
using MetroFramework.Forms; // Formulaires stylisés avec MetroFramework

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Accueil
{
    // Déclaration de la classe LoginForm qui hérite de MetroForm pour appliquer un style moderne
    public partial class LoginForm : MetroForm
    {
        // Déclaration des services nécessaires pour la gestion des fonctionnalités
        private readonly IGestionMedecinService _gestionMedecinService; // Gestion des médecins
        private readonly IGestionPatientService _gestionPatientService; // Gestion des patients
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService; // Gestion des dossiers médicaux
        private readonly IGestionConsultationsService _gestionConsultationsService; // Gestion des consultations
        private readonly IGestionPrescriptionService _gestionPrescriptionService; // Gestion des prescriptions

        // Constructeur avec injection des dépendances pour les services
        public LoginForm(
            IGestionMedecinService gestionMedecinService,
            IGestionPatientService gestionPatientService,
            IGestionDossierMedicalService gestionDossierMedicalService,
            IGestionConsultationsService gestionConsultationsService,
            IGestionPrescriptionService gestionPrescriptionService)
        {
            // Initialisation des services avec injection de dépendances
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService;
            _gestionDossierMedicalService = gestionDossierMedicalService;
            _gestionConsultationsService = gestionConsultationsService;
            _gestionPrescriptionService = gestionPrescriptionService;

            // Initialisation des composants graphiques
            InitializeComponent();
        }

        // Gestion du clic sur le bouton "Connexion"
        private async void Btn_Connexion_Click(object sender, EventArgs e)
        {
            // Désactiver le bouton pour éviter des clics multiples pendant le traitement
            Btn_Connexion.Enabled = false;
            try
            {
                // Récupérer les informations saisies par l'utilisateur
                var nomUtilisateur = TxtUserName.Text; // Nom d'utilisateur
                var motDePasse = TxtPassword.Text;     // Mot de passe

                // Vérifier les informations d'identification avec le service des médecins
                var resultat = await _gestionMedecinService.ConnexionAdync(nomUtilisateur, motDePasse);

                // Si les informations sont valides
                if (resultat != null)
                {
                    // Vérifie si une session existe
                    if (Session.Instance != null)
                    {
                        // Ouvre la fenêtre principale (Accueil) avec les services injectés
                        var accueil = new Accueil(
                            _gestionPatientService,
                            _gestionMedecinService,
                            _gestionDossierMedicalService,
                            _gestionConsultationsService,
                            _gestionPrescriptionService);

                        accueil.Show(); // Affiche la fenêtre principale
                        this.Hide();    // Cache la fenêtre de connexion
                    }
                }
                else
                {
                    // Affiche un message d'erreur si l'authentification échoue
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.",
                                    "Erreur",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            finally
            {
                // Réactive le bouton de connexion après le traitement
                Btn_Connexion.Enabled = true;
            }
        }

        // Gestion du clic sur le bouton "Fermer"
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre actuelle
            this.Close();

            // Ferme complètement l'application
            Application.Exit();
        }
    }
}
