using System;

namespace Ejercicio2String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Pedir el ingreso de una palabra y mostrarla con todos sus caracteres separados por un guión.
            //ej: Montaña->M - o - n - t - a - ñ - a.

            string palabra;

            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();

            for (int i = 0; i < palabra.Length; i++)
            {
                Console.Write(palabra[i]);
                if (i < palabra.Length - 1)
                {
                    Console.Write(" - ");
                }
            }

        }
    }
}
