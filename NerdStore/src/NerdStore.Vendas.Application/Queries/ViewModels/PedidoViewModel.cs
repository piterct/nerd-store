using System;

namespace NerdStore.Vendas.Application.Queries.ViewModels
{
    public class PedidoViewModel
    {
        public int Codigo { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataCadastro { get; set; }
        public int PedidoStatus { get; set; }
    }
}
