using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //nepustat ak chcem skusat try. Ak try tak vycommentovat to nad tym lebo to dlho trva



            const int miliarda = 100000000;
            int[] miliardaPole = new int[miliarda];
            ArrayList miliardaAlist = new ArrayList();

            Stopwatch stopky = new Stopwatch();
            stopky.Start();

            Random r = new Random();
            for (int i = 0; i < miliardaPole.Length; i++)
            {
                miliardaPole[i] = r.Next();
            }
            stopky.Stop();
            Console.WriteLine("Naplnenie pola {0}", stopky.Elapsed);

            stopky.Restart();
            for (int i = 0; i < miliarda; i++)
            {
                miliardaAlist.Add(r.Next());
            }
            stopky.Stop();
            Console.WriteLine("Naplnenie ArrayListu {0}", stopky.Elapsed);

            stopky.Restart();
            Array.Sort(miliardaPole);
            stopky.Stop();
            Console.WriteLine("sort array {0}", stopky.Elapsed);

            stopky.Restart();
            miliardaAlist.Sort();
            stopky.Stop();
            Console.WriteLine("sort alist {0}", stopky.Elapsed);


            string vstup = "3acj";
            try
            {
                int cislo = int.Parse(vstup);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                int nula = 0;
                int cislo = 10 / nula;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }











            //kuknut de sme robili Hashtable ?


            Console.ReadLine();
            


        }
    }
}
