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
            Class1.InitializeMorseDictionary();
            Class2.InitializeTextDictionary();

            Console.WriteLine("What did you want to say?");
            string userInput = Class2.GetMorseInput();
            Console.WriteLine("Morse alphabet output is: " + Class2.TranslateToText(userInput));

            Console.WriteLine("[Press ANY KEY to exit]");
            Console.ReadLine();
            

        }











    }
}

