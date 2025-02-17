using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad_3.NormalPrint;

namespace Actividad_3.CLASES
{
    internal class Main
    {
        AbstractSample normal = new NormalPrint("Hola Mundo");
        normal.PrintMessage(); // Muestra: Hola Mundo

        AbstractSample caseInverted = new CaseInvertedPrint("Hola Mundo");
        caseInverted.PrintMessage(); // Muestra: hOLA mUNDO

        AbstractSample advancedInvert = new AdvancedInvertPrint("Hola Mundo");
        advancedInvert.InvertMessage(); // Muestra: ODNuM aLOH
    }
}
