using System;
using System.Threading.Tasks;

namespace YiXin.Core
{
    public interface IEventBus
    {
        void Publish<T>(T message) where T : class, new();
        Task PublishAsync<T>(T message) where T : class, new();

        void Publish(Type messageType, object message);
        void PublishAsync(Type messageType, object message);
    }
}