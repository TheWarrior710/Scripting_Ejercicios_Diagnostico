using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad_3;

namespace Actividad_3.NormalPrint
{
    class NormalPrint : AbstractSample
    {

        public NormalPrint(string msg) : base(msg) { }


        public override void PrintMessage()
        {
            Console.WriteLine(GetMessage());
        }
    }


}