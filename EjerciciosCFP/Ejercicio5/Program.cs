namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //(E / S)
            //En un hospital existen tres áreas: Cardiología, Pediatría y Traumatología.El presupuesto anual del hospital se reparte conforme a la siguiente tabla:
            //Área Porcentaje del presupuesto
            //Cardiología         40 %
            //Pediatría           45 %
            //Traumatología       15 %

            double cardiologia = 0.40;
            double pediatria = 0.45;
            double traumatologia = 0.15;
            int presupuesto;
            double presupuestoCardiologia;
            double presupuestoTraumatologia;
            double presupuestoPediatria;

            Console.WriteLine("Ingrese el presupuesto anual: ");
            presupuesto = int.Parse(Console.ReadLine());

            presupuestoCardiologia = presupuesto * cardiologia;
            presupuestoPediatria = presupuesto * pediatria;
            presupuestoTraumatologia = presupuesto * traumatologia;

            Console.WriteLine($"El presupuesto anual es: {presupuesto}");
            Console.WriteLine($"El presupuesto para cardiologia es: {presupuestoCardiologia}");
            Console.WriteLine($"El presupuesto para cardiologia es: {presupuestoPediatria}");
            Console.WriteLine($"El presupuesto para cardiologia es: {presupuestoTraumatologia}");
        }
    }
}
