using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoItemAdicionadoEvent: Event
    {
        public PedidoItemAdicionadoEvent(Guid clienteId, Guid pedidoId, decimal valorUnitario, Guid produtoId, string produtoNome, int quantidade)
        {
            AggregateId = pedidoId;
            ClienteId = clienteId;
            ProdutoNome = produtoNome;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
        }

        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string ProdutoNome { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }
    }
}
