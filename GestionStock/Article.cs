using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    internal class Article
    {
        public string Nom { get; set; }
        public int Qte { get; set; }
        public decimal Prix { get; set; }

        public decimal GetPrixTotal()
        {
            var prixtotal = Qte * Prix;

            return prixtotal;
        }
    }
}
g