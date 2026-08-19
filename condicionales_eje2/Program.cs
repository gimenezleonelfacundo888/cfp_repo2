namespace condicionales_eje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que pregunte al usuario si tiene un título universitario
             * o si tiene experiencia laboral.Si tiene un título universitario o experiencia laboral, 
             * muestra un mensaje que diga "Eres elegible para el trabajo"*/
            string titulo_universitario;
            string experiencia_laboral;

            Console.WriteLine("posee titulo universitario?");
            titulo_universitario = Console.ReadLine();

            Console.WriteLine("tiene experiencia laboral?");
            experiencia_laboral = Console.ReadLine();

            if(titulo_universitario == "si" || experiencia_laboral == "si")
            {
                Console.WriteLine("eres apto para el trabajo");
            }
            else
            {
                Console.WriteLine("no eres apto para el trabajo");
            }
        }
    }
}
