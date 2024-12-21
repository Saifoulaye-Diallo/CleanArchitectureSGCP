// Importation des bibliothèques nécessaires
using CleanArchitectureSGCP.Core.Entities; // Modèles d'entités
using CleanArchitectureSGCP.Core.Interfaces; // Interfaces pour la gestion des données
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Patient; // Formulaires patients
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm; // Gestion des patients

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Patient
{
    // Classe pour afficher la liste des patients et gérer leurs informations
    public partial class ListPatients : UserControl
    {
        // Déclaration des services nécessaires
        private readonly IGestionMedecinService _gestionMedecinService;
        private readonly IGestionPatientService _gestionPatientService;

        // Variable pour stocker le patient sélectionné
        CleanArchitectureSGCP.Core.Entities.Patient _patient;

        // Constructeur avec injection des services
        public ListPatients(IGestionMedecinService gestionMedecinService, IGestionPatientService gestionPatientService)
        {
            // Initialisation des dépendances
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));

            // Initialiser les composants graphiques
            InitializeComponent();

            // Configuration du DataGridView
            dtgPatientList.MultiSelect = false; // Empêche la sélection multiple
            dtgPatientList.AutoGenerateColumns = false; // Désactive la génération automatique des colonnes
            StyleDataGridView(dtgPatientList); // Applique un style personnalisé au tableau

            // Chargement des données patients
            LoadPatients();

            // Abonnement à l'événement de sélection
            dtgPatientList.SelectionChanged += DtgPatientList_SelectionChanged;
        }

        // Chargement des patients dans le DataGridView
        private async void LoadPatients()
        {
            try
            {
                // Récupérer l'ID du médecin connecté
                var medecinId = Session.Instance.Medecin.Id;

                // Charger la liste des patients associés au médecin
                var patients = await _gestionPatientService.GetPatientsByMedecinIdAsync(medecinId);

                // Mettre à jour le DataGridView
                dtgPatientList.DataSource = null; // Réinitialiser les données
                dtgPatientList.DataSource = patients; // Affecter les données
                dtgPatientList.Refresh(); // Rafraîchir l'affichage
                dtgPatientList.ClearSelection(); // Désélectionner toutes les lignes
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des patients : {ex.Message}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton pour ajouter un nouveau patient
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            var addPatientForm = new AddPatient(_gestionMedecinService);

            // Afficher le formulaire d'ajout et vérifier si l'ajout est réussi
            var result = addPatientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadPatients(); // Recharger la liste des patients
                dtgPatientList.ClearSelection(); // Désélectionner toutes les lignes
            }
        }

        // Bouton pour modifier un patient existant
        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (_patient != null) // Vérifie qu'un patient est sélectionné
            {
                // Ouvrir la fenêtre de modification
                var upDatePatientForm = new UpdatePatient(_gestionPatientService, _patient);
                var result = upDatePatientForm.ShowDialog();

                // Recharger la liste après modification
                if (result == DialogResult.OK)
                {
                    LoadPatients();
                    dtgPatientList.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un patient à modifier !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Vérifie si une ligne est sélectionnée dans le DataGridView
        private void VerifierSelection()
        {
            if (dtgPatientList.SelectedRows.Count == 0)
            {
                // Désactiver les boutons si aucune ligne n'est sélectionnée
                btn_consulter.Enabled = false;
                btn_Modifier.Enabled = false;
                _patient = null;
                return;
            }

            // Récupérer la ligne sélectionnée et remplir l'objet patient
            DataGridViewRow row = dtgPatientList.SelectedRows[0];

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

            _patient = _patientSelect;

            // Activer les boutons
            btn_consulter.Enabled = true;
            btn_Modifier.Enabled = true;
        }

        // Gérer le changement de sélection dans le DataGridView
        private void DtgPatientList_SelectionChanged(object sender, EventArgs e)
        {
            VerifierSelection(); // Vérifie si une ligne est sélectionnée
        }

        // Bouton pour consulter les informations d'un patient
        private void btn_consulter_Click(object sender, EventArgs e)
        {
            if (_patient != null)
            {
                var viewPatientForm = new ViewPatient(_patient);
                viewPatientForm.ShowDialog();
            }
        }

        // Bouton pour fermer l'application
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Ferme complètement l'application
        }
    }
}
