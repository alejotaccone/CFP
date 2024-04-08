namespace Ejercicio3String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir el ingreso de una palabra y reemplazar todas las letras A por un carácter especial(* , & , etc).
            //ej: Manzana->M * nz * n *.

            string palabra;
            string palabra2 = "";

            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();


            foreach (char unaLetra in palabra)
            {
                if (unaLetra == 'a')
                {
                    palabra2 += '*';
                }
                else
                {
                    palabra2 += unaLetra;
                }
                
            };
            Console.Write(palabra2);
        }
    }
}
