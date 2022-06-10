using System.Threading.Tasks;
using DragonStore.Core.Messages;

namespace DragonStore.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}