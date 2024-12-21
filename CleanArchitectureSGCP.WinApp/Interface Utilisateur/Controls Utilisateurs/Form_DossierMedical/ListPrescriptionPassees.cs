using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
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

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_DossierMedical
{
    public partial class ListPrescriptionPassees : MetroForm
    {
        private readonly IGestionPrescriptionService _gestionPrescriptionService;
        Core.Entities.Patient _patient;
        public ListPrescriptionPassees(IGestionPrescriptionService gestionPrescriptionService, Core.Entities.Patient patient)
        {
            InitializeComponent();
            _gestionPrescriptionService = gestionPrescriptionService;
            _patient = patient;
            LoadPresciption(_patient.Id);
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

        private async void LoadPresciption(int patientIdd)
        {
            var prescriptions = await _gestionPrescriptionService.GetPrescriptionsPasseesByPatientIdAsync(patientIdd);
            dtgListePrescription.DataSource = prescriptions; // Rechargez les données
            dtgListePrescription.ClearSelection();
            dtgListePrescription.AutoGenerateColumns = false;
            StyleDataGridView(dtgListePrescription);
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
