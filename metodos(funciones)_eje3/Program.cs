using static System.Runtime.InteropServices.JavaScript.JSType;

namespace metodos_funciones__eje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar una función que calcule el índice de masa corporal(IMC) de una persona
            //a partir de su peso y altura.
            Console.WriteLine(CalcularIMC(70, 1.75));
        }
        private static double CalcularIMC(double peso, double altura)
        {
            double IMC = peso / (altura * altura);
            return IMC;
        }

    }
}
