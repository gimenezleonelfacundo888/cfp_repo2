namespace metodos_funciones__eje9PedirEntero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear una funcion para pedir un numero entero.
            PedirNumInt();

        }
        private static int PedirNumInt()
        {
            Console.WriteLine("Ingrese un número entero:");
            string numero = Console.ReadLine();

            while (!(numero.All(char.IsDigit) ||
                     (numero.StartsWith("-") && numero.Substring(1).All(char.IsDigit))))
            {
                Console.WriteLine("Error. Reingrese un número entero:");
                numero = Console.ReadLine();
            }

            return int.Parse(numero);
        }
    }
}
