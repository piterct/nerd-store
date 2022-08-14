using MediatR;
using NerdStore.Core.Messages.IntegrationEvents;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoEventHandler : 
        INotificationHandler<ProdutoAbaixoEstoqueEvent>,
        INotificationHandler<PedidoIniciadoEvent>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoEventHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Handle(ProdutoAbaixoEstoqueEvent mensagem, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.ObterPorId(mensagem.AggregateId);

            // Enviar um email para a aquicao de mais produtos.

        }

        public Task Handle(PedidoIniciadoEvent notification, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
