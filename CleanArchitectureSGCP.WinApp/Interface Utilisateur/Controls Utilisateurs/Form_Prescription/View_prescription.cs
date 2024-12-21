using CleanArchitectureSGCP.Core.Entities;
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

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Prescription
{
    public partial class View_prescription : MetroForm
    {
        Prescription _prescription;
        public View_prescription(Prescription prescription)
        {
            _prescription = prescription;
            InitializeComponent();
            DisplayInf();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayInf()
        {
            TxtDosage.Text = _prescription.Dosage;
            TxtDuree.Text = _prescription.Duree;
            TxtInstruction.Text = _prescription.Instruction;
            TxtMedicament.Text = _prescription.Medicament;
        }
    }
}
