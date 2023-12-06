using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    internal class Prestito
    {
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }
        public DateTime InizioPrestito { get; set; }
        public DateTime FinePrestito { get; set; }
    }
}
