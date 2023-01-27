using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTarget.Exercicios
{
    class Exercicio02
    {
        public static int Num;
        
        public static int Valor() {
            Num += 1;
            return Num;
        }


        public static void Executar() {

            //Sequencia Fibonacci

            //array com sequancia
           
            int[] fibonacci = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            Console.WriteLine("Digite um numero:");
            int.TryParse(Console.ReadLine(), out int entrada);

            //Console.WriteLine(entrada);
            

            foreach (var fib in fibonacci) {
                if (entrada == fib)
                {
                    Console.WriteLine($"Esse numero pertence á sequência Fibonacci: {fib}");

                }
                else {
                    Valor();
                }
            }

            if (Num == 10) {
                Console.WriteLine($"Esse numero não pertence á sequência Fibonacci: {entrada}");
            }
        }
        
    }
}
