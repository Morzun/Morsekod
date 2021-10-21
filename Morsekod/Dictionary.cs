using System;
using System.Collections.Generic;

namespace Morsekod
{
    public class Dictionary
    {
        public Dictionary()
        {

            Dictionary<char, string> morseList = new Dictionary<char, string>();

            morseList.Add('A', "*- ");
            morseList.Add('B', "-*** ");
            morseList.Add('C', "-*-* ");
            morseList.Add('D', "-** ");
            morseList.Add('E', "* ");
            morseList.Add('F', "**-* ");
            morseList.Add('G', "--* ");
            morseList.Add('H', "**** ");
            morseList.Add('I', "** ");
            morseList.Add('J', "*--- ");
            morseList.Add('K', "-*- ");
            morseList.Add('L', "*-** ");
            morseList.Add('M', "-- ");
            morseList.Add('N', "-* ");
            morseList.Add('O', "--- ");
            morseList.Add('P', "*--* ");
            morseList.Add('Q', "--*- ");

            morseList.Add('R', "*-* ");
            morseList.Add('S', "*** ");
            morseList.Add('T', "- ");
            morseList.Add('U', "**- ");
            morseList.Add('V', "***- ");
            morseList.Add('W', "*-- ");
            morseList.Add('X', "-**- ");
            morseList.Add('Y', "-*-- ");
            morseList.Add('Z', "--** ");
            morseList.Add('Å', "*--*- ");
            morseList.Add('Ä', "*-*- ");
            morseList.Add('Ö', "---* ");


        }
    }
}
