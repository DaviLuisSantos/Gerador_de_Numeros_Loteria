using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cond = true;
            while (cond)
            {
                Princ();
                Console.WriteLine("Deseja fazer mais um sorteio?\n1- SIM\n2- NÃO");
                char res = char.Parse(Console.ReadLine());
                switch (res)
                {
                    case '1':
                        cond = true;
                        break;
                    case '2':
                        cond = false;
                        break;
                }
            }
            Console.ReadLine();
        }
        static void Princ()
        {
            char res;
            Console.WriteLine("Informe qual a loteria desejada:\n1- Mega-Sena\n2- Quina\n3- Lotofácil\n4- Lotomania");

            res = char.Parse(Console.ReadLine());

            switch (res)
            {
                case '1':
                    MegaSena();
                    break;
                case '2':
                    Quina();
                    break;
                case '3':
                    Lotofacil();
                    break;
                case '4':
                    Lotomania();
                    break;
            }
        }
        static void MegaSena()
        {
            Random ale = new Random();
            Console.WriteLine("//--------------------Mega-Sena--------------------//");
            int[] numero = new int[6];
            int[] semDupli=new int[6];
            for (int i = 0; i < 6; i++)
            {
                numero[i]=ale.Next(1,60);
                semDupli = numero.Distinct().ToArray();
            }
            foreach (int item in semDupli) Console.Write(" {0} ",item);
            Console.ReadKey();
        }
        static void Quina()
        {
            Random ale = new Random();
            Console.WriteLine("//--------------------Quina--------------------//");
            int[] numero = new int[5];
            int[] semDupli = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numero[i] = ale.Next(1, 80);
                semDupli=numero.Distinct().ToArray();
            }
            foreach(int item in semDupli) Console.Write(" {0} ", item);
            Console.ReadKey();
        }
        static void Lotofacil()
        {
            Random ale = new Random();
            Console.WriteLine("//--------------------LotoFacil--------------------//");
            int[] numero = new int[15];
            int[] semDupli = new int[15];
            for (int i= 0; i < 15; i++)
            {
                numero[i] = ale.Next(1, 25);
                semDupli = numero.Distinct().ToArray();
            }
            foreach(int item in semDupli) Console.Write(" {0} ", item);
            Console.ReadKey();
        }
        static void Lotomania()
        {
            Random ale = new Random();
            Console.WriteLine("//--------------------LotoMania--------------------//");
            int[] numero=new int[15];
            int[] semDupli = new int[15];
            for (int i = 0; i < 15; i++)
            {
                numero[i] = ale.Next(1, 100);
                semDupli = numero.Distinct().ToArray();
            }
            foreach (int item in semDupli) Console.Write(" {0} ", item);
            Console.ReadKey();
            
        }
    }
}
