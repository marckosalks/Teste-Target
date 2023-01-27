using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTarget.Exercicios
{
    class Exercicio01
    {
        public static void Executar() {
			//Valor da variavel soma:

			int indice = 13;
			int k = 0;
			int soma = 0;

			while (k < indice)
			{
				k = k + 1;
				soma = k;
			}

			Console.WriteLine(soma);
		}
    }
}
