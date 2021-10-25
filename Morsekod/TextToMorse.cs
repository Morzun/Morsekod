using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekod
{
    class Class1
    {
        static Dictionary<char, string> morseList = new Dictionary<char, string>();
        public static void InitializeMorseDictionary()
        {           

            morseList.Add('A', "*-");
            morseList.Add('B', "-***");
            morseList.Add('C', "-*-*");
            morseList.Add('D', "-**");
            morseList.Add('E', "*");
            morseList.Add('F', "**-*");
            morseList.Add('G', "--*");
            morseList.Add('H', "****");
            morseList.Add('I', "");
            morseList.Add('J', "*---");
            morseList.Add('K', "-*-");
            morseList.Add('L', "*-**");
            morseList.Add('M', "--");
            morseList.Add('N', "-*");
            morseList.Add('O', "---");
            morseList.Add('P', "*--*");
            morseList.Add('Q', "--*-");
            morseList.Add('R', "*-*");
            morseList.Add('S', "***");
            morseList.Add('T', "-");
            morseList.Add('U', "**-");
            morseList.Add('V', "***-");
            morseList.Add('W', "*--");
            morseList.Add('X', "-**-");
            morseList.Add('Y', "-*--");
            morseList.Add('Z', "--**");
            morseList.Add('Å', "*--*-");
            morseList.Add('Ä', "*-*-");
            morseList.Add('Ö', "---*");

            morseList.Add('1', "*----");
            morseList.Add('2', "**---");
            morseList.Add('3', "***--");
            morseList.Add('4', "****-");
            morseList.Add('5', "*****");
            morseList.Add('6', "-****");
            morseList.Add('7', "--***");
            morseList.Add('8', "---**");
            morseList.Add('9', "----*");
            morseList.Add('0', "-----");

            morseList.Add('?', "**--**");
            morseList.Add('!', "**--*");
            morseList.Add(',', "--**--");
            morseList.Add('.', "*-*-*-");
            morseList.Add('@', "*--*-*");
           
        }

        public static string GetTextInput()
        {
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                input = input.ToUpper();
            }

            return input;
        }

        public static string TranslateToMorse(string input)
        {            
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char character in input)
            {
                if (morseList.ContainsKey(character))
                {
                    stringBuilder.Append(morseList[character] + " ");
                }
                else if (character == ' ')
                {
                    stringBuilder.Append("  ");
                }
                else
                {
                    stringBuilder.Append(character + " ");
                }
            }

            return stringBuilder.ToString();
        }

    }
}
