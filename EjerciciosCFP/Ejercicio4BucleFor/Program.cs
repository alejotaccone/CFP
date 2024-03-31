namespace Ejercicio4BucleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números enteros, calcular y mostrar el promedio.
            int nro;
            int suma = 0;
            double promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el {i+1}° numero: ");
                nro = int.Parse(Console.ReadLine());
                suma = suma + nro;
            }
            promedio = suma / 5;
            Console.WriteLine($"El promedio de los 5 numeros es de: {promedio}");
            ;
        }
    }
}
