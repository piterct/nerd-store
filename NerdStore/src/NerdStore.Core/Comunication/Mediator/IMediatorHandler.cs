using NerdStore.Core.Messages;
using System.Threading.Tasks;

namespace NerdStore.Core.Comunication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T: Event;
        Task<bool> EnviarComando<T>(T evento) where T : Command;
    }
}
