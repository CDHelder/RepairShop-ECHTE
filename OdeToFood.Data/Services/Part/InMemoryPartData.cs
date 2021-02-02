using RepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepairShop.Data.Services
{
    public class InMemoryPartData : IPartData
    {
        List<Part> parts;

        public InMemoryPartData()
        {
            parts = new List<Part>()
            {
                new Part { Id = 1, Name = "Corsair RGB 9001", PartType = PartType.Motherboard, Price = 150 }
            };
        }

        public void Add(Part part)
        {
            parts.Add(part);
            part.Id = parts.Max(r => r.Id) + 1;
        }

        public void Update(Part part)
        {
            var existing = Get(part.Id);

            if (existing != null)
            {
                existing.Name = part.Name;
                existing.PartType = part.PartType;
                existing.Price = part.Price;
            }
        }

        public Part Get(int id)
        {
            return parts.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Part> GetAll()
        {
            return parts.OrderBy(r => r.Name);
        }

        public void Delete(int id)
        {
            var parts = Get(id);

            if (parts != null)
            {
                //parts.Remove(parts);
            }
        }
    }
}
