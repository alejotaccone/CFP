using System.Runtime.ConstrainedExecution;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 15 números y determinar:
            //Suma de los negativos.
            //Suma de los positivos.
            //Cantidad de positivos.
            //Cantidad de negativos.
            //Cantidad de ceros.
            //Cantidad de números pares.
            //Promedio de positivos.
            //Promedio de negativos.
            //Diferencia entre positivos y negativos, (positivos - negativos).
            //El número máximo
            //De los negativos el mínimo

            int numero;
            int sumaNegativos = 0;
            int sumaPositivos = 0;
            int cantidadPositivos = 0;
            int cantidadNegativos = 0;
            int cantidadCeros = 0;
            int cantidadPares = 0;
            int promedioPositivos = 0;
            int promedioNegativos = 0;
            int diferencia = 0;
            int numeroMaximo = 0;
            int minimoNegativo = 0;


            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine($"Ingrese un numero: {i}/5 ");
                numero = int.Parse( Console.ReadLine() );
                numeroMaximo = numero;

                if (numero > 0)
                {
                    sumaPositivos = sumaPositivos + numero;
                    cantidadPositivos++;
                }
                else
                {
                    if (numero < 0)
                    {
                        sumaNegativos = sumaNegativos - numero;
                        cantidadNegativos++;
                    }
                    else
                    {
                        cantidadCeros++;
                    }
                }

                if (numero % 2 == 0)
                {
                    cantidadPares++;
                }

                if (i == 0 || numeroMaximo < numero)
                {
                    numeroMaximo = numero;
                }
                
            }

            promedioPositivos = sumaPositivos / 5;
            promedioNegativos = sumaNegativos / 5;
            diferencia = sumaPositivos - sumaNegativos;

            Console.WriteLine($"La suma de todos los numeros positivos es de: {sumaPositivos}");
            Console.WriteLine($"La suma de todos los numeros negativos es de: {sumaNegativos}");
            Console.WriteLine($"La cantidad de todos los numeros positivos es de: {cantidadPositivos}");
            Console.WriteLine($"La cantidad de todos los numeros negativos es de: {cantidadNegativos}");
            Console.WriteLine($"La cantidad de todos los numeros pares es de: {cantidadPares}");
            Console.WriteLine($"La cantidad de todos los ceros es de: {cantidadCeros}");
            Console.WriteLine($"El promedio de todos los numeros positivos es de: {promedioPositivos}");
            Console.WriteLine($"La diferencia de la resta de todos los numeros positivos y negativos es de: {diferencia}");
            Console.WriteLine($"El numero maximo ingresado es: {numeroMaximo}");
            Console.WriteLine($"El numero minimo negativo es: {minimoNegativo}");

        }
    }
}
