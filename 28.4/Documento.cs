using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    internal class Documento
    {
        public string Id { get; set; }
        public string Titolo { get; set; }
        public string Settore { get; set; }
        public Stato stato { get; set; }
        public DateTime Anno { get; set; }
        public string Scaffale { get; set; }
        public List <Autore> Autori { get; set; }

    }
}
