using Todo.Domain.Entities;
using Todo.Infrastructure.Repository;

namespace Todo.Application.Services
{
    public class ItemServices : IItemServices
    {
        private readonly IItemRepository _itemRepository;
        public ItemServices(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public Item? Getitem(int id)
        {
            return _itemRepository.GetItem(id);
        }

        public void Postitem(Item item)
        {
            _itemRepository.PostItem(item);
        }
    }
}