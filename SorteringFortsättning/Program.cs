using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SorteringFortsättning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tärningar ska kastas?");
            int antalTärningar = int.Parse(Console.ReadLine());
            List<int> Tärningslista = new List<int>();
            Tärningslista = Tärningskast(antalTärningar);

            Console.WriteLine("Vill du sortera i stigande eller fallande ordning? s/f");
            string svar = Console.ReadLine();


            if (svar == "s")
            {
                Console.WriteLine("Sorterar tärningskast \n");
                DateTime startTid = DateTime.Now;
                BubbleSort(Tärningslista);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera \n", deltaTid.TotalMilliseconds);

                Console.WriteLine("Sorterar redan sorterad data \n");
                startTid = DateTime.Now;
                BubbleSort(Tärningslista);
                deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera \n", deltaTid.TotalMilliseconds);

                foreach (int tärning in Tärningslista)
                    Console.WriteLine(tärning);
            }

            else if (svar == "f")
            {
                Console.WriteLine("Sorterar tärningskast \n");
                DateTime startTid = DateTime.Now;
                Tärningslista = BubbleSort2(Tärningslista);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera \n", deltaTid.TotalMilliseconds);

                Console.WriteLine("Sorterar redan sorterad data \n");
                startTid = DateTime.Now;
                Tärningslista = BubbleSort2(Tärningslista);
                deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera \n", deltaTid.TotalMilliseconds);

                foreach (int tärning in Tärningslista)
                    Console.WriteLine(tärning);
            }
        }

        static List<int> Tärningskast(int antalTärningar)
        {
            List<int> Tärningslista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < antalTärningar; i++)
            {
                Tärningslista.Add(rnd.Next(1, 7));
            }

            return Tärningslista;
        }

        static void BubbleSort(List<int> Tärningslista)
        {
            bool behöverSorteras = true;


            for (int i = 0; i < Tärningslista.Count - 1 && behöverSorteras; i++)
            {
                behöverSorteras = false;
                for (int j = 0; j < Tärningslista.Count -1-i; j++)
                {
                    if (Tärningslista[j] > Tärningslista[j + 1])
                    {
                        behöverSorteras = true;
                        int tmp = Tärningslista[j + 1];
                        Tärningslista[j + 1] = Tärningslista[j];
                        Tärningslista[j] = tmp;
                    }
                }
            }
 
        }

        static List<int> BubbleSort2(List<int> Tärningslista)
        {
            bool behöverSorteras = true;

            for (int i = 0; i < Tärningslista.Count - 1 && behöverSorteras; i++)
            {
                behöverSorteras = false;
                for (int j = 0; j < Tärningslista.Count - 1 - i; j++)
                {
                    if (Tärningslista[j] < Tärningslista[j + 1])
                    {
                        behöverSorteras = true;
                        int tmp = Tärningslista[j + 1];
                        Tärningslista[j] = Tärningslista[j + 1];
                        Tärningslista[j] = tmp;
                    }
                }
            }
            return Tärningslista;
        }
    }
}
