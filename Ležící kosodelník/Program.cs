using System;

namespace Ležící_kosodelník
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte délku kosodelníku od 1 do 75");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte výšku kosodelníku od 1 do 44");
            int v = int.Parse(Console.ReadLine());
            if (d < 1 || d > 75 || v < 1 || v > 44)
            {
                Console.WriteLine("Neplatný vstup");
                Console.ReadLine();
            }

            int odsazeni = 45;
            int odradkovani = 10;
            int a = odsazeni - v - 1;
            int b = odradkovani + v + 1;
            char hrana = '–';
            char stěna = '/';

            Kosodelník k = new Kosodelník();
            Kosodelník s = new Kosodelník();
            Kosodelník z = new Kosodelník();

            k.Strop(d, odsazeni, odradkovani, hrana);
            s.Stěny(d, v, odsazeni, odradkovani, stěna);
            z.Země(d, a, b, hrana);
            Console.ReadLine();
        }
    }
    class Kosodelník
    {
        public void Strop(int d, int odsazeni, int odradkovani, char hrana)
        {
            Console.SetCursorPosition(odsazeni, odradkovani);
            for (int i = 0; i < d; i++)
            {
                Console.Write("{0}", hrana);
            }
            Console.WriteLine();
            return;
        }
        public void Stěny(int d, int v, int odsazeni, int odradkovani, char stěna)
        {
            for (int i = 0; i < v; i++)
            {
                odsazeni -= 1;
                odradkovani += 1;
                Console.SetCursorPosition(odsazeni, odradkovani);

                Console.Write("{0}", stěna);
                for (int j = 1; j < d; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("{0}", stěna);
            }
            return;
        }
        public void Země(int d, int a, int b, char hrana)
        {
            Console.SetCursorPosition(a, b);
            Console.Write(" ");
            for (int i = 0; i < d; i++)
            {
                Console.Write("{0}", hrana);
            }
            Console.WriteLine();
            return;
        }
    }
}