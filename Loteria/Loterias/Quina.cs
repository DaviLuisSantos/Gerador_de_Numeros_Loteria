using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Loteria
{
    public class Quina
    {
        public static void Quinta()
        {
            string myfile = @"sorteios.txt";
            Console.WriteLine("//--------------------Quina--------------------//");
            HashSet<int> numero = new HashSet<int>();
            Random ale = new Random();
            while (numero.Count < 5)
            {
                numero.Add(ale.Next(1, 81));
            }
            foreach (int item in numero) Console.Write(" {0} ", item);
            using (StreamWriter sw = File.AppendText(myfile))
            {
                DateTime date2 = DateTime.UtcNow;
                string dataLocal = date2.ToLocalTime().ToString();
                foreach (int item in numero) sw.Write(" {0} ", item);
                sw.Write("|| Quina - {0}", dataLocal);
                sw.WriteLine(" ");

            }
            Console.ReadKey();
        }
    }
}
