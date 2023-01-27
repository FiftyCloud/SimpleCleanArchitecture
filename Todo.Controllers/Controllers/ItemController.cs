using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Todo.Application;
using Todo.Application.Services;
using Todo.Domain.Entities;

namespace Todo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {

        private readonly ILogger<ItemController> _logger;
        private readonly IItemServices _itemService;

        public ItemController(ILogger<ItemController> logger, IItemServices itemServices)
        {
            _logger = logger;
            _itemService = itemServices;
        }

        [HttpGet(Name = "item")]
        public ActionResult<Item> Get(int id)
        {
            return _itemService.Getitem(id) ?? new Item("Default", "Default");
        }

        [HttpPost(Name = "AddDutty")]
        public void Post(Item item)
        {
            _itemService.Postitem(item);
        }
    }
}