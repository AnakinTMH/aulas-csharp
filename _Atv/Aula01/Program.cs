
//string mensagem = "Olá Mundo C#!";
/*Console.WriteLine("Digite a mensagem: ");
string mensagem = Console.ReadLine();
Console.WriteLine(mensagem);*/

//Console.WriteLine("Digite o valor 'A': ");
//string strA = Console.ReadLine();
//
//Console.WriteLine("Digite o valor 'B': ");
//string strB = Console.ReadLine();
//
//int a = Convert.ToInt32(strA);
//int b = Convert.ToInt32(strB);
//
//int resultado = a + b;
//
//Console.WriteLine("O resultado é: " + resultado);

//Console.WriteLine("Digite o valor 'A': ");
//int a = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine("Digite o valor 'B': ");
//int b = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine($"O resultado é:  {a + b}" );

//Console.WriteLine("Digite o valor 'A': ");
//int a = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine("Digite o valor 'B': ");
//int b = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine($"O resultado é:  {a + b}" );
//
//if ((a + b) >= 6) {
//    Console.WriteLine("Aprovado!");
//}
//else {
//    Console.WriteLine("Reprovado!");
//}

bool executar = true;
int contador = 0;
string[] nomes = new string[]{"A", "B", "C", "D", "E"};

while(executar && contador < letras.Length){

    var letra = letras[contador];
    Console.WriteLine("Letra: " + letra);
    contador++;
}

