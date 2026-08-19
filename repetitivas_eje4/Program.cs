namespace repetitivas_eje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 10 números enteros. Determinar el máximo y el mínimo.

            int numero;
            int minimo;
            int maximo;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            minimo = numero;
            maximo = numero;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }
            }

            Console.WriteLine($"El número más grande ingresado es {maximo}");
            Console.WriteLine($"El número más chico ingresado es {minimo}");

        }
    }
}
