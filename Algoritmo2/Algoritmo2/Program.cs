int idade = 10;
string nomeCliente = "Danton Ferrari";
decimal preco = 20.4m;
char letra = 'a';
var nomeCompleto = "Danton Gabriel Neis Ferrari";
var altura = 180;

Console.Write("Digite seu nome: ");
nomeCompleto = Console.ReadLine();
Console.WriteLine("Bem vindo " + nomeCompleto);
Console.WriteLine();
Console.Write("Digite sua idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade informada: " + idade);
Console.ReadKey();
