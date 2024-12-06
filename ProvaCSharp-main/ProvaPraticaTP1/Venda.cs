using System;


namespace ProvaPraticaTP1 {
    public class Venda
    {
        public int id { get; set; };
        public static int idGerado { get; set; }
        public Cliente cliente { get; set; };
        public ResumoVenda<Produto produto, int quantidade> Produto { get; set; };

        public Venda(int id, Cliente cliente, ResumoVenda resumoVenda)
        {
            this.id = idGerado;
            this.cliente = cliente;
            this.Produto = Produto;

        }

        public geradorDeID(int id) {
        {

        }
    }
}