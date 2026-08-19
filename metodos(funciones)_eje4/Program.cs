using static System.Runtime.InteropServices.JavaScript.JSType;

namespace metodos_funciones__eje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función que muestre una tabla de multiplicar de un número indicado por el usuario.
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            PedirTabla(numero);
        }
        private static void PedirTabla(int numero)
        {
           for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
