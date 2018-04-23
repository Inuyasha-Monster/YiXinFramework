using System;

namespace YiXin.Core
{
    public class EntityGuid : EntityBase<Guid>
    {
        public override Guid Id { get; set; }
    }
}