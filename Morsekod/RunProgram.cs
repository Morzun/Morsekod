using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekod
{
    class RunProgram
    {

        public static void StartProgram()
        {
            
            Console.Clear();

            Console.WriteLine("Hej och välkommen till denna konverterare för morsekod!");
            Console.WriteLine("Tryck 1 för att översätta text till morsekod.");
            Console.WriteLine("Tryck 2 för att översätta morsekod till text");
            Console.WriteLine("Tryck 3 för att avsluta programmet.");

            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    TranslateText();
                    break;

                case 2:
                    TranslateMorse();
                    break;

                case 3:
                    break;
            }
        }

        public static void ProgramOption()
        {
            Console.WriteLine("Press 1 to restart the program. This will clear the console.");
            Console.WriteLine("Press 2 to close the program. ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    StartProgram();
                    break;
                case 2:
                    EndProgram();
                    break;
            }

        }

        public static void TranslateText()
        {
            Console.WriteLine("Skriv in den text du vill översätta till morsekod.");
            string userInput = Class1.GetTextInput();
            Console.WriteLine("Morse alphabet output is: " + Class1.TranslateToMorse(userInput));


            ProgramOption();
        }
        public static void TranslateMorse()
        {
            Console.WriteLine("Skriv in den morsekod du vill översätta till text. * = kort, - = lång.");
            string userInput = Class2.GetMorseInput();
            Console.WriteLine("Text output is: " + Class2.TranslateToText(userInput));

            ProgramOption();
        }       

        public static void EndProgram()
        {
            System.Environment.Exit(0);
        }
    }
}
