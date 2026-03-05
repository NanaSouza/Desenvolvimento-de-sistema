// Arrays e Listas 
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
string[] diasSemana = new string[7]
{ "domingo", "segunda-feira", "terça-feira", "quarta-feira", "quinta-feira", "sexta-feira", "sábado"};
Console.WriteLine($"{diasSemana[0]}, { diasSemana[3]}"); 

List<string> alunos = new List<string>();
alunos.Add("Nana");
alunos.Add("Lia");
alunos.Add("Marcela");
alunos.Add("Luana");
alunos.Add("Vitoria");

Console.WriteLine(alunos[0]);
for (int i = 0; i < alunos.Count; i++)
{
    Console.WriteLine(alunos[i]);
}//le um por um

foreach (string a in alunos)
{
    Console.WriteLine(a);
}//leitura de todos os dados

alunos.Remove("Lia");
alunos.RemoveAt(0);

bool existeMarcela = alunos.Contains("Marcela");
Console.WriteLine($"A aluna Marcela existe na lista? {existeMarcela}");
if (existeMarcela)
{
    Console.WriteLine("A aluna Marcela existe na lista");
}
else
{
    Console.WriteLine("A aluna Marcela não existe na lista");
}

//ordenando a lista

alunos.Sort();
alunos.Reverse();


//LINQ - Language Integrated Query


List<int> numeros = new List<int>() { 5, 3, 8, 1, 2 };
var maiores = numeros.Where(n => n > 3);

foreach (var m in maiores)
{
    Console.WriteLine(m);
}

//tras o primeiro numero que seja maior que 3, caso nao exista retorna o valor padrao do tipo, no caso 0
var primeiro = numeros.FirstOrDefault(n => n > 3);

//tras o primeiro numero que seja maior que 1
var prim = numeros.First(n => n > 1);

//multiplica cada numero por 2 e retorna uma nova coleção
var dobrar = numeros.Select(n => n * 2);

foreach (var d in dobrar)
{
    Console.WriteLine(d);
}

//somar
var soma = numeros.Sum();
Console.WriteLine($"A soma dos numeros é: {soma}");

//contar
var contar = numeros.Count();
Console.WriteLine($"A quantidade de numeros é: {contar}");

//media
var media = numeros.Average();
Console.WriteLine($"A média dos numeros é: {media}");

//maximo
var maximo = numeros.Max();
Console.WriteLine($"O maior numero é: {maximo}");

//minimo
var minimo = numeros.Min();
Console.WriteLine($"O menor numero é: {minimo}");

List<int> numero = new List<int>() { 5, 3, 4, 1, 2 };
var ordenar = numero.OrderBy(n => n);
var ordenarDesc = numero.OrderByDescending(n => n);
foreach (var o in ordenar)
{
    Console.WriteLine(o);
}

class Pessoa
{   
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Genero { get; set; }
    public string Ecivil { get; set; }
    public string Social { get; set; }
}


List<Pessoa> pessoas = new List<Pessoa>()
{
    new Pessoa() { Nome = "Nana",
    Idade = 26,
    Genero = "Feminino",
    Ecivil = "Solteira",
    Social = "Classe Média"},
};