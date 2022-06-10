﻿using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoItemAdicionadoEvent: Event
    {
        public PedidoItemAdicionadoEvent(Guid clienteId, Guid pedidoId, Guid produtoId, decimal valorUnitario, int quantidade)
        {
            ClienteId = clienteId;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
        }

        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }

    }
}
