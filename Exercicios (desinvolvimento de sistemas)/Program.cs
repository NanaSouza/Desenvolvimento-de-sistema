//1 Crie um algoritmo que mostre um número par ou ímpar.

Console.WriteLine("Informe um numero");
int n = int.Parse(Console.ReadLine());
n = n % 2;
if (n == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é ímpar");
}






//2 Faça um código onde dois números são inseridos e o sistema diga qual é o maior dos dois

Console.WriteLine("Informe um numero");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe um numero");
int n2 = int.Parse(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine($"O maior numero é {n1}");
}
else
{
    Console.WriteLine($"O maior numero é {n2}");
}



//3 Faça um código onde três notas de um aluno são inseridas, a média é calculada e o sistema aponte se  aluno foi aprovado ou não

int Notas;
Console.WriteLine("Informe sua nota de 1 a 10");
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe sua nota de 1 a 10");
double nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe sua nota de 1 a 10");
double nota3 = double.Parse(Console.ReadLine());
Notas = (int)((nota1 + nota2 + nota3) / 3);
if (Notas >= 7)
{
    Console.WriteLine($"Aluno aprovado com a média {Notas}");
}
else
{
    Console.WriteLine($"Aluno reprovado com a média {Notas}");
}






//4 Leia uma temperatura em graus celcius e converta para fahrenheit (f = (c*9/5)+32)

Console.WriteLine("Informe um numero");
int c = int.Parse(Console.ReadLine());

int f = (c * 9 / 5) + 32;
Console.WriteLine($"A temperatura em fahrenheit é {f}");







//5 Crie um algoritimo que receba dois números inteiros e mostra a soma deles.

Console.WriteLine("Informe um numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe um numero");
int num2 = int.Parse(Console.ReadLine());
int soma = num1 + num2;
Console.WriteLine($"A soma dos numeros é {soma}");


static int Somar (int a, int b)
{
    return a + b;
}
int a;
int b;

Console.WriteLine("Informe um numero");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe um numero");
b = int.Parse(Console.ReadLine());

Console.WriteLine($"A soma dos numeros é {Somar(a, b)}");







//Crie um sistema que calcule o numero de vogais de uma palavra.

Console.WriteLine("Informe uma palavra");
string palavra = Console.ReadLine().ToLower();
int contador = 0;
for (int i = 0; i < palavra.Length; i++)
{
    char letra = palavra[i];
    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
    {
        contador++;
    }
}
Console.WriteLine($"A palavra tem {contador} vogais");
