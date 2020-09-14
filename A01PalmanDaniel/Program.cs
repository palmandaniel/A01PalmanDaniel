using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01PalmanDaniel
{
    class Program
    {
        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok.dat");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(' ');
                int[] adatok = new int[1000];

                for (int i = 0; i < adatok.Length; i++)
                {
                    adatok[i] = int.Parse(sor[i]);
                }
                int[] adat = new int[1000];
                for (int i = 0; i < adatok.Length; i++)
                {
                    adat[i] = adatok[i] * 2;
                    Console.WriteLine("{0}",adat);
                }
                

            }
            sr.Close();
        }
        static void Maximumertek()
        { 
            
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Maximumertek();
            Console.ReadKey();

        }
    }
}
