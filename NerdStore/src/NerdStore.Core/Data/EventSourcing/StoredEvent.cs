using System;

namespace NerdStore.Core.Data.EventSourcing
{
    public class StoredEvent
    {

        public Guid Id { get; private set; }
        public string Tipo { get; private set; }
        public DateTime DataOcorrencia { get; private set; }
        public string Dados { get; private set; }
    }
}
