﻿using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public  class PedidoFinalizadoEvent : Event
    {
        public PedidoFinalizadoEvent(Guid pedidoId)
        {
            PedidoId = pedidoId;
        }

        public Guid PedidoId { get; set; }

    }
}
