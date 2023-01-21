using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loteria;
using System.IO;

namespace Loteria
{
    internal class Program
    {
        public const string MEGA_SENA = "1";
        public const string QUINA = "2";
        public const string LOTO_FACIL = "3";
        public const string LOTO_MANIA= "4";
        public const string JOGOS_ANTERIORES = "5";
        public const string SAIR = "6";
        public const string CONTINUA_PROGRAMA = "1";
        public const string SAI_PROGRAMA = "2";
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool cond = true;
            while (cond) 
            {
               
                    Princ();
                cond=(Teste());
                if (cond == false)
                {
                    break;
                }
            }           
        }
        private static void Princ()
        {
            string res;
            Console.WriteLine("Informe qual a loteria desejada:\n1- Mega-Sena\n2- Quina\n3- Lotofácil\n4- Lotomania\n5- Jogos Anteriores");

            res = Console.ReadLine();
            
                switch (res)
                {
                    case MEGA_SENA:
                    MegaSena.Megasena();
                        break;
                    case QUINA:
                    Quina.Quinta();
                        break;
                    case LOTO_FACIL:
                    LotoFacil.Lotofacil();
                        break;
                    case LOTO_MANIA:
                    LotoMania.Lotomania();
                        break;
                    case JOGOS_ANTERIORES:
                    JogosAnteriores.Jogoanterior();
                    break;
                default:
                    Console.WriteLine("Nenhuma Loteria foi selecionada!\n");
                    Princ();
                    break;
                }
            
        }
        public static bool Teste()
        {
            var cond = true;
            Console.WriteLine("\nDeseja fazer mais um sorteio?\n1- SIM\n2- NÃO");
            string res = Console.ReadLine();
            switch (res)
            {
                case CONTINUA_PROGRAMA:
                    cond = true;
                    break;
                case SAI_PROGRAMA:
                    cond = false;
                    break;
                default:
                    cond = false;
                    break;
            }
            return cond;
        }
    }
}
