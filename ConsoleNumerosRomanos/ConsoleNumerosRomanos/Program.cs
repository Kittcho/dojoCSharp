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
            int opcion = -1;
            int numeroInicial = 0;
            int numeroFinal = 0;
            bool continuar = true;
            bool continuarMenu = true;
            string saltoLinea = "\n";
            string resp;
            CTiposNumeros numero;
            do
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("Opción 1: Convertir números Arabicos a Romanos");
                Console.WriteLine("Opción 2: Convertir números Romanos a Arabicos");
                Console.WriteLine("Para salir ingrese 0 (cero) o solo deje vacio y presione enter");
                Console.Write("Seleccione la opción deseada: ");
                resp = Console.ReadLine();
                opcion = string.IsNullOrWhiteSpace(resp) ? 0 : int.Parse(resp);
                do
                {
                    if (opcion == 0)
                    {
                        continuarMenu = false;
                        continuar = false;
                    }
                    else if (opcion == 2)
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
                                numero = new CTiposNumeros();
                                for (int i = numeroInicial; i <= numeroFinal; i++)
                                {
                                    int num = i;
                                    Console.WriteLine("Número = {0}\tRomano = {1}", i, numero.ConvierteARomano(ref num));
                                }
                            }
                        }
                    }
                    else if (opcion == 1)
                    {
                        Console.WriteLine(saltoLinea + "Números Romanos a Arabicos");
                        Console.WriteLine("Para salir ingrese 0 (cero) o solo deje vacio y presione enter");
                        Console.Write("Ingrese el número romano a convertir: ");
                        resp = Console.ReadLine();
                        string romanoAConvertir = string.IsNullOrWhiteSpace(resp) ? "0" : resp;

                        if (romanoAConvertir.Equals("0"))
                        {
                            continuar = false;
                        }else
                        {
                            numero = new CTiposNumeros();
                            Console.WriteLine(saltoLinea + "> {0}\t{1}",romanoAConvertir, numero.ConvierteAArabico(romanoAConvertir).ToString());
                        }

                    }else
                    {
                        Console.WriteLine("Error");
                    }

                } while (continuar);
            } while (continuarMenu);

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
