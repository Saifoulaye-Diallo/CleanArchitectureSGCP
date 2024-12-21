// Importation des bibliothèques nécessaires
using MetroFramework.Forms; // Pour des formulaires stylisés avec MetroFramework
using System; // Types et opérations de base
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Gestion des bases de données
using System.Drawing; // Gestion des couleurs et graphismes
using System.Linq;
using System.Text;
using System.Threading.Tasks; // Gestion des tâches asynchrones
using System.Windows.Forms; // Contrôles Windows Forms

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Patient
{
    // Classe pour afficher les informations d'un patient en mode consultation
    public partial class ViewPatient : MetroForm
    {
        // Déclaration d'une variable pour stocker le patient
        CleanArchitectureSGCP.Core.Entities.Patient _patient;

        // Constructeur avec paramètre (Patient sélectionné)
        public ViewPatient(Core.Entities.Patient patient)
        {
            // Initialisation des composants graphiques
            InitializeComponent();

            // Configuration de la fenêtre
            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.StartPosition = FormStartPosition.CenterScreen; // Centre le formulaire à l'ouverture

            // Affectation du patient à la variable locale
            _patient = patient ?? throw new ArgumentNullException(nameof(patient)); // Vérifie que le patient n'est pas nul

            // Affichage des données
            DisplayData();
        }

        // Méthode pour afficher les informations du patient
        public void DisplayData()
        {
            try
            {
                // **Remplissage des champs avec les données du patient**
                TxtNom.Text = _patient.Nom; // Nom
                TxtPrenom.Text = _patient.Prenom; // Prénom
                TxtAdresse.Text = _patient.Addresse; // Adresse
                TxtCourriel.Text = _patient.AddresseCourriel; // Courriel

                // **Formatage de la date de naissance en AAAA/MM/JJ**
                TxtDate.Text = _patient.DateDeNaissance.ToString("yyyy/MM/dd"); // Format standardisé

                TxtTelephone.Text = _patient.NumeroTelephones; // Téléphone
            }
            catch (Exception ex)
            {
                // Gestion des erreurs lors de l'affichage des données
                MessageBox.Show($"Erreur lors de l'affichage des données : {ex.Message}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton pour fermer la fenêtre
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme la fenêtre
        }
    }
}
