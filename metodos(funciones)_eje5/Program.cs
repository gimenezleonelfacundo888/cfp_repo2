using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace metodos_funciones__eje5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una función que determine si un número es par o no. Retorna true si lo es.
            Console.WriteLine("ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
                Console.WriteLine(ParInpar(numero));
        }
        private static bool ParInpar(int numero)
        {
            return numero % 2 == 0;
            
        }
    }
}
