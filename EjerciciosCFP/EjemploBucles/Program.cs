namespace EjemploBucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE - MIENTRAS
            //DOWHILE - REPETIR (Siempre se ejecuta una vez)
            //FOR - PARA
            //FOREACH

            int control = 0;
            int repeticiones = 5;

            //while (control < repeticiones)
            //{
            //    Console.WriteLine(control);
            //    control = control + 1;
            //}

            //do
            //{
            //    Console.WriteLine(control);
            //    control = control + 1;
            //}
            //while (control < repeticiones);

            for (int i = 0; i < repeticiones; i++)
            {
                Console.WriteLine(control);
                control = control + 1;
            }

        }
    }
}
