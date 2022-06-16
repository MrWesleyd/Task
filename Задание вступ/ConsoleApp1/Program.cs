using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Chocolate(15));
            Console.ReadKey();
        }
        static int Chocolate(int x)
        {
            int konec = 0, obertka = 0;

            while (x > 0)
            {
                x--;
                obertka++;
                if (obertka == 3)
                {
                    obertka = 0;
                    x++;
                }
                konec++;
            }
            return konec;
        }
    }
}