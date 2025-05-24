using DIO_DOTNET.Models;

Pessoa pessoal = new Pessoa();
Console.WriteLine("Apresentação!");

pessoal.Nome = "Maycon Rodrigues";
pessoal.Idade = 33;
pessoal.Apresentar();

string apresentaçao = "Olá, seja bem vindo!!";
Console.WriteLine("Informações sobre o usuário:");
int quantidade = 1;
double altura = 1.89;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentaçao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine("Hoje é dia: " + dataAtual.ToString("dd") + ", do mês de " + dataAtual.ToString("MMMM") + ", no ano de " + dataAtual.ToString("yyyy"));

int quantidaEmEstoque = 10;
int quantidadedeCompra = 4;
bool possivelVenda = quantidadedeCompra > 0 && quantidaEmEstoque >= quantidadedeCompra;

Console.WriteLine("Condicionais:");
Console.WriteLine($"Quantidade em estoque: {quantidaEmEstoque}");
Console.WriteLine($"Quantidade compra :{quantidadedeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (quantidadedeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda Realizada!");
}
else
{
    Console.WriteLine("Venda negada! não temos a quantidade deseja no estoque.");
}

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal!");
        break;

    default:
        Console.WriteLine("Não é uma vogal.");
        break;

}