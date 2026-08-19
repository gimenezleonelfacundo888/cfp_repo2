namespace calcular_resto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que pida dos números enteros.
             * Calcular y mostrar el resto de la división entre ambos números
             * .Ej: "El resto de dividir 7 por 2 es: 1"*/
            int primer_numero;
            int segundo_numero;
            int resto;

            Console.WriteLine("ingrese el primer numero: ");
            primer_numero = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero: ");
            segundo_numero = int.Parse(Console.ReadLine());


            resto = primer_numero % segundo_numero;
            Console.WriteLine($"el resto de {primer_numero} y de {segundo_numero} es: {resto}");
        }
    }
}
