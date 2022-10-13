using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveEtAttribut
{
    public enum EFonctionEmployer
    {
        Facteur,
        [Description("Employer de tri")]
        EmployerTri,
        Guichetier,
        Receveur,
        ChauffeurLivreur
    }
}
