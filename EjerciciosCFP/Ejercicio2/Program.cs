namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar el nombre, apellido y edad por consola.
            string nombre;
            string apellido;
            int edad;

            Console.WriteLine("Ingrese su Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad:");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Su nombre compelto es: {nombre} {apellido} | Su edad es: {edad}");
        }
    }
}
