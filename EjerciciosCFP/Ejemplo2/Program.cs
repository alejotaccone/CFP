using System.Runtime.ConstrainedExecution;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Al ingresar una edad menor a 18 años y un estado civil distinto a soltero, mostrar el mensaje:
            //“Es muy pequeño para NO ser soltero”

            string estadoCivil;
            int edad;

            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estado civil");
            estadoCivil = Console.ReadLine();

            if (edad < 18 && estadoCivil != "Soltero")
            {
                Console.WriteLine("Es muy pequeño para NO ser soltero");
            }
            else
            {
                Console.WriteLine("Todo bien");
            }

            //int edad = 15;
            //string genero = "kk";

            //if (edad < 18 && genero == "mujer")
            //{
            //    Console.WriteLine("Es niña");
            //}
            //else
            //{
            //    if (genero == "mujer" && edad >= 18)
            //    {
            //        Console.WriteLine("Es adulta");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no es mujer");
            //    }
            //}


            //if ( genero == "mujer")
            //{
            //    if( edad >= 18 ) 
            //    {
            //        Console.WriteLine("Es  niña");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Es mujer");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No es mujer"); 
            //}
        }
    }
}
