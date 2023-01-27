using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTarget.Exercicios
{
    class Exercicio04
    {
        public static void Executar() {
            //array

            double sp = 67.83643;
            double rj = 36.67866;
            double mg = 29.22988;
            double es = 27.16548;
            double outros = 19.84953;
            
            double total;

            total = sp + rj + mg + es + outros;

            sp = (sp / total) * 100;
            rj = (rj / total) * 100;
            mg = (mg / total) * 100;
            es = (es / total) * 100;
            outros = (outros / total) * 100;
            Console.WriteLine($" SP – { sp.ToString("F1")}");
            Console.WriteLine($"RJ – { rj.ToString("F1")}");
            Console.WriteLine($"MG – { mg.ToString("F1")}");
            Console.WriteLine($"ES – { es.ToString("F1")}");
            Console.WriteLine($"Outros – { outros.ToString("F1")}");
  
        }
    }
}
