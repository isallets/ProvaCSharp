using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPraticaTP1
{
    public class Produto
    {
        public int Id { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Descricao { get; set; }
        public double Preco {  get; set; }

        public Produto(int id, String marca, String modelo, String descricao, double preco) {

            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Descricao = descricao;
            this.Preco = preco;

        }
    }
}
