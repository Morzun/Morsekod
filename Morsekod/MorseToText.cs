using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekod
{
    class MorseClass
    {
        static Dictionary<string, char> textList = new Dictionary<string, char>();

        public static void InitializeTextDictionary()
        {

            textList.Add("*-", 'A');
            textList.Add("-***", 'B');
            textList.Add("-*-*", 'C');
            textList.Add("-**", 'D');
            textList.Add("*", 'E');
            textList.Add("**-*", 'F');
            textList.Add("--*", 'G');
            textList.Add("****", 'H');
            textList.Add("**", 'I');
            textList.Add("*---", 'J');
            textList.Add("-*-", 'K');
            textList.Add("*-**", 'L');
            textList.Add("--", 'M');
            textList.Add("-*", 'N');
            textList.Add("---", 'O');
            textList.Add("*--*", 'P');
            textList.Add("--*-", 'Q');
            textList.Add("*-*", 'R');
            textList.Add("***", 'S');
            textList.Add("-", 'T');
            textList.Add("**-", 'U');
            textList.Add("***-", 'V');
            textList.Add("*--", 'W');
            textList.Add("-**-", 'X');
            textList.Add("-*--", 'Y');
            textList.Add("--**", 'Z');
            textList.Add("*--*-", 'Å');
            textList.Add("*-*-", 'Ä');
            textList.Add("---*", 'Ö');

            textList.Add("*----", '1');
            textList.Add("**---", '2');
            textList.Add("***--", '3');
            textList.Add("****-", '4');
            textList.Add("*****", '5');
            textList.Add("-****", '6');
            textList.Add("--***", '7');
            textList.Add("---**", '8');
            textList.Add("----*", '9');
            textList.Add("-----", '0');

            textList.Add("**--**", '?');
            textList.Add("**--*", '!');
            textList.Add("--**--", ',');
            textList.Add("*-*-*-", '.');
            textList.Add("*--*-*", '@');
            textList.Add("", ' ');
        }

        public static string GetMorseInput()
        {
            string input = Console.ReadLine();          
            return input;
        }

        public static string TranslateToText(string input)
        {
            
            string[] subString = input.Split(" ");
            List<char> charList = new List<char>();
            

            for (int i = 0; i < subString.Length; i++)
            {
                if (subString[i] == "" && subString[i - 1] == "")
                {
                    continue;
                }

                charList.Add(textList[subString[i]]);
            }

            for (int i = 1; i < subString.Length; i++)
            {
                try
                {
                    charList[i] = Char.ToLower(charList[i]);
                }

                catch
                {
                    continue;
                }
            }

            return string.Join("", charList);
        }
    }
}
