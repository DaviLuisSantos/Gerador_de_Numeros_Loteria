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
            int[] numero = new int[10]; 
            for (int i = 0; i < 6; i++)
            {
                numero[i]=ale.Next(1,60);
                Console.Write(numero[i] + " ");
            }
            Console.ReadLine();
        }
        static void Quina()
        {
            Random ale = new Random();
            Console.WriteLine("//--------------------Quina--------------------//");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(ale.Next(1, 80) + " ");
            }
            Console.ReadLine();
        }
        static void Lotofacil()
        {
            Random ale = new Random();
            Console.WriteLine("//--------------------LotoFacil--------------------//");
            for (int i= 1; i <= 15; i++)
            {
                Console.Write(ale.Next(1, 25) + " ");
            }
            Console.ReadLine();
        }
        static void Lotomania()
        {
            Random ale = new Random();
            Console.WriteLine("//--------------------LotoMania--------------------//");
            for (int j = 1; j <= 15; j++)
            {
                Console.Write(ale.Next(1, 100) + " ");
            }
            Console.ReadLine();
            
        }
    }
}
