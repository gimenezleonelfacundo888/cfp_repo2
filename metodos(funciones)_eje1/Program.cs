namespace metodos_funciones__eje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una función que convierta kilómetros a millas.
            //La función deberá recibir los kilómetros y retornará las millas.
            Console.WriteLine(ComvertirMillas(5));

        }
        private static double ComvertirMillas(int kilometro, double millas = 0.621371)
        {
            return kilometro * millas;
        }
    }
}
