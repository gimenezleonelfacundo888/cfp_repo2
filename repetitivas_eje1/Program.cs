namespace repetitivas_eje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir las 5 notas de un alumno y calcular el promedio.
            double nota;
            double suma = 0;
            double promedio;

            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine("ingrese nota: ");
                nota = double.Parse(Console.ReadLine());
                suma += nota;
            }
            promedio = suma / 5;
            Console.WriteLine($"el promedio total es de {promedio}");
        }
    }
}
