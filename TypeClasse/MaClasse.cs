using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeClasse
{
    internal partial class MaClasse
    {
        public int MaValeur { get; set; }
        public string MonPrenom { get; set; }

        public string GetNomPrenom()
        {
            return $"{MonNom} {MonPrenom}";
        }
    }
}
