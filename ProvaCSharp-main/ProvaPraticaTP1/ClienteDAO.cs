using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPraticaTP1
{
    internal class ClienteDAO
    {
        private List<Cliente> clienteList = new List<Cliente>();

        public void CadastrarCliente(int id, String nome, int idade, double CPF)
        {
            clienteList.Add(new Cliente(id, nome, idade, CPF));
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        public Cliente BuscarCliente(int id)
        {
            Cliente cliente = clienteList.Find(c => c.Id == id);

            if (cliente != null)
            {
                return cliente;
            }
            return null;
        }

        public void ListarClientes() {

            foreach (var cliente in clienteList)
            {
                Console.WriteLine($"Id: {cliente.Id}, Nome: {cliente.Nome}, Idade: {cliente.Idade}, CPF: {cliente.CPF}");
            }
        }
        /* FALTA CLASSE DE VENDA PARA TESTAR
        public void DeletarCliente(int id)
        {
            var cliente = BuscarCliente(id);
            if (cliente != null)
            {
                if (venda.Any(v => v.Cliente.Id == cliente.Id))
                {
                    Console.WriteLine("Cliente não pode ser removido, pois está associado a uma venda.");
                }
                else
                {
                    clienteList.Remove(cliente);
                    Console.WriteLine("Cliente removido com sucesso.");
                }
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
        */
    }
}

