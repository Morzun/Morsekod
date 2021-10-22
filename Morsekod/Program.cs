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
            int menu;
            Class1.InitializeMorseDictionary();
            Class2.InitializeTextDictionary();



            Console.WriteLine("Hej och välkommen till denna konverterare för morsekod!");
            Console.WriteLine("Tryck 1 för att översätta text till morsekod.");
            Console.WriteLine("Tryck 2 för att översätta morsekod till text");
            Console.WriteLine("Tryck 3 för att avsluta programmet.");

            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }


            void TranslateMorse()
            {
                Console.WriteLine("Skriv in den morsekod du vill översätta till text. * = kort, - = lång.");
                string userInput = Class2.GetMorseInput();
                Console.WriteLine("Morse alphabet output is: " + Class2.TranslateToText(userInput));

                Console.WriteLine("[Press ANY KEY to exit]");
                Console.ReadLine();
            }
            
            

        }











    }
}

