using NerdStore.Core.Data.EventSourcing;
using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class EventSourcingRepository : IEventSourcingRepository
    {
        private readonly IEventStoreService _eventStoreService;

        public EventSourcingRepository(IEventStoreService eventStoreService)
        {
            _eventStoreService = eventStoreService;
        }
        public Task SalvarEvento<TEvent>(TEvent evento) where TEvent : Event
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<StoredEvent>> ObterEventos(Guid aggregateId)
        {
            throw new NotImplementedException();
        }

       
    }
}
