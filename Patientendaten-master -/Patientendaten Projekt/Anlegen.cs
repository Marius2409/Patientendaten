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
using Datenbank;
using System.Data.Linq;
using System.Data.SqlClient;

namespace Patientendaten_Projekt
{
    public partial class Anlegen : Form
    {
        public Anlegen()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoadPatient(Patient patient) //Methode an Steuerelement zuweisen
        {
            //TB Einträge in DB einfügen 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Krankenkasse = rTBKrankenkasse.Text;
            int Versicherungsnummer = Convert.ToInt32(rTBVersicherungsnummer.Text);
            string Vorname = rTBVorname.Text;
            string Nachname = rTBNachname.Text;
            string Strasse_Nr = rTBStraßeNr.Text;
            string Geburtsdatum = rTBGeburtsdatum.Text;
            int Telefonnummer = Convert.ToInt32(rTBTelefon.Text);
            string Besonderheiten = rTBBesonderheiten.Text;
            string PLZ_Ort = rTBPLZOrt.Text;


        }

        

        //Pflichtfelder definieren, validität einfügen

    }
}
