using System;

namespace Vídeo {

    class Program {

        static void Main(string[] args) {

            Console.Title = "COMO CE TA HOJI?";
            Console.ForegroundColor = ConsoleColor.DarkYellow;


            Console.WriteLine("COMO CE TA HOJI CHICO?");
            Console.WriteLine("Bem, NORMAR ou Mal?");
            string? resp = Console.ReadLine();

            if (resp == "Bem" || resp == "bem") {
                Console.WriteLine("Nice de mais, é nois");
            }
            else if (resp == "Mal" || resp == "mal") {
                Console.WriteLine("Foda... melhoras ai então poh");
            }
            else if (resp == "NORMAR" || resp == "normar") {
                Console.WriteLine("INTÃO MIM MATA DI UMA VEZ CHICO!");
                Console.ReadKey();
                Console.WriteLine(resp + "... TUDO " + resp);
            }
            else {
                Console.WriteLine("Coloque uma das 3 opções igual eu escrevi o cabaço ");
            }

            Console.ReadKey();

        }

    }

}