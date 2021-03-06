using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        public IList<PromocaoProduto> Produtos { get; set; }

        public Promocao()
        {
            Produtos = new List<PromocaoProduto>();
        }

        public void IncluiProduto(Produto produto)
        {
            Produtos.Add(new PromocaoProduto() { Produto =  produto });
        }
    }
}
