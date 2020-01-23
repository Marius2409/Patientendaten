using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientendaten_Projekt
{
    public partial class Form1 : Form
    {
        public Form1(Patient patient, List<Termin> termine)
        {
            InitializeComponent();
            LoadPatient(patient);
            LoadTermine(termine);
        }

        private void LoadPatient(Patient patient)
        {

        }
        private void LoadTermine(List<Termin> termine)
        {
            dataGridView1.DataSource = termine;
        }
    }
}
