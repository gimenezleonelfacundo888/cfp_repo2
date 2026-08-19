using System.ComponentModel.Design;

namespace condicionales_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que pregunte al usuario su edad
                y si tiene licencia de conducir.
                Si la edad es mayor o igual a 18
                y tiene licencia de conducir, 
                muestra un mensaje que diga "Puedes conducir".
                De lo contrario, muestra un mensaje que diga "No puedes conducir".*/

            int edad;
            string licencia_de_conducir;

            Console.WriteLine("ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("tiene licencia de conducir?: ");
           licencia_de_conducir = Console.ReadLine();

            if (edad >= 18 && licencia_de_conducir == "s")
            {
                Console.WriteLine("puedes conducir");
            }
            else
            {
                Console.WriteLine("no puedes conducir");

            }
            
        }
    }
}
