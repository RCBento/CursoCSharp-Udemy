using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar () {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // Inverte o sinal da variavel;
            Console.WriteLine(!booleano); // Inverte a afirmação lógica;

            numero1++;
            Console.WriteLine(numero1); // Incrementa uma unidade da varivael;

            --numero1;
            Console.WriteLine(numero1); // Diminui uma unidade da variave;

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
