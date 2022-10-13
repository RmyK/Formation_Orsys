using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveEtAttribut
{
    internal class NouvelAttribut : Attribute
    {
        public int ValeurAttribut { get; set; }
        public string NomAttribut { get; set; }
    }
}
