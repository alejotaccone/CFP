namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Una empresa que se dedica a la comercialización de lámparas de bajo consumo, registra de sus ventas, los siguientes datos: marca y cantidad.El precio de cada lámpara es de $150(Sin importar la marca).
            //El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
            //R.Si compras 6 lámparas o más, tiene un descuento del 50 %.
            //B.Si compra 5 lamparas marca “ArgentinaLuz” se aplica un 40 % y si es de otra marca, el descuento es del 30 %.
            //C.Si compra 4 lamparas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25 %, y si es de otra marca el descuento es del 20 %.
            //D.Si compra 3 lamparas marca “ArgentinaLuz” el descuento es del 15 %, si es “FelipeLamparas se hace un descuento del 10 % y si es otra marca, 5 %.
            //E.Si la importación final con descuento suma más de $950, se debe agregar el 10 % de ingresos brutos.
            //Informar: cantidad de lamparas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.

            string marca;
            int cantidad;
            int precio = 150;
            float total;
            float totalDescuento;
            int descuento = 0;
            int valorIngresosBrutos = 950;
            float ingresosBrutos;

            Console.WriteLine("Ingrese la marca");
            marca = Console.ReadLine().ToUpper();


            Console.WriteLine("Ingrese la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            total = cantidad * precio;

            if (cantidad >= 6)
            {
                descuento = 50;
            }
            else
            {
                if (cantidad == 5)
                {
                    if (marca == "ARGENTINALUZ" || marca == "FELIPELAMPARAS")
                    {
                        descuento = 40;
                    }
                    else
                    {
                        descuento = 30;
                    }
                }
                else
                {
                    if (cantidad == 4)
                    {
                        if (marca == "ARGENTINALUZ" || marca == "FELIPELAMPARAS")
                        {
                            descuento = 25;
                        }
                        else
                        {
                            descuento = 20;
                        }
                    }
                    else
                    {
                        if (cantidad == 3)
                        {
                            if (marca == "ARGENTINALUZ")
                            {
                                descuento = 15;
                            }
                            if (marca == "FELIPELAMPARAS")
                            {
                                descuento = 10;
                            }
                            else
                            {
                                descuento = 5;
                            }
                        }

                    }
                }
            }

            totalDescuento = total * descuento / 100;

            if (descuento != 0)
            {
                Console.WriteLine($"Marca: {marca} | Cantidad de lamparitas: {cantidad} | SubTotal: ${total} | Total: ${totalDescuento} | Descuento: {descuento}%");
            }
            else
            {
                Console.WriteLine($"Marca: {marca} | Cantidad de lamparitas: {cantidad} | Total: ${total} | Descuento: {descuento}%");
            }
            if (total > valorIngresosBrutos)
            {
                ingresosBrutos = totalDescuento * 10 / 100;
                totalDescuento = totalDescuento + ingresosBrutos;
                Console.WriteLine($"Por ingresos brutos se le cobra un impuesto de: ${ingresosBrutos} | Total + Impuestos: ${totalDescuento}");
            }

        }
    }
}


