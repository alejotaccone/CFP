namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CARACTERES = String
            //NUMEROS REALES = FLOAT(INPRECISO) - DOBLE(PRESISO) - DECIMAL(EXACTO)
            //NUMEROS ENTEROS = INT - INT8 - INT16 - INT32  
            //LOGICO = BOOL

            string nombre;
            string apellido;
            string edadString;
            int edadInt;

            Console.WriteLine("Ingrese su nombre: ");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido: ");

            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");

            edadString = Console.ReadLine();

            edadInt = int.Parse(edadString);


            Console.WriteLine("Bienvenido " + nombre + " " + apellido + ", Su edad es: " + edadInt);

            Console.WriteLine("Bienvenido {0} {1}, Su edad es: {2}", nombre, apellido, edadInt);

            Console.WriteLine($"Bienvenido {nombre} {apellido}, Su edad es: {edadInt}");

        }
    }
}
