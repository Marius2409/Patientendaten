using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geschäftslogik;

namespace Patientendaten_Projekt
{
    public partial class Ausgeben : Form
    {
        public Ausgeben()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoadTermine(List<Termin> termine) //Methode an Steuerelement zuweisen
        {
            //dataGridView1.DataSource = termine;
        }

        //Daten per Datagrid ausgeben
        //Bearbeiten der Daten sollte ebenso möglich sein
    }
}
