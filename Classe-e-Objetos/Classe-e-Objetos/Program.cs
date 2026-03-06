List<Pessoa> pessoas = new List<Pessoa> //objeto da classe
        {
            new Pessoa{Nome = "Nana",
                      Idade = 26,
                      Genero = "Feminino",
                      ECivil = "Solteira",
                      Social = "Alta"},
            new Pessoa{Nome = "Lucas",
                      Idade = 30,
                      Genero = "Masculino",
                      ECivil = "Casado",
                      Social = "Média"},
            new Pessoa{Nome = "Maria",
                      Idade = 22,
                      Genero = "Feminino",
                      ECivil = "Solteira",
                      Social = "Baixa"},
        };

//ORDERBY
var ordenadoPorNomes = pessoas.OrderBy(p => p.Nome);//Ordena a lista de pessoas por nome usando o método OrderBy e uma expressão lambda que especifica a propriedade Nome como chave de ordenação.
foreach (var o in ordenadoPorNomes)
{
    Console.WriteLine(o.Nome);
}


foreach (var o in ordenadoPorNomes)
{
       Console.WriteLine($"{o.Nome}, {o.Idade}, {o.Genero}, {o.ECivil}, {o.Social}");
}

//GROUPBY
List<int> numeros = new List<int> { 1,3, 4, 5, 2, 9,};
var agrupar = numeros.GroupBy(c => c % 2 == 0);
foreach (var a in agrupar)//percorre todos os dados
{
    Console.WriteLine($"Chave: {a.Key}");//Key define verdadeiro ou falso 
    foreach (var numero in a)//detecta se os numeros são pares ou impares
    {
        Console.WriteLine(numero);
    }
}

//DISTINCT
List<int> num = new List<int> { 2, 2, 3, 4, 4, 6, 7, 8, 8 };
var semRepetir =num.Distinct();//Remove os números repetidos da lista usando o método Distinct.
foreach (var rep in semRepetir)
{
    Console.WriteLine(rep);
}

//TAKE
var tresPrimeiros = num.Take(3);//Seleciona os três primeiros números da lista usando o método Take.
foreach (var t in tresPrimeiros)
{
    Console.WriteLine(t);
}


//SKIP
var aposTresPrimeiros = num.Skip(3);//Ignora os três primeiros números da lista usando o método Skip e seleciona o restante.
foreach (var apos in aposTresPrimeiros)
{
    Console.WriteLine(apos);
}
























class Pessoa //classe
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Genero { get; set; }
    public string ECivil { get; set; }
    public string Social { get; set; }
}

