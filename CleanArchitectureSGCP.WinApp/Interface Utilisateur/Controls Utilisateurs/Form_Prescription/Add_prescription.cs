// Importation des bibliothèques nécessaires
using CleanArchitectureSGCP.Core.Entities; // Modèles d'entités
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour la gestion des données
using MetroFramework.Forms; // Pour un style Metro moderne


namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Prescription
{
    // Classe pour ajouter une prescription à une consultation
    public partial class Add_prescription : MetroForm
    {
        // Déclaration des services nécessaires
        private readonly IGestionConsultationsService _gestionConsultationsService; // Service de gestion des consultations

        // Consultation associée à la prescription
        Consultation _consultation;

        // Constructeur avec injection de dépendances
        public Add_prescription(IGestionConsultationsService gestionConsultationsService, Consultation consultation)
        {
            // Initialisation des dépendances
            _gestionConsultationsService = gestionConsultationsService ?? throw new ArgumentNullException(nameof(gestionConsultationsService));
            _consultation = consultation ?? throw new ArgumentNullException(nameof(consultation));

            // Configuration du formulaire
            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.StartPosition = FormStartPosition.CenterScreen; // Centre le formulaire au démarrage

            // Initialiser les composants graphiques
            InitializeComponent();
        }

        // Bouton pour sauvegarder la prescription
        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // **1. Validation des champs obligatoires**
                if (string.IsNullOrWhiteSpace(Medicament?.Text) ||
                    string.IsNullOrWhiteSpace(Dosage?.Text) ||
                    string.IsNullOrWhiteSpace(Duree?.Text) ||
                    string.IsNullOrWhiteSpace(Instruction?.Text))
                {
                    MessageBox.Show("Tous les champs sont obligatoires.",
                                    "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Arrête l'exécution si les champs ne sont pas valides
                }

                // **2. Création et assignation de l'objet Prescription**
                Prescription prescription = new Prescription
                {
                    Medicament = Medicament.Text, // Nom du médicament
                    Dosage = Dosage.Text, // Dosage prescrit
                    Duree = Duree.Text, // Durée de la prescription
                    Instruction = Instruction.Text, // Instructions associées
                    etat = 1, // État par défaut (1 = en cours)
                };

                // **3. Récupérer la consultation associée et ajouter la prescription**
                var consultationUpdate = await _gestionConsultationsService.GetByIdAsync(_consultation.Id);

                if (consultationUpdate == null) // Vérifie si la consultation existe
                {
                    MessageBox.Show("Consultation introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ajouter la prescription à la consultation
                consultationUpdate.AddPrescription(prescription);

                // **4. Mettre à jour la consultation avec la prescription**
                await _gestionConsultationsService.UpdateConsultationAsync(consultationUpdate);

                // **5. Confirmation et fermeture**
                MessageBox.Show("La prescription a été ajoutée avec succès.", "Succès",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Indiquer que l'opération a réussi
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
