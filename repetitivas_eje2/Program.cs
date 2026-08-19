namespace repetitivas_eje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generar un número aleatorio del 1 al 10 y permitir intentos infinitos hasta acertar;

            Random random = new Random();

            int numeroSecreto = random.Next(1, 11);
            int intento;

            Console.WriteLine("Adivina el número del 1 al 10.");

            do
            {
                Console.WriteLine("Ingrese un número:");
                intento = int.Parse(Console.ReadLine());

                if (intento == numeroSecreto)
                {
                    Console.WriteLine("¡Acertaste!");
                }
                else
                {
                    Console.WriteLine("Incorrecto, intenta nuevamente.");
                }

            } while (intento != numeroSecreto);



        }
    }
}
