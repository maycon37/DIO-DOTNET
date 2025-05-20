using DIO_DOTNET.Models;

Pessoa pessoal = new Pessoa();

pessoal.Nome = "Maycon Rodrigues";
pessoal.Idade = 33;
pessoal.Apresentar();

string apresentaçao = "Olá, seja bem vindo!!";
int quantidade = 1;
double altura = 1.89;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentaçao);
Console.WriteLine("Valor da variável quantidade: "+ quantidade);
Console.WriteLine("Valor da variável altura: "+ altura.ToString("0.00"));
Console.WriteLine("Valor da variável preço: "+ preco);
Console.WriteLine("Valor da variável condição: " + condicao);

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine("Hoje é dia: " + dataAtual.ToString("dd")+", do mês de "+dataAtual.ToString("MMMM")+", no ano de "+ dataAtual.ToString("yyyy"));