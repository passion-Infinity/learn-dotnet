using System;
using System.Collections.Generic;
using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IItemRepositories
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
    }
}