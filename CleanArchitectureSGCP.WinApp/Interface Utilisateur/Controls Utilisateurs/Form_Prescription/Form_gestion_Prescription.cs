using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Form_Prescription
{
    public partial class Form_gestion_Prescription : UserControl
    {
        private readonly IGestionMedecinService _gestionMedecinService;
        private readonly IGestionPatientService _gestionPatientService;
        private readonly IGestionConsultationsService _gestionConsultationsService;
        Core.Entities.Patient _patient = null;
        Consultation _consultation;
        public Form_gestion_Prescription(IGestionPatientService gestionPatientService, IGestionMedecinService gestionMedecinService, IGestionConsultationsService gestionConsultationsService)
        {
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService;
            _gestionConsultationsService = gestionConsultationsService;
            // Sélectionner par défaut l'onglet "Patients"
            //tabControlGestionPrescription.SelectedTab = tablistePatients;
            InitializeComponent();
            // Charger les données du dtgListPatient
            LoadPatients();

            dtgPatientList.MultiSelect = false;
            dtgPatientList.AutoGenerateColumns = false;
            StyleDataGridView(dtgPatientList);
            StyleDataGridView(dtgConsultationHistorytList);
            //dtgPatientList.ClearSelection(); // Désactive la sélection

            // Abonner les événements
            dtgPatientList.SelectionChanged += DtgPatientList_SelectionChanged;

        }
        private void tablistePatients_Click(object sender, EventArgs e)
        {
            // var listPatient = new ListPatient_Prescription()
        }
        private void TabControlGestionPrescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlGestionPrescription.SelectedTab == tablistePatients)
            {
                LoadPatients();
            }

        }
        private async void LoadPatients()
        {
            // Désélectionner toutes les cellules après le chargement
            var medecinId = Session.Instance.Medecin.Id;
            // Charger la liste des patients
            var patients = await _gestionPatientService.GetPatientsByMedecinIdAsync(medecinId);

            dtgPatientList.DataSource = patients; // Rechargez les données
            //dtgPatientList.ClearSelection();
            dtgPatientList.AutoGenerateColumns = false;
        }

        private void VerifierSelectionDTGClient()
        {
            // Si aucune ligne n'est sélectionnée
            if (dtgPatientList.SelectedRows.Count == 0)
            {
                btn_consultation.Enabled = false;
                btn_prescription.Enabled = false;
                _patient = null; // Réinitialiser l'objet patient
                return;
            }
            else
            {
                // Récupérer la première ligne sélectionnée
                DataGridViewRow row = dtgPatientList.SelectedRows[0];

                // Créer et remplir l'objet Patient
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

                //LoadConsultation();
                _patient = _patientSelect;
               
                // Activer les boutons
                btn_consultation.Enabled = true;
                // Réafficher un onglet
            }

        }

        private void VerifierSelectDtgConsultation()
        {
            if (dtgConsultationHistorytList.SelectedRows.Count == 0)
            {
                btn_prescription.Enabled = false;
                return;
            }
            else
            {
                btn_prescription.Enabled = true;
                // Récupérer la première ligne sélectionnée
                DataGridViewRow row = dtgPatientList.SelectedRows[0];

                Consultation consultation = new Consultation
                {
                    Id = (int)row.Cells["ID"].Value,
                    Motif = row.Cells["Motif"].Value?.ToString(),
                    Diagnostic = row.Cells["Diagnostic"].Value?.ToString(),
                    Observation = row.Cells["Observation"].Value?.ToString(),
                    Date = (DateTime)row.Cells["Diagnostic"].Value,
                };
            }
        }

        private void DtgPatientList_SelectionChanged(object sender, EventArgs e)
        {
            VerifierSelectionDTGClient();
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Initialisation des donnees du patient choisi
        private void InitFichePatient()
        {
            if (_patient != null)
            {
                TxtNom.Text = _patient.Nom;
                TxtPrenom.Text = _patient.Prenom;
                TxtAddresse.Text = _patient.Addresse;
                TxtCourriel.Text = _patient.AddresseCourriel;
                TxtDate.Text = _patient.DateDeNaissance.ToString("AAAA/MM/JJ");
                TxtTelephone.Text = _patient.NumeroTelephones;
            }
        }


        // Charger la liste des patients dans un DataGridView
        private async void LoadConsultation()
        {
            InitFichePatient();
            try
            {
                // Charger les consultations si le dossier médical existe
                var consultations = await _gestionConsultationsService.GetConsultationsByPatientIdAsync(_patient.Id);

                if (consultations != null)
                {
                    dtgConsultationHistorytList.DataSource = null; // Réinitialisez
                    dtgConsultationHistorytList.DataSource = consultations; // Rechargez les données
                    dtgConsultationHistorytList.Refresh(); // Rafraîchissez l'affichage
                    dtgConsultationHistorytList.ClearSelection();
                    dtgConsultationHistorytList.MultiSelect = false;
                    dtgConsultationHistorytList.AutoGenerateColumns = false;
                    StyleDataGridView(dtgConsultationHistorytList);
                    dtgConsultationHistorytList.ClearSelection(); // Désactive la sélection
                }
                else
                {
                    // Si aucune consultation n'existe pour ce patient
                    MessageBox.Show("La liste de consultations de ce patient est vide.", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Gestion des exceptions
                MessageBox.Show($"Une erreur s'est produite lors du chargement des consultations : {ex.Message}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_consultation_Click(object sender, EventArgs e)
        {
            LoadConsultation();
            tabControlGestionPrescription.SelectedTab = tabConsultation;
        }
    }
}
