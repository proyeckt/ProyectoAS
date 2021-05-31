using System;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Services.Contracts
{
    public interface IItemService
    {
        public Item findItem(int id);
        public bool saveItem(Item item);
        public List<Item> findItems();
    }
}
