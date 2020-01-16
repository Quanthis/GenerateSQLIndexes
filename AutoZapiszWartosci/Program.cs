using System;
using System.Diagnostics;
using System.IO;


namespace AutoZapiszWartosci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 1. indeks początkowy");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj 1. indeks końcowy: ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Podaj 2. indeks początkowy");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj 2. indeks końcowy: ");
            int d = Convert.ToInt32(Console.ReadLine());

            string f;
            Console.WriteLine("Czy chcesz dodać prefix? Napisz 'y'.");
            string e = Console.ReadLine();
            if (e == "y")
            {
                Console.WriteLine("Wpisz prefix: ");
                f = Console.ReadLine();



                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Młyńscy\Desktop\AutoGeneracja.txt"))
                {
                    for (int i = a; i <= b; i++)
                    {

                        for (int j = c; j <= d; j++)
                        {
                            file.WriteLine($"\t \t({f}, {i}, {j}),");
                        }
                        //file.WriteLine();
                    }
                }
            }
            else
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Młyńscy\Desktop\AutoGeneracja.txt"))
                {
                    for (int i = a; i <= b; i++)
                    {

                        for (int j = c; j <= d; j++)
                        {
                            file.WriteLine($"\t \t({i}, {j}),");
                        }
                        //file.WriteLine();
                    }
                }
            }

            //Process.Start(@"C:\Users\Młyńscy\Desktop\AutoGeneracja.txt");

            Console.WriteLine("Zakończono.");
            Console.ReadKey();
        }
    }
}
