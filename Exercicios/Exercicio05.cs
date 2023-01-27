using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTarget.Exercicios
{
    public static class Extensions
    {
        public static string Reverter(this string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }

    class Exercicio05
    {
        //PS:

        public static void Executar() {
          
            string str = "Target Sistemas";

            string reverse = str.Reverter();
            Console.WriteLine(reverse);


        }


    }
}
