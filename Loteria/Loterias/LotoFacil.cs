using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Loteria
{
    internal class LotoFacil
    {
        public static void Lotofacil()
        {
            string myfile = @"sorteios.txt";
            Console.WriteLine("//--------------------LotoFacil--------------------//");
            HashSet<int> numero = new HashSet<int>();
            Random ale = new Random();
            while (numero.Count < 15)
            {
                numero.Add(ale.Next(1, 16));
            }
            foreach (int item in numero) Console.Write(" {0} ", item);
            using (StreamWriter sw = File.AppendText(myfile))
            {
                DateTime date2 = DateTime.UtcNow;
                string dataLocal = date2.ToLocalTime().ToString();
                foreach (int item in numero) sw.Write(" {0} ", item);
                sw.Write("|| Loto-Facil - {0}", dataLocal);
                sw.WriteLine(" ");

            }
            Console.ReadKey();
        }
    }
}
