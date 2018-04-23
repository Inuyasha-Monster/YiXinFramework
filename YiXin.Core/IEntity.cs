namespace YiXin.Core
{
    public interface IEntity<TPk>
    {
        TPk Id { get; set; }
    }
}