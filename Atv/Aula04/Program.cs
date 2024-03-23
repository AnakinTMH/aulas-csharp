using System;

namespace Aula04 {
    class Program {

        /*
        
        Exercício 01
        Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.

        */

        static void Main(String[] args) {

            Console.Title = "Exercicio 01#";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WindowHeight = 40;

            float area;

            Console.WriteLine("Insira o valor da altura do retângulo: ");
            float altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o valor da largura do retângulo: ");
            float largura = Convert.ToInt32(Console.ReadLine());

            area = (altura * largura);

            Console.WriteLine($"O valor da área do retângulo é: {area}");

            Console.ReadKey();
        }

    }

}

