﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleNumerosRomanos
{
    public class CNumeroRomano
    {

        public string ImprimeRomano(ref int num)
        {
            string romano = string.Empty;
            int arabico = 0;
            Dictionary<int, string> equivalencia = new Dictionary<int, string>()
            {
                {1,"I"},
                {4,"IV"},
                {5,"V"},
                {9,"IX"},
                {10,"X"},
                {40,"XL"},
                {50,"L"},
                {90,"XC"},
                {100,"C"},
                {400,"CD"},
                {500,"D"},
                {900,"CM"},
                {1000,"M"}
            };


            foreach (var item in equivalencia)
            {
                if (num >= item.Key)
                {
                    romano = item.Value;
                    arabico = item.Key;
                    if ((num - arabico) == 0)
                    {
                        break;
                    }
                }
                else if ((num - arabico) > 0)
                {
                    num -= arabico;
                    romano += ImprimeRomano(ref num);
                }
            }

            return romano;
        }
    }
}
