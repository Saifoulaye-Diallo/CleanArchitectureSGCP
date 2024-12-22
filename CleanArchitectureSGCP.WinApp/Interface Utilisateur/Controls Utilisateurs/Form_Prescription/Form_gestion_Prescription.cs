using Azure;
using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.Core.Services;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Prescription;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private readonly IGestionPrescriptionService _gestionPrescriptionService;
        Core.Entities.Patient _patient = null;
        Consultation _consultation = null;
        Prescription _prescription = null;
        public Form_gestion_Prescription(IGestionPatientService gestionPatientService, IGestionMedecinService gestionMedecinService, IGestionConsultationsService gestionConsultationsService, IGestionPrescriptionService gestionPrescriptionService)
        {
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService;
            _gestionConsultationsService = gestionConsultationsService;
            _gestionPrescriptionService = gestionPrescriptionService;

            InitializeComponent();
            // Charger les données du dtgListPatient
            LoadPatients();
            dtgPatientList.MultiSelect = false; // Empêche la sélection multiple
            dtgPatientList.AutoGenerateColumns = false; // Désactive la génération automatique des colonnes
            StyleDataGridView(dtgPatientList); // Applique un style personnalisé au DataGridView
            tabControlGestionPrescription.Selecting += DisableTabPrescription;
            tabControlGestionPrescription.Selecting += DisableTabConsultation;
        }

        private void dtgPaitentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _consultation = null;
            _prescription = null;
            // Vérifiez que la ligne cliquée est valide (évitez les clics sur les en-têtes)
            if (e.RowIndex >= 0)
            {
                // Récupérer la première ligne sélectionnée
                DataGridViewRow row = dtgPatientList.Rows[e.RowIndex];

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


                _patient = _patientSelect;

                LoadConsultation(_patient.Id);
                dtgConsultationHistorytList.ClearSelection();
                btn_consultation.Enabled = true;

            }

        }

        private void dtgConulationtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _prescription = null;
            // Vérifiez que la ligne cliquée est valide (évitez les clics sur les en-têtes)
            if (e.RowIndex >= 0)
            {
                // Récupérer la ligne correspondante
                DataGridViewRow row = dtgConsultationHistorytList.Rows[e.RowIndex];
                // Créer et remplir l'objet Consultation de manière sécurisée
                Consultation consultation = new Consultation
                {
                    Id = row.Cells["IDConsultation"].Value != null ? Convert.ToInt32(row.Cells["IDConsultation"].Value) : 0,
                    Motif = row.Cells["Motif"].Value?.ToString(),
                    Diagnostic = row.Cells["Diagnostic"].Value?.ToString(),
                    Observation = row.Cells["Observation"].Value?.ToString(),
                    Date = row.Cells["Date"].Value != null
                        ? Convert.ToDateTime(row.Cells["Date"].Value)
                        : DateTime.MinValue // Défaut si la date est absente
                };

                // Activer le bouton de prescription
                _consultation = consultation;
                LoadPresciption(_consultation.Id);
                dtgListePrescription.ClearSelection();
                btn_prescriptions.Enabled = true;
            }
        }

        private void dtgPrescriptionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez que la ligne cliquée est valide (évitez les clics sur les en-têtes)
            if (e.RowIndex >= 0 && e.RowIndex < dtgListePrescription.Rows.Count) // Vérification supplémentaire
            {
                try
                {
                    // Récupérer la ligne sélectionnée
                    DataGridViewRow row = dtgListePrescription.Rows[e.RowIndex];

                    // Vérifiez si les cellules sont valides avant d'accéder à leurs valeurs
                    Prescription prescription = new Prescription
                    {
                        Id = row.Cells["IDE"].Value != null && int.TryParse(row.Cells["IDE"].Value.ToString(), out int id) ? id : 0,
                        Medicament = row.Cells["Medicament"].Value?.ToString() ?? string.Empty,
                        Dosage = row.Cells["Dosage"].Value?.ToString() ?? string.Empty,
                        Duree = row.Cells["Duree"].Value?.ToString() ?? string.Empty,
                        Instruction = row.Cells["Instruction"].Value?.ToString() ?? string.Empty,
                        etat = row.Cells["etat"].Value != null && int.TryParse(row.Cells["etat"].Value.ToString(), out int etat) ? etat : 0,
                    };

                    // Mise à jour de la prescription sélectionnée
                    _prescription = prescription;

                    // Activer les boutons associés
                    btn_cloturer_prescription.Enabled = true;
                    btn_consulter_prescription.Enabled = true;
                }
                catch (Exception ex)
                {
                    // Gestion de l'erreur et affichage d'un message utilisateur
                    MessageBox.Show($"Erreur lors du traitement de la sélection : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Désactiver les boutons si aucune ligne valide n'est sélectionnée
                btn_cloturer_prescription.Enabled = false;
                btn_consulter_prescription.Enabled = false;
            }
        }


        private void DisableTabPrescription(object sender, TabControlCancelEventArgs e)
        {
            // Vérifiez si l'onglet sélectionné est "tabConsultation"
            if (e.TabPage == tabPrescription)
            {
                if (_consultation == null)
                {
                    MessageBox.Show(
                        "Veuillez sélectionner une consultation.", // Texte du message
                        "Avertissement",                           // Titre de la fenêtre
                        MessageBoxButtons.OK,                      // Boutons affichés
                        MessageBoxIcon.Warning                     // Icône d'avertissement
                    );
                    e.Cancel = true;
                }

            }
        }
        private void DisableTabConsultation(object sender, TabControlCancelEventArgs e)
        {
            // Vérifiez si l'onglet sélectionné est "tabConsultation"
            if (e.TabPage == tabConsultation)
            {
                if (_patient == null)
                {
                    MessageBox.Show(
                        "Veuillez sélectionner une fiche patient.", // Texte du message
                        "Avertissement",                           // Titre de la fenêtre
                        MessageBoxButtons.OK,                      // Boutons affichés
                        MessageBoxIcon.Warning                     // Icône d'avertissement
                    );

                    // Annuler le changement d'onglet
                    e.Cancel = true;
                }

            }
        }
        private async void LoadPatients()
        {
            try
            {
                // Désélectionner toutes les cellules après le chargement
                var medecinId = Session.Instance.Medecin.Id;

                // Charger la liste des patients
                var patients = await _gestionPatientService.GetPatientsByMedecinIdAsync(medecinId);

                // Définir les données dans le DataGridView
                dtgPatientList.DataSource = patients;

                // Désactiver l'ajout automatique des colonnes
                dtgPatientList.AutoGenerateColumns = false;

                // Appliquer un style personnalisé
                StyleDataGridView(dtgPatientList);

                // Désactiver le bouton par défaut
                btn_consultation.Enabled = false;

                // Désélectionner toutes les lignes après chargement
                dtgPatientList.ClearSelection();

                // Réinitialise et recharge les données dans le DataGridView
                dtgPatientList.DataSource = null;
                dtgPatientList.DataSource = patients;
                dtgPatientList.Refresh(); // Rafraîchit l'affichage

              
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show($"Erreur lors du chargement des patients : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadConsultation(int idPatient)
        {
            InitFichePatient();
            btn_prescriptions.Enabled = false;
            try
            {
                // Charger les consultations si le dossier médical existe
                var consultations = await _gestionConsultationsService.GetConsultationsByPatientIdAsync(idPatient);

                if (consultations != null)
                {
                    dtgConsultationHistorytList.DataSource = consultations; // Rechargez les données
                    dtgConsultationHistorytList.ClearSelection();
                    dtgConsultationHistorytList.MultiSelect = false;
                    dtgConsultationHistorytList.AutoGenerateColumns = false;
                    StyleDataGridView(dtgConsultationHistorytList);

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
        private async void LoadPresciption(int consultationId)
        {
            StyleDataGridView(dtgListePrescription);
            try
            {
                // Initialisation de la fiche consultation
                InitFicheConsultation();

                // Désactiver les boutons avant chargement
                btn_cloturer_prescription.Enabled = false;
                btn_consulter_prescription.Enabled = false;

                // Préparer la configuration avant d'affecter les données
                dtgListePrescription.AutoGenerateColumns = false; // Important : placé avant le DataSource
                dtgListePrescription.ClearSelection();

                // Charger les prescriptions de manière asynchrone
                var prescriptions = await _gestionPrescriptionService.GetPrescriptionsByConsultationIdAsync(consultationId);

                // Vérification des données récupérées
                if (prescriptions == null || prescriptions.Count == 0)
                {
                    dtgListePrescription.DataSource = null; // Vide la table
                }
                else
                {
                    dtgListePrescription.DataSource = prescriptions;
                    StyleDataGridView(dtgListePrescription); // Appliquer les styles
                }

                // Finaliser la configuration après chargement
                dtgListePrescription.Refresh();
                dtgListePrescription.ClearSelection();
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show($"Erreur lors du chargement des prescriptions : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                TxtDate.Text = _patient.DateDeNaissanceFormatee;
                TxtTelephone.Text = _patient.NumeroTelephones;
            }
        }
        private void InitFicheConsultation()
        {
            if (_consultation != null)
            {
                TxtDateConsultation.Text = _consultation.Date.ToString("yyy/MM/dd");
                TxtDiagnostic.Text = _consultation.Diagnostic;
                TxtMotif.Text = _consultation.Motif;
                TxtObservation.Text = _consultation.Observation;
            }
        }

        private void btn_consultation_Click(object sender, EventArgs e)
        {
            tabControlGestionPrescription.SelectedTab = tabConsultation;
        }
        private void ConvertEtat(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Vérifiez si la colonne correspond à "etat"
            if (dtgListePrescription.Columns[e.ColumnIndex].Name == "etat")
            {
                if (e.Value != null && e.Value.ToString() == "1")
                {
                    e.Value = "En cours"; // Afficher "En cours" au lieu de "1"
                    e.FormattingApplied = true; // Indique que le formatage est appliqué
                }
                else if (e.Value != null && e.Value.ToString() == "0")
                {
                    e.Value = "Cloturée"; // Afficher "En cours" au lieu de "1"
                    e.FormattingApplied = true; // Indique que le formatage est appliqué
                }
            }
        }

        private void btn_prescription_Click(object sender, EventArgs e)
        {
            tabControlGestionPrescription.SelectedTab = tabPrescription;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btn_cloturer_prescription_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                                   "Voulez-vous vraiment clôturer cette prescription ?", // Message
                                                   "Confirmation", // Titre
                                                   MessageBoxButtons.YesNo, // Boutons Oui/Non
                                                   MessageBoxIcon.Question // Icône de question
                                               );

            if (result == DialogResult.Yes)
            {
                var prescription = await _gestionPrescriptionService.GetPrescriptionByIdAsync(_prescription.Id);
                prescription.etat = 0;
                await _gestionPrescriptionService.UpdatePrescriptionAsync(prescription);
                LoadPresciption(_consultation.Id);
                MessageBox.Show($"Prescription clôturée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Action annulée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ajouter_prescription_Click(object sender, EventArgs e)
        {
            var addPrescription = new Add_prescription(_gestionConsultationsService, _consultation);

            var result = addPrescription.ShowDialog();
            if (result == DialogResult.OK)
            {
                dtgListePrescription.DataSource = null;
                LoadPresciption(_consultation.Id); // Recharger les patients après ajout
                dtgListePrescription.Refresh();
                dtgListePrescription.ClearSelection();
            }
        }

        private void btn_consulter_prescription_Click(object sender, EventArgs e)
        {
            var showPrescription = new View_prescription(_prescription);

            showPrescription.ShowDialog();
        }
    }
}
