using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite 1 para soma: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Resultado: {0}", Soma(n1, n2)); 
                    break;
                case 2:
                    Console.WriteLine("Resultado: {0}", Sub(n1, n2));
                    break;
                case 3:
                    Console.WriteLine("Resultado: {0}", Mult(n1, n2));
                    break;
                case 4:
                    Console.WriteLine("Resultado: {0}", Div(n1, n2));
                    break; 
                default:
                    break;
            }
        }
        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Mult(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Div(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
