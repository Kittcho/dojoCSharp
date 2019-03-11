using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleNumerosRomanos
{
    public class CTiposNumeros
    {

        Dictionary<int, string> equivalencia;

        public CTiposNumeros()
        {
            equivalencia = new Dictionary<int, string>()
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
        }

        public string ConvierteARomano(ref int num)
        {
            string romano = string.Empty;
            int arabico = 0;
            


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
                    romano += ConvierteARomano(ref num);
                }
            }

            return romano;
        }

        public int ConvierteAArabico(string romano)
        {
            int resp = 0;
            int num = 0;
            int valorInicial = 0;
            foreach (var item in equivalencia)
            {
                if (item.Value.Contains(romano.Substring(0, 1)))
                {
                    valorInicial = item.Key;
                    break;
                }
            }

            for (int i = valorInicial; i <= 1000; i++)
            {
                num = i;
                string posibleRomano = this.ConvierteARomano(ref num).ToUpper();
                if (posibleRomano.Equals(romano.ToUpper()))
                {
                    resp = i;
                    break;
                }
            } 
            return resp;
        }
    }
}
