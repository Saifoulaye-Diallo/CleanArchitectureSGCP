using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Prescription
{
    public partial class Add_prescription : MetroForm
    {
        private readonly IGestionConsultationsService _gestionConsultationsService;
        Consultation _consultation;
        public Add_prescription(IGestionConsultationsService gestionConsultationsService,Consultation consultation)
        {
            _gestionConsultationsService = gestionConsultationsService;
            _consultation = consultation;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
          try
            {

                // Vérification des champs obligatoires
                if (string.IsNullOrWhiteSpace(Medicament?.Text) || string.IsNullOrWhiteSpace(Dosage?.Text) ||
                    string.IsNullOrWhiteSpace(Duree?.Text) || string.IsNullOrWhiteSpace(Instruction?.Text) )
                {
                    MessageBox.Show("Tous les champs sont obligatoires.",
                                    "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Création et assignation de l'objet Patient
                Prescription prescription = new Prescription
                {
                    Medicament = Medicament.Text,
                    Dosage = Dosage.Text,
                    Duree = Duree.Text,
                    Instruction = Instruction.Text,
                    etat = 1,

                };
                var consultationUpdate = await _gestionConsultationsService.GetByIdAsync(_consultation.Id);
                consultationUpdate.AddPrescription(prescription);
                await _gestionConsultationsService.UpdateConsultationAsync(consultationUpdate);

                MessageBox.Show("La presciption a été ajouté avec succès.", "Succès",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                // Indiquer que l'opération a réussi
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
