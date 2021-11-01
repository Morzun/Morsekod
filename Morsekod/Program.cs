using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekod

{
    class Program
    {
        static void Main(string[] args)
        {
            
            TextClass.InitializeMorseDictionary();
            MorseClass.InitializeTextDictionary();

            RunProgram.StartProgram();

        }



    }
}

