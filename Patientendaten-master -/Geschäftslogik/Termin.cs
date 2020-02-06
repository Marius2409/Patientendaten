using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geschäftslogik
{
    public class Termin
    {
        private DateTime datum;
        private string beschreibung;
        private string sonstige;

        public DateTime Datum { get => datum; set => datum = value; }
        public string Beschreibung { get => beschreibung; set => beschreibung = value; }
        public string Sonstige { get => sonstige; set => sonstige = value; }


        public Termin(DateTime datum, string beschreibung, string sonstiges)
        {
            this.Datum = datum;
            this.Beschreibung = beschreibung;
            this.Sonstige = sonstige;
        }
    }
}
