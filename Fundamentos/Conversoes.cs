﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar () {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine($"Nota Truncada: {notaTruncada}");

            Console.Write("Digite sua Idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"Resultado 1: {numero1}");

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado 2: {numero2}");
        }
    }
}
