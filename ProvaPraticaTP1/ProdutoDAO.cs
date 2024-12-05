using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPraticaTP1
{
    internal class ProdutoDAO
    {
        private List<Produto> produtoList = new List<Produto>();

        public void CadastrarProduto(int id, String marca, String modelo, String descricao, double preco)
        {
            var produto = new Produto(id, marca, modelo, descricao, preco);
            produtoList.Add(produto);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        public Produto BuscarProduto(int id)
        {
            Produto produto = produtoList.Find(c => c.Id == id);

            if (produto != null)
            {
                return produto;
            }
            return null;
        }

        public void ListarProdutos()
        {

            foreach (var produto in produtoList)
            {
                Console.WriteLine($"Id: {produto.Id}, Marca: {produto.Marca}, Modelo: {produto.Modelo}, Descricao: {produto.Descricao}, Preco: {produto.Preco}");
            }
        }
        /* FALTA CLASSE DE VENDA PARA TESTAR
        public void DeletarProduto(int id)
        {
            var produto = BuscarProduto(id);
            if (produto != null)
            {
                if (venda.Any(v => v.Produto.Id == produto.Id))
                {
                    Console.WriteLine("Produto não pode ser deletado, pois está associado a uma venda.");
                }
                else
                {
                    produtoList.Remove(produto);
                    Console.WriteLine("Produto deletado com sucesso.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        */
    }
}