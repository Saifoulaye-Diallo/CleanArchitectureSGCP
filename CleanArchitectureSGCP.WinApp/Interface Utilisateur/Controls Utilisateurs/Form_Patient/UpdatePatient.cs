// Importation des bibliothèques nécessaires
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour la gestion des données
using MetroFramework.Forms; // Bibliothèque pour les formulaires stylisés MetroFramework


namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Patient
{
    // Classe pour la mise à jour des informations d'un patient
    public partial class UpdatePatient : MetroForm
    {
        // Services nécessaires
        private readonly IGestionPatientService _gestionPatientService; // Gestion des patients

        // Patient sélectionné
        CleanArchitectureSGCP.Core.Entities.Patient _patient;

        // Constructeur avec injection des dépendances
        public UpdatePatient(IGestionPatientService gestionPatientService, CleanArchitectureSGCP.Core.Entities.Patient patient)
        {
            // Initialisation des composants graphiques
            InitializeComponent();

            // Injection des services et initialisation des données
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));
            _patient = patient ?? throw new ArgumentNullException(nameof(patient));

            // Configuration du formulaire
            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.MinimizeBox = true;  // Garde le bouton Minimiser activé
            this.StartPosition = FormStartPosition.CenterScreen; // Centre la fenêtre à l'ouverture

            // Chargement des données du patient
            LoadPatientData();
        }

        // Chargement des informations du patient dans les champs
        private void LoadPatientData()
        {
            Nom.Text = _patient.Nom; // Remplit le champ Nom
            Prenom.Text = _patient.Prenom; // Remplit le champ Prénom
            Telephone.Text = _patient.NumeroTelephones; // Remplit le champ Téléphone
            Adresse.Text = _patient.Addresse; // Remplit le champ Adresse
            Courriel.Text = _patient.AddresseCourriel; // Remplit le champ Courriel
            Date.Value = _patient.DateDeNaissance; // Remplit le champ Date de naissance
        }

        // Bouton pour sauvegarder les modifications
        private async void btn_save_Click(object sender, EventArgs e)
        {
            // **1. Validation des champs obligatoires**
            if (string.IsNullOrWhiteSpace(Nom?.Text) ||
                string.IsNullOrWhiteSpace(Prenom?.Text) ||
                string.IsNullOrWhiteSpace(Telephone?.Text) ||
                string.IsNullOrWhiteSpace(Adresse?.Text) ||
                string.IsNullOrWhiteSpace(Courriel?.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires.",
                                "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Arrête l'exécution si les champs ne sont pas valides
            }

            try
            {
                // **2. Récupération et mise à jour des informations du patient**
                CleanArchitectureSGCP.Core.Entities.Patient patient = await _gestionPatientService.GetPatientByIdAsync(_patient.Id);

                // Mise à jour des propriétés avec les nouvelles valeurs
                patient.Nom = Nom.Text;
                patient.Prenom = Prenom.Text;
                patient.DateDeNaissance = Date.Value;
                patient.NumeroTelephones = Telephone.Text;
                patient.Addresse = Adresse.Text;
                patient.AddresseCourriel = Courriel.Text;

                // **3. Enregistrement dans la base de données**
                await _gestionPatientService.UpdatePatientAsync(patient);

                // **4. Affichage de confirmation et fermeture du formulaire**
                MessageBox.Show("Patient mis à jour avec succès !",
                                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Retourne un succès au formulaire parent
                this.DialogResult = DialogResult.OK;
                this.Close(); // Ferme le formulaire
            }
            catch (Exception ex)
            {
                // **Gestion des erreurs**
                MessageBox.Show($"Erreur lors de la mise à jour du patient : {ex.Message}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton pour annuler les modifications et fermer le formulaire
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme la fenêtre sans sauvegarder
        }
    }
}
