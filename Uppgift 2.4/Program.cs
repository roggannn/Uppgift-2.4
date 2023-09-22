using System;

namespace uppgift
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in lönen på en av de anställda.");
            double anställd1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Skriv in lönen på en till av de anställda.");
            double anställd2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Skriv lönen på en till av de anställda.");
            double anställd3 = double.Parse(Console.ReadLine());

            double medelvärde = (anställd1 + anställd2 + anställd3) / 3;

            Console.Clear();
            Console.WriteLine("Medelvärdet av alla löner är " + medelvärde + "."); // -=* GJORD AV NOAH *=-
            Console.ReadKey();

        }



    }

}