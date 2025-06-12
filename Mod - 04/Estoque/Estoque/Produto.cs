using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produto
    {

        public string Nome = "";
        public double Preco = 0;
        public int Quantidade = 0;

        public double ValorTotalEmEstoque()
        {
            double Total = Quantidade * Preco;
            return Total;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            Console.WriteLine("Quantidade Adicionada");
        }

        public void RemoverProdutos(int quantidade) 
        {
            int Total = Quantidade - quantidade;

            if(Total < 0)
            {
                Console.WriteLine("Saldo insuficiente de estoque!");
            }
            else{
                Quantidade = Total;
                Console.WriteLine("Saldo removido");
            }
        }

        public override string ToString()
        {
           return Nome 
           + "\n Preço R$" 
           + Preco.ToString("F2", CultureInfo.InvariantCulture) 
           + "\n Quantidade em estoque: " + Quantidade 
           + "\n Valor total de estoque: " 
           + ValorTotalEmEstoque();
        }

    }
}
