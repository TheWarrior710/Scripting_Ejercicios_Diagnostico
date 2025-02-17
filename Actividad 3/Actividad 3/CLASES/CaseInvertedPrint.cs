using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.NormalPrint
{
    class CaseInvertedPrint : AbstractSample
    {
        public CaseInvertedPrint(string msg) : base(msg) { }

        public override void PrintMessage()
        {
            string invertedCaseMessage = SwapCase(GetMessage());
            Console.WriteLine(invertedCaseMessage);
        }

    
        private string SwapCase(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]); 
                else if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]); 
            }
            return new string(chars);
        }

    }

}