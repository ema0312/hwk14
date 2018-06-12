using System;

namespace secprovc2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int Bolillos = 12;
            Console.WriteLine(Bolillos);
            Console.ReadKey();

            string doing = ("what are you doing!");
            Console.WriteLine(doing);
            Console.ReadKey();


            float ham = 1.5f;
            Console.WriteLine(ham);
            Console.ReadKey();

            Double cheese = 2.0;
            Console.WriteLine(cheese);
            Console.ReadKey();

            bool enough = true;
            Console.WriteLine(enough);
            Console.ReadKey();

            Console.WriteLine("This is {0} This is {1} and This is {2}", Bolillos, ham, cheese);
            Console.ReadKey();

            Console.Write("Enter what are you doing; ");
            string Tortas = Console.ReadLine();
            Console.WriteLine(Tortas);
            Console.ReadKey();

            Console.WriteLine("enough" == "Tortas");
            Console.WriteLine(100 < 50);
            Console.WriteLine(1.5 < 2.0);
            Console.WriteLine(2.0 > 1.5);
            Console.ReadKey();



        }
    }
}


