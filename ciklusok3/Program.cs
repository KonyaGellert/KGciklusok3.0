using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> lista = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                lista.Add(rnd.Next(1, 101));
            }

            int osszeg = 0;
            int legnagyobb = lista[0];
            int legkisebb = lista[0];
            bool vanKisebb5 = false;
            int dbNagyobb90 = 0;
            List<int> nagyobb90Lista = new List<int>();


            for (int i = 0; i < lista.Count; i++)
            {
                int szam = lista[i];

                // Összeg
                osszeg += szam;

                // legnagyobb
                if (szam > legnagyobb)
                {
                    legnagyobb = szam;
                }

                // Legkisebb
                if (szam < legkisebb)
                {
                    legkisebb = szam;
                }

                //5nél kisebb
                if (szam < 5)
                {
                    vanKisebb5 = true;
                }

                // 90nél nagyobbak
                if (szam > 90)
                {
                    dbNagyobb90++;
                    nagyobb90Lista.Add(szam);
                }
            }

            // átlag számítása
            double atlag = (double)osszeg / lista.Count;



            Console.WriteLine("Összeg: " + osszeg);
            Console.WriteLine("Átlag: " + atlag.ToString("F2"));
            Console.WriteLine("Legnagyobb elem: " + legnagyobb);
            Console.WriteLine("legkisebb elem: " + legkisebb);
            Console.WriteLine("Van-e 5nél kisebb érték?: " + (vanKisebb5 ? "Igen" : "Nincs"));
            Console.WriteLine("90nél nagyobb számok száma: " + dbNagyobb90);

            if (dbNagyobb90 > 0)
            {
                Console.Write("90-nél nagyobb számok: ");
                for (int i = 0; i < nagyobb90Lista.Count; i++)
                {
                    Console.Write(nagyobb90Lista[i]);
                    if (i < nagyobb90Lista.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
