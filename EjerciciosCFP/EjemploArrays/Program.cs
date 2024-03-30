namespace EjemploArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] miCadena =
            //{
            //    "valor0",
            //    "valor1",
            //    "valor2",
            //    "valor3",
            //    "valor4"
            //};
            ////for (int i = 0; i < miCadena.Length; i++)
            ////{
            ////    Console.WriteLine(miCadena[i]);
            ////    //Console.WriteLine(miCadena[i] = "valor pisado");
            ////}

            ////foreach (string dato in miCadena)
            ////{
            ////    Console.WriteLine(dato);
            ////}


            //char[] otracADENA = new char[5];


            //otracADENA[0] = 'A';
            //otracADENA[4] = 'b';

            //int[] arrayNumerico = new int[5];

            //for (int i = 0; i < arrayNumerico.Length; i++)
            //{
            //    Console.WriteLine($"Ingrese el {i + 1}° numero");
            //    arrayNumerico[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int nro in arrayNumerico)
            //{
            //    Console.WriteLine(nro);
            //}




            //--------------------------------------------------------------------------------------

            string nombre;
            bool esIncorrecto;

            //for (int i = 0; i < nombre.Length; i++)
            //{
            //    if (char.IsLetter(nombre[i]))
            //    {
            //        Console.WriteLine($"{nombre[i]} es una letra");
            //    }
            //    else
            //    {
            //        if (char.IsDigit(nombre[i]))
            //        {
            //            Console.WriteLine($"{nombre[i]} es un numero");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{nombre[i]} es un simbolo");
            //        }
            //    }
            //}

            do
            {
                esIncorrecto = false;
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                for (int i = 0; i < nombre.Length; i++)
                {
                    if (!char.IsLetter(nombre[i]))
                    {
                        Console.WriteLine("El nombre debe tener solo letras");
                        esIncorrecto = true;
                        break;
                    }

                }
            } while (esIncorrecto);



            Console.WriteLine(nombre);
        }
    }
}
