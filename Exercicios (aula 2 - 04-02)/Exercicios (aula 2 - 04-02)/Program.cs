//1 Crie uma função que receba três valores (double) e retorne a média aritmética

double Media;

Console.WriteLine("Informe um valor: ");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("informe um valor: ");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe um valor: ");
double n3 = double.Parse(Console.ReadLine());

Media = (double)(n1 + n2 + n3 / 3);



Console.WriteLine(Media);
Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();

Console.Clear();


//2 Maior Valor: Crie uma função que receba dois números inteiros e retorne o maior valor (DICA: Existe uma função nativa para isso)

Console.WriteLine("Digite um número inteiro");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número inteiro");
int num2 = int.Parse(Console.ReadLine());
string texto = "Os numeros são iguais";

static string Maior(double num1, double num2)
{
    return $"O maior número é: {Math.Max(num1, num2)}";
}
Console.WriteLine(Maior(num1, num2));


Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();

Console.Clear();


//3 Área de um Retângulo: Crie uma função que receba a base e a altura de um retângulo e retorne a área.

Console.WriteLine("Digite a base do retângulo");
double baseRet = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do retângulo");
double alturaRet = double.Parse(Console.ReadLine());
static double area(double baseRet, double alturaRet)
{
    return baseRet * alturaRet;
}
Console.WriteLine($"A área do retângulo é: {area(baseRet, alturaRet)}");


Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();

Console.Clear();

//4 Formato Americano: Usando funções nativas, transforme a data de hoje, que está no formato BR, no formato americano.

DateTime datahoje = DateTime.Now;
string dataAme = datahoje.ToString("MM/dd/yyyy");
Console.WriteLine($"A data de hoje no formato americano é: {dataAme}");


Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();

Console.Clear();


//5 Número Primo: Crie uma função que confira se um número é primo ou não.

static string Primo(int numPrimo)
{
    if (numPrimo < 2)
    {
        return $"O número {numPrimo} não é primo";
    }
    for (int i = 2; i <= numPrimo; i++)
    {
        if (numPrimo % i == 0)
            return $"O número {numPrimo} não é primo";
    }

    return $"O número {numPrimo} é primo";

}

Console.WriteLine("Digite um número inteiro");
int numPrimo = int.Parse(Console.ReadLine());

Console.WriteLine(Primo(numPrimo));


Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();

Console.Clear();


//6 Troca de Caracteres: Crie uma função que substitua todos os espaços por hifens.

Console.WriteLine("Digite uma frase");
string texto1 = Console.ReadLine();
string novotexto = texto1.Replace(" ", "-");
Console.WriteLine(novotexto);


Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();
Console.Clear();

//7 Palíndromo: Crie uma função que receba uma palavra e retorne true se for um palíndromo (ignorando maiúsculas e minúsculas).

Console.WriteLine("Digite uma palavra");
string palavra = Console.ReadLine().ToLower();
string palavraInvertida = new string(palavra.Reverse().ToArray());
if (palavra == palavraInvertida)
{
    Console.WriteLine("A palavra é um palíndromo");
}
else
{
    Console.WriteLine("A palavra não é um palíndromo");
}


Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();
Console.Clear();

//8 Conta Palavras: Crie uma função que receba uma frase e retorne a quantidade de palavras contidas nela.

Console.WriteLine("Digite uma frase");
string frase = Console.ReadLine();
string[] palavras = frase.Split(" ");
Console.WriteLine(palavras.Length);

Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();

Console.Clear();

//9 Idade Atual: Crie uma função que receba a data de nascimento de alguém e retorne a idade atual da pessoa.

Console.WriteLine("Digite sua data de nascimento (dd/MM/yyyy)");
DateTime dataNasc = DateTime.Parse(Console.ReadLine());
DateTime dataAtual = DateTime.Now;
int Idade = dataAtual.Year - dataNasc.Year;
if (dataNasc > dataAtual.AddYears(-Idade))
{
    Idade--;
}
Console.WriteLine($"Sua idade atual é: {Idade} anos");


Console.WriteLine("Aperte enter para prosseguir");
Console.ReadLine();

Console.Clear();


//10 Validade: Crie uma função que receba uma data de vencimento e retorne se está "Vencido", se "Vence Hoje" ou se está "Dentro do Prazo".


DateTime dataValidade = new DateTime(2040, 02, 05);

Console.WriteLine("Digite a data do vencimento");
DateTime vencimento = DateTime.Parse(Console.ReadLine());
if (vencimento < dataValidade)
{
    Console.WriteLine("Produto vencido");
}
else if (vencimento == dataValidade)
{
    Console.WriteLine("Produto vence hoje");
}
else
{
    Console.WriteLine("Produto dentro do prazo");
}


Console.WriteLine("Obrigada por participar do teste, aperte enter para finalizar");
Console.ReadLine();