using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geschäftslogik
{
    class DatenbankConnector
    {
        private List<Patient> patienten;

        public List<Patient> Patienten { get => patienten; set => patienten = value; }
        public DatenbankConnector()
        {

        }
    }
}
