using Estoque;
using System.Globalization;

string acesso = "";
Produto produto = new Produto();


Console.WriteLine("Bem vindo ao sistema de estoque!");
Console.WriteLine("Insira os dados do produto:");

Console.Write("Nome: ");
produto.Nome = Console.ReadLine();
Console.Write("Quantidade inicial: ");
produto.Quantidade = int.Parse(Console.ReadLine());
Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


while (acesso != "ext") {

    Console.WriteLine();
    Console.WriteLine("Dados do produto");
    Console.WriteLine(produto.ToString());

    Console.WriteLine("Comandos (add - 'adicionar' / rmv - 'remover' / ext - 'sair'");
    acesso = Console.ReadLine();

    

    if (acesso == "rmv")
    {
        Console.WriteLine("Quantos produtos deseja remover?");
        int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        produto.RemoverProdutos(quantidade);

    } else if (acesso == "add")
    {
        Console.WriteLine("Quantos produtos deseja adicionar?");
        int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        produto.AdicionarProdutos(quantidade);

    }

}

Console.WriteLine();
Console.WriteLine("Obrigado por usar o sistema de estoque!");

