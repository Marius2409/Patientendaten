using Geschäftslogik;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Anlegen_Click(object sender, EventArgs e)
        {
            //Öffnen Anlegen --> schließen Home
            Anlegen fs = new Anlegen
            {
                Visible = true
            };
            this.Visible = false;
        }

        private void Ausgeben_Click(object sender, EventArgs e)
        {

            //Öffnen Ausgben --> schließen Home
            Ausgeben fs = new Ausgeben
            {         
                Visible = true
            };
            this.Visible = false;
        }
    }
}
