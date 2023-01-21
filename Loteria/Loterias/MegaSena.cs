using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Loteria
{
    public class MegaSena
    {
        public static void Megasena()
        {
            string myfile = @"sorteios.txt";
            Console.WriteLine("//--------------------Mega-Sena--------------------//");
            HashSet<int> numero = new HashSet<int>();
            Random ale = new Random();
            while (numero.Count < 6)
            {
                numero.Add(ale.Next(1, 61));
            }
            foreach (int item in numero) Console.Write(" {0} ", item);
            using (StreamWriter sw = File.AppendText(myfile))
            {
                DateTime date2 = DateTime.UtcNow;
                string dataLocal = date2.ToLocalTime().ToString();
                foreach (int item in numero) sw.Write(" {0} ", item);
                sw.Write("|| Mega-Sena - {0}",dataLocal);
                sw.WriteLine(" ");

            }

            Console.ReadKey();
        }
    }
}
