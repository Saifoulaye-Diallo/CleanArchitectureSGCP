// Importation des bibliothèques et espaces de noms nécessaires
using CleanArchitectureSGCP.Core.Entities; // Modèles d'entités utilisés
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour les services
using MetroFramework.Forms; // Formulaires stylisés avec MetroFramework

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Fom_Consultation
{
    // Classe pour ajouter une consultation. Hérite de MetroForm pour un style moderne.
    public partial class Add_Consultation : MetroForm
    {
        // Déclaration des services nécessaires pour la gestion des données
        private readonly IGestionPatientService _gestionPatientService; // Service pour la gestion des patients
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService; // Service pour la gestion des dossiers médicaux

        // Instance du patient pour lequel la consultation sera ajoutée
        Core.Entities.Patient _patient;

        // Constructeur avec injection des dépendances nécessaires
        public Add_Consultation(
            IGestionPatientService gestionPatientService,
            Core.Entities.Patient patient,
            IGestionDossierMedicalService gestionDossierMedicalService)
        {
            // Configurations initiales de la fenêtre
            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.StartPosition = FormStartPosition.CenterScreen; // Centre la fenêtre à l'ouverture

            // Initialisation des services injectés et du patient
            _gestionPatientService = gestionPatientService;
            _patient = patient;
            _gestionDossierMedicalService = gestionDossierMedicalService;

            // Initialisation des composants graphiques
            InitializeComponent();

            // Chargement des informations du patient
            InitFichePatient();
        }

        // Méthode pour afficher les informations du patient sélectionné
        private void InitFichePatient()
        {
            // Vérifie si l'objet patient est valide
            if (_patient != null)
            {
                // Remplit les champs avec les informations du patient
                TxtNom.Text = _patient.Nom;
                TxtPrenom.Text = _patient.Prenom;
                TxtAddresse.Text = _patient.Addresse;
                TxtCourriel.Text = _patient.AddresseCourriel;

                // Formate la date au format AAAA/MM/JJ
                TxtDate.Text = _patient.DateDeNaissance.ToString("yyyy/MM/dd");

                TxtTelephone.Text = _patient.NumeroTelephones;
            }
        }

        // Gestion du clic sur le bouton "Annuler"
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme simplement la fenêtre sans rien enregistrer
        }

        // Gestion du clic sur le bouton "Enregistrer"
        private async void btn_save_Click(object sender, EventArgs e)
        {
            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(Txt_motif.Text) ||
                string.IsNullOrWhiteSpace(Txt_obsevation?.Text) ||
                string.IsNullOrWhiteSpace(Txt_diagnostic?.Text))
            {
                // Affiche un message d'erreur si un champ est vide
                MessageBox.Show("Tous les champs sont obligatoires.",
                                "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Arrête l'exécution si validation échoue
            }

            // Crée une nouvelle instance de Consultation avec les données saisies
            Core.Entities.Consultation consultation = new Core.Entities.Consultation
            {
                Diagnostic = Txt_diagnostic.Text, // Récupère le diagnostic
                Motif = Txt_motif.Text, // Récupère le motif
                Observation = Txt_obsevation.Text, // Récupère l'observation
                Date = DateTime.Now // Définit la date actuelle
            };

            // Ajoute la consultation à la session en cours
            Session.Instance.AddConsultation(consultation);

            // Récupère les informations mises à jour sur le patient
            Core.Entities.Patient patient = await _gestionPatientService.GetPatientByIdAsync(_patient.Id);

            // Si le patient est valide
            if (patient != null)
            {
                // Récupère le dossier médical associé au patient
                Core.Entities.DossierMedical dossierMedical = await _gestionDossierMedicalService.GetDossierMedicalByPatientIdAsync(patient.Id);

                // Ajoute la consultation au dossier médical
                dossierMedical.AddConsultation(consultation);

                // Enregistre les modifications dans la base de données
                await _gestionDossierMedicalService.UpdateDossierMedicalAsync(dossierMedical);

                // Affiche un message de succès
                MessageBox.Show("La consultation a été ajoutée avec succès",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Définit le résultat de la boîte de dialogue sur OK
            this.DialogResult = DialogResult.OK;

            // Ferme la fenêtre après l'enregistrement
            this.Close();
        }
    }
}
