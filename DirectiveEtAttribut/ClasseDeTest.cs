using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveEtAttribut
{
    [Serializable]
    internal class ClasseDeTest
    {
        public int MyValue { get; set; }
        [NouvelAttribut(ValeurAttribut =3, NomAttribut = "TestAttribut")]
        public string MyString { get; set; }
    }
}
