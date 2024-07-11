using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculando_IMC
{
    public class DesafioIMC

    {
         public static void Main(string[] args)
        {

            Console.Write("informe seu peso em kg ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("informe sua altura em metros ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double imc = peso / (altura*altura);

            Console.WriteLine("seu imc é = " + imc);

            if (imc <= 18.5)
            {
                Console.Write("baixo peso");
            }
            else if (imc>=18.6&&imc<=24.9)
            {
                Console.Write("peso normal");
            }
            else if (imc>=25&&imc<=29.9)
            {
                Console.Write("sobrepeso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.Write("obesidade grau 1");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.Write("obesidade grau 2");
            }
            else
            {
                Console.Write("obesidade grau 3");
             }

            
            Console.ReadLine();

        }
    }
}
