namespace metodos_funciones__eje10pedir_flotante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear una funcion para pedir un numero entero.
            PedirNumFloat();
        }
        static double PedirNumFloat()
        {
            double numero;
            string texto;

            Console.Write("Ingrese un número flotante: ");
            texto = Console.ReadLine();

            while (!double.TryParse(texto, out numero) || !texto.Contains("."))
            {
                Console.Write("Error. Reingrese un número flotante: ");
                texto = Console.ReadLine();
            }

            return numero;
        }
    }
    
}
