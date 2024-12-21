// Importation des bibliothèques nécessaires
using CleanArchitectureSGCP.Core.Entities; // Entités du domaine
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour la gestion des données
using MetroFramework.Forms; // Bibliothèque MetroFramework pour des formulaires stylisés
using System; // Types et opérations de base
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Gestion des bases de données
using System.Drawing; // Gestion des couleurs et graphismes
using System.Linq;
using System.Text;
using System.Threading.Tasks; // Gestion des tâches asynchrones
using System.Windows.Forms; // Contrôles Windows Forms

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm
{
    // Formulaire pour ajouter un nouveau patient
    public partial class AddPatient : MetroForm
    {
        // Déclaration du service nécessaire pour gérer les médecins
        private readonly IGestionMedecinService _gestionMedecinService;

        // Constructeur avec injection du service
        public AddPatient(IGestionMedecinService gestionMedecinService)
        {
            // Initialisation des composants graphiques
            InitializeComponent();

            // Configuration des paramètres de la fenêtre
            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.StartPosition = FormStartPosition.CenterScreen; // Centre la fenêtre à l'ouverture

            // Injection du service et gestion des dépendances
            _gestionMedecinService = gestionMedecinService ?? throw new ArgumentNullException(nameof(gestionMedecinService));
        }

        // Gestion du bouton "Annuler"
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre avec un résultat d'annulation
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Fonction pour nettoyer les champs après ajout d'un patient
        private void ClearFields()
        {
            Nom.Text = string.Empty; // Efface le champ Nom
            Prenom.Text = string.Empty; // Efface le champ Prénom
            Date.Value = DateTime.Now; // Réinitialise la date à la date actuelle
            Telephone.Text = string.Empty; // Efface le champ Téléphone
            Adresse.Text = string.Empty; // Efface le champ Adresse
            Courriel.Text = string.Empty; // Efface le champ Courriel
        }

        // Gestion du bouton "Enregistrer"
        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // **1. Validation des champs obligatoires**
                if (string.IsNullOrWhiteSpace(Nom?.Text) ||
                    string.IsNullOrWhiteSpace(Prenom?.Text) ||
                    string.IsNullOrWhiteSpace(Telephone?.Text) ||
                    string.IsNullOrWhiteSpace(Adresse?.Text) ||
                    string.IsNullOrWhiteSpace(Courriel?.Text))
                {
                    MessageBox.Show("Tous les champs sont obligatoires.", // Message d'erreur
                                    "Erreur de Validation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Arrête l'exécution si les champs sont invalides
                }

                // **2. Création et assignation d'un nouvel objet Patient**
                CleanArchitectureSGCP.Core.Entities.Patient patient = new CleanArchitectureSGCP.Core.Entities.Patient
                {
                    Nom = Nom.Text, // Affecte le nom
                    Prenom = Prenom.Text, // Affecte le prénom
                    DateDeNaissance = Date?.Value ?? DateTime.Now, // Affecte la date de naissance (par défaut : aujourd'hui)
                    NumeroTelephones = Telephone.Text, // Affecte le numéro de téléphone
                    Addresse = Adresse.Text, // Affecte l'adresse
                    AddresseCourriel = Courriel.Text, // Affecte le courriel
                };

                // **3. Création automatique du dossier médical**
                DossierMedical dossierMedical = new DossierMedical(); // Crée un nouveau dossier médical
                patient.DossierMedical = dossierMedical; // Associe le dossier médical au patient

                // **4. Ajout du patient au médecin connecté**
                Session.Instance.DateDeconnexion = DateTime.Now; // Enregistre la date de déconnexion dans la session
                var medecin = Session.Instance.Medecin; // Récupère l'objet médecin connecté
                medecin.AddPatient(patient); // Ajoute le patient à la liste des patients du médecin

                // **5. Mise à jour des informations du médecin dans la base de données**
                await _gestionMedecinService.UpdateAsync(medecin); // Mise à jour asynchrone des données du médecin dans la base

                // **6. Message de succès et nettoyage**
                MessageBox.Show("Le patient a été ajouté avec succès.", // Message de confirmation
                                "Succès",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                ClearFields(); // Nettoie les champs du formulaire après ajout

                // Indiquer que l'opération a réussi et fermer la fenêtre
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) // Gestion des erreurs
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", // Affiche un message d'erreur
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
