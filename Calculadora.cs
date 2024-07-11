using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite o 1 numero");
            int n1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("digite o 2 numero");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a operacao desejada");
            var operacao = Console.ReadLine();
            var soma1 = n1 + n2;
            var sub2 = n1 - n2;
            var div3 = n1 / n2;
            var multi4 = n1 * n2;


             
            if(operacao == "+")
            {
                Console.WriteLine("a soma dos numero é " + soma1);
            }
            else if ( operacao == "-")
            {
                Console.WriteLine("a subtracao dos numeros é " + sub2 );
            }
            else if (operacao == "*") 
            {
                Console.WriteLine("a multiplicacao dos  numeros é " + multi4);
            }
            else
            {
                Console.WriteLine("a divisao dos numeros é " + div3);
            }
            Console.ReadKey();
        }
    }
}
