using System.Diagnostics;

namespace EjemploSwicht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color;
            color = Console.ReadLine();  

           switch (color)
            {
                case "rojo":
                    Console.WriteLine("No puede azanzar");
                    break;
                case "amarillo":
                    Console.WriteLine("Precaucion");
                    break;
                case "verde":
                    Console.WriteLine("Puede azanzar");
                    break; 
                default:
                    Console.WriteLine("No es un color del semaforo");
                    break;
            }

        }
    }
}
