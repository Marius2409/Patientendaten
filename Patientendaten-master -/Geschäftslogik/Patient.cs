using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geschäftslogik
{
    public class Patient
    {
        private string krankenkasse;
        private int versichcerungsnummer;
        private string vorname;
        private string vachname;
        private string strasseNr;
        private int plz;
        private DateTime geburtsdatum;
        private string telefon;
        private string besonderheiten;

        public List<Termin> Patientenakte = new List<Termin>();

        public string Krankenkasse { get => krankenkasse; set => krankenkasse = value; }
        public int Versicherungsnummer { get => versichcerungsnummer; set => versichcerungsnummer = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => vachname; set => vachname = value; }
        public string StrasseNr { get => strasseNr; set => strasseNr = value; }
        public int Plz { get => plz; set => plz = value; }
        public DateTime Geburtsdatum { get => geburtsdatum; set => geburtsdatum = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Besonderheiten { get => besonderheiten; set => besonderheiten = value; }

        public Patient(string krankenkasse, int versicherungsnummer, string vorname, string nachname, string strasseNr, int plz, DateTime geburtsdatum, string telefon, string besonderheiten)
        {
            this.Krankenkasse = krankenkasse;
            this.Versicherungsnummer = versicherungsnummer;
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.StrasseNr = strasseNr;
            this.Plz = plz;
            this.Geburtsdatum = geburtsdatum;
            this.Telefon = telefon;
            this.Besonderheiten = besonderheiten;
        }

        public bool AddTermin(Termin termin)
        {
            try
            {
                this.Patientenakte.Add(termin);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
