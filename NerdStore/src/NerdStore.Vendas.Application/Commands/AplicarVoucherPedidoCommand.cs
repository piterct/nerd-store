﻿using FluentValidation;
using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Vendas.Application.Commands
{
    public class AplicarVoucherPedidoCommand : Command
    {
        public AplicarVoucherPedidoCommand(Guid clienteId, Guid pedidoId, string codigoVoucher)
        {
            ClienteId = clienteId;
            PedidoId = pedidoId;
            CodigoVoucher = codigoVoucher;
        }

        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public string CodigoVoucher { get; private set; }

        public override bool EhValido()
        {
            ValidationResult = new AplicarVoucherPedidoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }

    public class AplicarVoucherPedidoValidation : AbstractValidator<AplicarVoucherPedidoCommand>
    {
        public AplicarVoucherPedidoValidation()
        {
            RuleFor(c => c.ClienteId)
                .NotEqual(Guid.Empty)
                .WithMessage("Id do cliente inválido");

            RuleFor(c => c.PedidoId)
               .NotEqual(Guid.Empty)
               .WithMessage("Id do pedido inválido");

            RuleFor(c => c.CodigoVoucher)
                .NotEmpty()
                .WithMessage("O código do voucher não pode ser vazio");
        }
    }
}
