using System;
using System.Collections.Generic;
using practice.Entities;

namespace practice.Repositories
{
    public interface IItemRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}