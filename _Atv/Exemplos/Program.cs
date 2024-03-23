
int a = 1;
int b = 5;
int c = a + b;
var d = 33;
var e = "Texto";
double f = 12.2;
bool isAprovado = true;
string s = "Outro texto";

if (a == b) {
    Console.WriteLine("A soma é: " + c);
} else {
    Console.WriteLine(d);
}

bool isVerd = a == b ? true : false;

int[] vetor1 = new int[4]; 
int[] vetor2 = new int[] {3, 6, 7, 2};

for (int i = 0; i < 4; i++) {
    //int vlr = vetor2[i];
    //Console.WriteLine("Valor vetor 2: " + vlr);
    Console.WriteLine($"Valor vetor 2: {vetor2[i]}");
} 

//vetor1[2] = 23;

int contador = 0;
do {

    Console.WriteLine("Digite um valor: ");
    var str = Console.ReadLine();
    vetor1[contador] = Convert.ToInt32(str);

    contador ++;
} while (contador < 4);

foreach(var vlr in vetor1){
    Console.WriteLine($"Valor vetor 1: {vlr}");
}