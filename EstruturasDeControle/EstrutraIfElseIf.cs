﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstrutraIfElseIf {
        public static void Executar () {

            Console.Write("Digite a nota do Aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if(nota >= 9.0) {
                Console.WriteLine("Quadro de Honra!");
            } else if(nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            } else if(nota >= 5.0) {
                Console.WriteLine("Recuperação!");
            } else {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
