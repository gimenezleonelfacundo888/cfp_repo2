namespace calcular_presupuesto_eje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* En un hospital existen tres áreas:
             * Cardiología, Pediatría y Traumatología.
             * El presupuesto anual del hospital se reparte conforme a la siguiente tabla:
             * Área Porcentaje del presupuesto
               Cardiología
                40 %
               Pediatría
                45 %
               Traumatología
                15 %
            Necesitamos saber cuánto dinero le corresponde a cada área.*/

            double presupuesto_total;
            double cardiologia;
            double pediatria;
            double traumatologia;
            double porcentaje;
            string area;

            cardiologia = 40;
            pediatria = 45;
            traumatologia = 15;
            presupuesto_total = 2000000;

            Console.WriteLine("Elija el área que desea consultar (cardiologia/pediatria/traumatologia):");
            area = Console.ReadLine();

            if (area == "cardiologia") 
            {
                porcentaje = presupuesto_total * cardiologia / 100;
                Console.WriteLine($"el presupuesto para cardiologia es de: {porcentaje}");


            }
            else
            {
                if (area == "pediatria")
                {
                    porcentaje = presupuesto_total * pediatria / 100;
                    Console.WriteLine($"el presupuesto para pediatria es de: {porcentaje}");
                }
                else
                {
                    if (area == "traumatologia")
                    {
                        porcentaje = presupuesto_total * traumatologia / 100;
                        Console.WriteLine($"el presupuesto para traumatologia es de: {porcentaje}");
                    }
                }
            }
            
        }
    }
}
