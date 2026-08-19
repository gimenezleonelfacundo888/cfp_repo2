namespace metodos_funciones__eje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer una calculadora con funciones para sumar, restar, multiplicar y dividir dos números
            //(verificar la división por cero)
            Console.WriteLine($"la suma de 1 + 2 es: {Sumar(1, 2)}");
            Console.WriteLine($"la reta de 2 - 1 es: {Restar(2, 1)}");
            Console.WriteLine($"la multiplicacion de 1 * 2 es: {Multiplicar(1, 2)}");
            Console.WriteLine($"la divicion de 2 / 1 es: {Dividir(1, 2)}");
        }
        private static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        private static int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        private static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        private static int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}
