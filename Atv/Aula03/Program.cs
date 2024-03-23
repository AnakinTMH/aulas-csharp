// Lista de exercícios

//Exercício 01 - Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.



/*
Exercício 02 - Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real(R$) e apresentar os valores convertidos em:1. Dólar (1 dólar = 5,17 reais)2. Euro (1 euro = 6,14 reais)3. Peso argentino (1 peso argentino = 0,05 reais)
*/



//Exercício 03 - Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior.



/*
Exercício 04 - Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens:se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60:Idoso
*/

//Exercicio de Fixação 01 

/* 
Criar um ;programa para processar as seguintes informações de um aluno:
matrícula, nome, nota1, nota2 e se ele está aprovado ou reprovado;

Durante a execução calcular a nota final do aluno utilizando a seguinte regra: notaFinal = (nota1 + nota2) /2.
Se a nota final for igual ou superior a 6 o aluno está aprovado, caso contrário estará reprovado;

O programa deverá imprimir o seguinte relatório;

Mtrícula: xxxx
Nome xxx xxx
Aprovado ()Sim ()Não
Nota Final: xxx
*/

class Program {

    //public static void Main(String[] args){
    static void Main(){
        
        Aluno obj1 = new Aluno();
        
        obj1.Matricula = "A";
        obj1.Nome = "Anakin";
        obj1.Nota1 = 7;
        obj1.Nota2 = 6;

        Aluno obj2 = new Aluno();
        Aluno obj3 = new Aluno();
        Aluno obj4 = new Aluno();
        Aluno obj5 = new Aluno();



    }

        //Logo abaixo está uma declaração de uma função chamada EXECUTAR
static void Executar(){
    

        Console.WriteLine("Por favor insira sua Matrícula: ");
        string matricula = Console.ReadLine();
        Console.WriteLine("Matrícula: " + matricula + " confirmada!");

        Console.WriteLine("Agora insira seu Nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Insira sua primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("E sua segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        double notaFinal = (Calculadora.Somar(nota1, nota2)) /2;

        if (notaFinal >= 6) {
            Console.WriteLine(nome + " Sua nota final é: " + notaFinal + " Você está Aprovado!");
        }
        else {
            Console.WriteLine("Sua nota final é: " + notaFinal + " Você está Reprovado!");
        }
    }

}
