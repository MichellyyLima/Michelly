using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

void mensagem()
{
    Console.WriteLine("renata tá dodói");
}

mensagem();

void Escreva(string msg){
    Console.WriteLine(msg);
}
 Escreva("renatão ta dodói");
 Escreva("ta mesmo");
 Escreva("vamo pro hospital");

 string minhaMsg = "chama a ambulancia";
 Escreva (minhaMsg);
 
 void MostrarIdade(string nome, int idade)
 {
    Escreva($"{nome} tem {idade}");
 }

MostrarIdade("renatão", 15);
MostrarIdade("eu", 15);

void CalcularIdade(string nome, int ano)
{
    int idade = 2024 - ano;
    MostrarIdade(nome,idade);
}
CalcularIdade("renata", 1963);

int MaiorEntre(int a, int b)
{
    if(a >= b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
Console.WriteLine(MaiorEntre (45,22));
Console.WriteLine(MaiorEntre (54,82));
Console.WriteLine(MaiorEntre (4,2));

//exemplo de repetição

 float resultado;

 resultado = (51*2 + 6*6) / 5f;
 Console.WriteLine("a media é: " + resultado);

 resultado = (25*6 + 10*9) / 5f;
 Console.WriteLine("a media é: " + resultado);

 resultado = (96*9+ 3*93) / 5f;
 Console.WriteLine("a media é: " + resultado);
 

void CalcularMedia(int a, int b)
{
    float resultado = (a+b)/2f;
    Console.WriteLine("a media e:" + resultado);
}

CalcularMedia(255,50);
CalcularMedia(99,54);
CalcularMedia(25,50);



void Soma(float a , float b){
    float resultado = a + b;
 Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtracao(float a , float b){
    float resultado = a - b;
 Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicacao(float a , float b){
    float resultado = a * b;
 Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisao(float a , float b){
  if( b == 0){
    Console.WriteLine("erro de divisão por zero");
    return;
  }
    float resultado = a / b;
 Console.WriteLine($"{a} / {b} = {resultado}");
}

//variaveis globais 
float a;
float b;

void DigitarAeB(string operacao){

    Console.WriteLine(operacao);

    Console.WriteLine("digite o valor de a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("digite o valor de b:");
    b = float.Parse(Console.ReadLine());
}
//MENU
Console.WriteLine("---Calculadora----");
Console.WriteLine("| 1 - Soma  ");
Console.WriteLine("|2 - Subtração ");
Console.WriteLine("|3 - Multiplicação ");
Console.WriteLine("|4 - Divisão");
Console.WriteLine("|5 - Sair ");
Console.WriteLine("------------------");
Console.WriteLine("Digite a opção desejada:");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}
else if(opcao == 2){
    DigitarAeB("Subtração");
    Subtracao(a,b);
}
 else if(opcao == 3){
    DigitarAeB("Multiplicação");
    Multiplicacao(a,b);
 }
 else if(opcao == 4){
    DigitarAeB("Divisão");
    Divisao(a,b);
 }
 else if(opcao == 5){
    Console.WriteLine("Saindo...");
 }
 else {
    Console.WriteLine("Opção inválida");
 }

