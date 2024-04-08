namespace EjemploFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nombre;
            //string apellido;
            //string direccion;

            //nombre = PedirCadena("Ingrese su nombre");
            //apellido = PedirCadena("Ingrese su apellido");
            //direccion = PedirCadena("Ingrese su direccion");
            //Console.WriteLine($"Ud es: {nombre} {apellido} y vive en: {direccion}");


            //-----------------------------------------------------------------

            int unNumero = 8;
            int otroNumero = 12;
            int resultado;

            resultado = Calculadora(unNumero, otroNumero,'+');

            Console.WriteLine(resultado);

        }
        //Una funcion para pedir el ingreso de una cadena y retornarla
        static string PedirCadena(string mensaje)
        {
            string lectura;
            Console.WriteLine(mensaje);
            lectura = Console.ReadLine();

            return lectura;
        } 
        //Una funcion para sumar 2 numeros enteros
        static int SumarDeEnteros(int nroUno, int nroDos)
        {
            int resultado;
            resultado = nroUno + nroDos;

            return resultado;
        }
        //Una funcion calculadora
        static int Calculadora(int nroUno, int nroDos, char operador)
        {
            int resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = nroUno + nroDos;
                    break;
                case '-':
                    break;
                    resultado = nroUno - nroDos;
                case '*':
                    break;
                    resultado = nroUno * nroDos;
                case '/':
                    break;
                    resultado = nroUno / nroDos;
            }

            return resultado;
        }

    }
}
