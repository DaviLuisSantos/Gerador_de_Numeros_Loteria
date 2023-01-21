using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Loteria
{
    internal class LotoMania
    {
        public static void Lotomania()
        {
            string myfile = @"sorteios.txt";
            Console.WriteLine("//--------------------LotoMania--------------------//");
            HashSet<int> numero = new HashSet<int>();
            Random ale = new Random();
            while (numero.Count < 15)
            {
                numero.Add(ale.Next(1, 101));
            }
            foreach (int item in numero) Console.Write(" {0} ", item);
            using (StreamWriter sw = File.AppendText(myfile))
            {
                DateTime date2 = DateTime.UtcNow;
                string dataLocal = date2.ToLocalTime().ToString();
                foreach (int item in numero) sw.Write(" {0} ", item);
                sw.Write("|| Loto-Mania - {0}", dataLocal);
                sw.WriteLine(" ");

            }
            Console.ReadKey();

        }
    }
}
