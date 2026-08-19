using System.Reflection.Metadata.Ecma335;

namespace metodos_funciones__eje6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una función que determine si un número es primo o no. Retorna true si lo es.
            Console.WriteLine("ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(EsPrimo(numero));
        }
        private static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }
            for (int i = 2; i < numero; i++)
            {
                return false;
            }
            return true;
        }
    }
}
