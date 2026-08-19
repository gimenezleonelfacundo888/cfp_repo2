namespace metodos_funciones__repaso
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(Sumar4(4, 1));
        }
        //abajo
        //arriba el prototipo del metodo se hace aca o abajo
        //prototipo1
        private static void Sumar_1()
        {
            Console.WriteLine("INGRESE EL PRIMER NUMERO: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"la suma entre {numero1} y {numero2}: {numero1 + numero2}");
        }
        //prototipo2
        private static int Sumar2()
        {
            Console.WriteLine("INGRESE EL PRIMER NUMERO: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO: ");
            int numero2 = int.Parse(Console.ReadLine());
            return numero1 + numero2;
        }
        //prototipo3
        private static void Sumar3(int numero1, int numero2)
        {
            Console.WriteLine($"la suma entre {numero1} y {numero2}: {numero1 + numero2}");
        }
        //prototipo4
        private static int Sumar4(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }

}
