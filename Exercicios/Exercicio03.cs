using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TesteTarget.Exercicios
{
    class Exercicio03
    {
        public static void Executar() {

            double media = 0.0;
            int contador = 0;
            double[] faturamento = { 22174.1664, 24537.6698, 26139.6134, 0.0, 0.0, 26742.6612,0.0,
                42889.2258, 46251.174, 11191.4722, 0.0 ,0.0,3847.4823, 373.7838, 2659.7563, 48924.2448,
                18419.2614,0.0,0.0,35240.1826,43829.1667,18235.6852,4355.0662,13327.1025,0.0,0.0,25681.8318,
                1718.1221,13220.495, 8414.61
            };

            Console.WriteLine($"Maior valor de faturamento: { faturamento.Max()}");
            Console.WriteLine($"Menor valor de faturamento: { faturamento.Min()}");

            
            foreach (var valor in faturamento) {
                media += valor;   
            }
            media = media/30;
            Console.WriteLine($"Média mensal: {media.ToString("F4")}");


            foreach (var v in faturamento) {
                if (v > media && media != 0) {
                    contador++;
                }
            }
            Console.WriteLine($"Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: {contador}");


        }




    }
}
