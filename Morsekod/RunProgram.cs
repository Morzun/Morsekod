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

            int menu = 0;
            bool isInvalidInput = false;

            do
            {
                Console.WriteLine("Hej och välkommen till denna konverterare för morsekod!");
                Console.WriteLine("Tryck 1 för att översätta text till morsekod.");
                Console.WriteLine("Tryck 2 för att översätta morsekod till text");
                Console.WriteLine("Tryck 3 för att avsluta programmet.");

                try
                {
                    menu = int.Parse(Console.ReadLine());
                    isInvalidInput = false;
                    break;
                }

                catch
                {
                    Console.WriteLine("Det var inte en korrekt input, försök igen..");
                    isInvalidInput = true;
                }

            } while (isInvalidInput);

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
            int option = 0;
            bool isInvalidInput = false;

            do
            {
                do
                {
                    Console.WriteLine("Tryck 1 för att starta om programmet. Detta kommer att rensa konsolen.");
                    Console.WriteLine("Tryck 2 för att stänga av programmet. ");

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                        isInvalidInput = false;
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Det var inte en korrekt input, försök igen..");
                        isInvalidInput = true;
                    }


                } while (isInvalidInput);

                switch (option)
                {
                    case 1:
                        StartProgram();
                        break;
                    case 2:
                        EndProgram();
                        break;
                    default:
                        Console.WriteLine("Det var inte en korrekt input, försök igen..");
                        break;
                }

            } while (option != 0);
        }

        public static void TranslateText()
        {
            Console.WriteLine("Skriv in den text du vill översätta till morsekod.");
            string userInput = TextClass.GetTextInput();
            Console.WriteLine("Översatt till morsekod ser det ut såhär: " + TextClass.TranslateToMorse(userInput));

            ProgramOption();
        }
        public static void TranslateMorse()
        {
            Console.WriteLine("Skriv in den morsekod du vill översätta till text. * = kort, - = lång.");
            string userInput = MorseClass.GetMorseInput();
            Console.WriteLine("Översatt till text ser det ut såhär: " + MorseClass.TranslateToText(userInput));

            ProgramOption();
        }       

        public static void EndProgram()
        {
            System.Environment.Exit(0);
        }
    }
}
