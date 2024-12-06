using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPraticaTP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clienteDAO = new ClienteDAO();
            var produtoDAO = new ProdutoDAO();

            //Cadastro de clientes
            clienteDAO.CadastrarCliente(1, "Isabelly", 20, 12345);
            clienteDAO.CadastrarCliente(2, "Isabelle", 20, 12348);

            //Cadastro de produto
            produtoDAO.CadastrarProduto(1, "LG", "TV 50''", "SmartTV", 2500);

            Console.WriteLine("Clientes:");
            clienteDAO.ListarClientes();

            Console.WriteLine("Produtos:");
            produtoDAO.ListarProdutos();
        }
    }
}
