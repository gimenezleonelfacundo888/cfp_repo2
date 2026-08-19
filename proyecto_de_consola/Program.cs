namespace proyecto_de_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int suma;
            int resta;
            int multiplicacion;
            float division;
            Console.WriteLine("ingrese un numero: ");
            primerNumero = int.Parse(Console.ReadLine());//int.Parce(Console.Readline()) permite al usuario devolver un entero(int) en una variable
            Console.WriteLine("ingrese otro numero: ");
            segundoNumero = int.Parse(Console.ReadLine());//int.Parce(Console.Readline()) permite al usuario devolver un entero(int) en una variable

            suma = primerNumero + segundoNumero;
            Console.WriteLine($"el resultado de la suma es: {suma} ");// tab + cw,invoca el console.writeline,muestra lo escrito al usuario por consola
            resta = primerNumero - segundoNumero;
            Console.WriteLine($"el resultado de la resta es: {resta} ");
            multiplicacion = primerNumero * segundoNumero;
            Console.WriteLine($"el resultado de la multiplicacion es: {multiplicacion} ");
            division = (float) primerNumero / segundoNumero;//para obtener un resultado desimal colocamos (float) antes de la variable
            Console.WriteLine($"el resultado de la division es: {division} ");
        }
    }
}
