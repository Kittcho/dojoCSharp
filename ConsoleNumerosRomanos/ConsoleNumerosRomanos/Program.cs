using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInicial = 0;
            int numeroFinal = 0;
            bool continuar = true;
            string saltoLinea = string.Empty;
            string resp;
            CNumeroRomano romano;
            do
            {
                Console.WriteLine(saltoLinea + "Números romanos por rango.....");
                Console.WriteLine("Para salir ingrese 0 (cero) o solo deje vacio y presione enter");
                Console.Write("Ingrese el número inicial: ");
                resp = Console.ReadLine();
                numeroInicial = string.IsNullOrWhiteSpace(resp) ? 0 : int.Parse(resp);

                continuar = ValidaRespuesta(numeroInicial);

                if (continuar)
                {
                    Console.Write("Ingrese el número final: ");
                    resp = Console.ReadLine();
                    numeroFinal = string.IsNullOrWhiteSpace(resp) ? 0 : int.Parse(resp);
                    continuar = ValidaRespuesta(numeroInicial);

                    if (continuar)
                    {
                        romano = new CNumeroRomano();
                        for (int i = numeroInicial; i <= numeroFinal; i++)
                        {
                            int num = i;
                            Console.WriteLine("Número = {0}\tRomano = {1}",i, romano.ImprimeRomano(ref num));
                        }
                    }
                }
                saltoLinea = "\n";

            } while (continuar);

            Console.WriteLine("Pulse cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static bool ValidaRespuesta(int numeroInicial)
        {
            bool continuar = true;

            if (numeroInicial == 0)
            {
                continuar = false;
            }
            return continuar;
        }
    }
}
