using CleanArchitectureSGCP.Core.Entities; // Importation des entités principales du projet
using MetroFramework.Forms; // Utilisation de MetroFramework pour une interface utilisateur moderne

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Prescription
{
    // Fenêtre d'affichage des détails d'une prescription
    public partial class View_prescription : MetroForm
    {
        // Stockage de la prescription sélectionnée
        Prescription _prescription;

        // Constructeur qui reçoit une prescription à afficher
        public View_prescription(Prescription prescription)
        {
            _prescription = prescription; // Stocke la prescription reçue
            InitializeComponent(); // Initialise les composants de l'interface
            DisplayInf(); // Affiche les informations de la prescription
        }

        // Gestionnaire pour fermer la fenêtre en cas d'annulation
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme la fenêtre
        }

        // Méthode pour afficher les informations de la prescription
        private void DisplayInf()
        {
            // Remplit les champs de texte avec les informations de la prescription
            TxtDosage.Text = _prescription.Dosage; // Affiche le dosage
            TxtDuree.Text = _prescription.Duree; // Affiche la durée
            TxtInstruction.Text = _prescription.Instruction; // Affiche les instructions
            TxtMedicament.Text = _prescription.Medicament; // Affiche le médicament
        }
    }
}
