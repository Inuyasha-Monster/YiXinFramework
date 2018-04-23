using System;

namespace YiXin.Core
{
    public interface IEvent
    {
        Guid Id { get; set; }
        DateTime CreationDateTime { get; set; }
    }
}