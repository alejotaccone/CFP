namespace Ejercicio_1
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            //Ingresar el nombre y apellido por consola.

            string nombre;
            string apellido;

            Console.WriteLine("Ingrese su Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido:");
            apellido = Console.ReadLine();

            Console.WriteLine($"Su nombre compelto es: {nombre} {apellido}");
        }
    }
}
