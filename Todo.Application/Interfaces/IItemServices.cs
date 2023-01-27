using Todo.Domain.Entities;

namespace Todo.Application.Services
{
    public interface IItemServices
    {
        Item? Getitem(int id);
        void Postitem(Item item);
    }
}