using System;

namespace YiXin.Core
{
    public class IntegrationEvent : IEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}