﻿using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Commands
{
    public class FinalizarPedidoCommand : Command
    {
        public FinalizarPedidoCommand(Guid pedidoId, Guid clienteId)
        {
            PedidoId = pedidoId;
            ClienteId = clienteId;
        }

        public Guid PedidoId { get; set; }
        public Guid ClienteId { get; set; }

    }
}
