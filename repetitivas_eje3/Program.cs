namespace repetitivas_eje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar un menú de opciones(1, 2, 3, salir) que se repita hasta que el usuario elija salir.;

            int opcion;

            do
            {
                Console.WriteLine("----- MENÚ -----");
                Console.WriteLine("1. Opción 1");
                Console.WriteLine("2. Opción 2");
                Console.WriteLine("3. Opción 3");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese una opción:");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("esta en la opcion 1");
                }
                else
                {
                    if (opcion == 2)
                    {
                        Console.WriteLine("esta en la opcion 2");
                    }
                    else
                    {
                        if (opcion == 3)
                        {
                            Console.WriteLine("esta en la opcion 3");
                        }
                        else
                        {
                            if (opcion == 4)
                            {
                                Console.WriteLine("cerrando menu..");
                            }
                            else
                            {
                                Console.WriteLine("opcion incorrecta");
                            }
                        }
                    }
                }

            } while (opcion != 4);

        }
    }
}
