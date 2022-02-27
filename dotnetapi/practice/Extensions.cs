using System;
using practice.Dtos;
using practice.Entities;

namespace practice
{
    public static class Extensions
    {
        public static ItemDto AsItemDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}