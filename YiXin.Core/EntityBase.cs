namespace YiXin.Core
{
    public abstract class EntityBase<TPk> : IEntity<TPk>
    {
        public abstract TPk Id { get; set; }
    }
}