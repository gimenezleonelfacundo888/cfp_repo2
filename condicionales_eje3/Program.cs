

namespace EjercicioLamparas
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                /*Una empresa que se dedica a la comercialización de lámparas de bajo consumo,
                 * registra de sus ventas, los siguientes datos: marca y cantidad. 
                 * El precio de cada lamparita es de $7500 (Sin importar la marca).
                   El programa deberá calcular el precio total de la venta, 
                   aplicando un descuento si es que corresponde.
                   Si compra 6 lamparitas o más, tiene un descuento del 50%.
                   Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40% y si es de otra marca, el descuento es del 30%.
                   Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25%, y si es de otra marca el descuento es del 20%.
                   Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%, si es “FelipeLamparas se hace un descuento del 10% y si es otra marca, 5%.
                   Si el importe final con descuento suma más de $10500, se debe agregar el 10% de ingresos brutos.
                  Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar
                     */
                string marca;
                int cantidad;
                double precio = 7500;
                double totalSinDescuento;
                double descuento = 0;
                double montoDescuento;
                double totalConDescuento;
                double ingresosBrutos = 0;
                double totalAPagar;

                Console.Write("Ingrese la marca de la lamparita: ");
                marca = Console.ReadLine();

                Console.Write("Ingrese la cantidad de lamparitas: ");
                cantidad = int.Parse(Console.ReadLine());

                totalSinDescuento = cantidad * precio;

                if (cantidad >= 6)
                {
                    descuento = 50;
                }
                else if (cantidad == 5)
                {
                    if (marca == "ArgentinaLuz")
                    {
                        descuento = 40;
                    }
                    else
                    {
                        descuento = 30;
                    }
                }
                else if (cantidad == 4)
                {
                    if (marca == "ArgentinaLuz" || marca == "FelipeLamparas")
                    {
                        descuento = 25;
                    }
                    else
                    {
                        descuento = 20;
                    }
                }
                else if (cantidad == 3)
                {
                    if (marca == "ArgentinaLuz")
                    {
                        descuento = 15;
                    }
                    else if (marca == "FelipeLamparas")
                    {
                        descuento = 10;
                    }
                    else
                    {
                        descuento = 5;
                    }
                }

                montoDescuento = totalSinDescuento * descuento / 100;

                totalConDescuento = totalSinDescuento - montoDescuento;

                if (totalConDescuento > 10500)
                {
                    ingresosBrutos = totalConDescuento * 10 / 100;
                }

                totalAPagar = totalConDescuento + ingresosBrutos;

                Console.WriteLine("\n--- DETALLE DE LA VENTA ---");
                Console.WriteLine($"Cantidad de lamparitas: {cantidad}");
                Console.WriteLine($"Marca: {marca}");
                Console.WriteLine($"Total sin descuento: ${totalSinDescuento}");
                Console.WriteLine($"Descuento aplicado: {descuento}%");
                Console.WriteLine($"Monto del descuento: ${montoDescuento}");
                Console.WriteLine($"Total con descuento: ${totalConDescuento}");

                if (ingresosBrutos > 0)
                {
                    Console.WriteLine($"Ingresos Brutos (10%): ${ingresosBrutos}");
                }
                else
                {
                    Console.WriteLine("No corresponde Ingresos Brutos.");
                }

                Console.WriteLine($"TOTAL A PAGAR: ${totalAPagar}");
            }
        }
    }
}
    }
}
