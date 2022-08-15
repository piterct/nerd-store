namespace NerdStore.Pagamentos.Business
{
    public interface IPagamentoRepository
    {
        void Adicionar(Pagamento pagamento);
        void AdicionarTransacao(Transacao transacao);
    }
}
