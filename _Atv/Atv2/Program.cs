using System;

namespace Atv02 {

    class Program {

        /*
        
        Exercício 02 
        
        Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real 
        (R$) e apresentar os valores convertidos em: 

            1. Dólar (1 dólar = 5,17 reais) 
            2. Euro (1 euro = 6,14 reais) 
            3. Peso argentino (1 peso argentino = 0,05 reais)

        */

        static void Main(String[] args) {

            //Configs Básicas

            Console.Title = "Exercício 02";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WindowHeight = 40;

            Console.WriteLine("Insira o valor em REAL para ser convertido R$: ");
            double real = Convert.ToInt32(Console.ReadLine());

            double dolar = (real / 5.17); 
            double euro = (real / 6.14);
            double peso = (real / 0.05);

            Console.WriteLine($"O valor convertido em Dólar é $: {dolar}");
            Console.WriteLine($"O valor convertido em Euro é $: {euro}");
            Console.WriteLine($"O valor convertido em Pesos é $: {peso}");

            Console.ReadKey();

        }

    }

}
