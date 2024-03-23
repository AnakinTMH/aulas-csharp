// Escrever um algoritmo que receba a altura e a largura de umretângulo e calcule a sua área: area = largura x altura.

Console.WriteLine("Insira o valor da altura: ");
var altura = Console.ReadLine();
int alturaint = Convert.ToInt32(altura);

Console.WriteLine("Agora insira o valor da largura: ");
var largura = Console.ReadLine();
int larguraint = Convert.ToInt32(largura);

int resultado = (alturaint * larguraint);

Console.WriteLine($"O valor da área do retangulo é: {resultado}");
 