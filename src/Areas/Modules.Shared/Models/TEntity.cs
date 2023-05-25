namespace Modules.Shared.Models
{
    public interface TEntity<T>
    {
        T Id { get; set; }
    }
}