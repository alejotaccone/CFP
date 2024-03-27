namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 2 números y mostrar la suma de los mismos
            int nroUno;
            int nroDos;
            int suma;

            Console.WriteLine("Ingrese el primer numero: ");
            nroUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            nroDos = int.Parse(Console.ReadLine());

            suma = nroUno + nroDos;

            Console.WriteLine($"La suma de {nroUno} + {nroDos} es: {suma}");
        }
    }
}
