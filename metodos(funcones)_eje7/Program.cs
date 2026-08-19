using static System.Runtime.InteropServices.JavaScript.JSType;

namespace metodos_funcones__eje7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una función que ingrese un monto entero y devuelva el valor del IVA del producto.
            Console.WriteLine("ingrese el monto para calcular el valor del iva: ");
            int monto = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcularIva(monto));

        }
        private static double CalcularIva(int monto)
        {
            return monto * 21 / 100;
        }
    }
}
