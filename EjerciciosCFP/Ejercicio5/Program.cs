namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números enteros, calcular y mostrar el promedio
            int nroUno;
            int nroDos;
            int nroTres;
            int nroCuatro;
            int nroCinco;
            float promedio;

            Console.WriteLine("Ingrese el primer numero: ");
            nroUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            nroDos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            nroTres = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero: ");
            nroCuatro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero: ");
            nroCinco = int.Parse(Console.ReadLine());

            promedio = (nroUno + nroDos + nroTres + nroCuatro + nroCinco) / 5 ;

            Console.WriteLine($"El promedio de los 5 numeros es de: {promedio}");

        }
    }
}
