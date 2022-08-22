using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade");
            int ida = int.Parse(Console.ReadLine());
            if(ida == 0)
            {
                Console.WriteLine("Retorne uma idade correta");
            }
            else if (ida >= 1 && ida <= 12)
            {
                Console.WriteLine("Voce é uma criança de " + ida +" anos");
            }
            else if(ida > 12 && ida <= 18)
            {
                Console.WriteLine("Voce é um adolecente de " + ida +" anos");
            }
            else if(ida >18 && ida < 60)
            {
                Console.WriteLine("Voce é um adulto de " + ida + " anos");
            }
            else 
            {
                Console.WriteLine("Voce é um idoso de " + ida + " anos");
            }
            Console.ReadLine();
        }
    }
}
