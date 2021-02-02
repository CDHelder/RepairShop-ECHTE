using RepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepairShop.Data.Services
{
    public class InMemoryRepairOrderData : IRepairOrderData
    {
        List<RepairOrder> repairOrders;
        
        public void Add(RepairOrder repairOrder)
        {
            repairOrders.Add(repairOrder);
            repairOrder.Id = repairOrders.Max(r => r.Id) + 1;
        }

        public void Update(RepairOrder repairOrder)
        {
            var existing = Get(repairOrder.Id);

            if (existing != null)
            {
                existing.Name = repairOrder.Name;
                existing.StatusRepair = repairOrder.StatusRepair;
                existing.HoursWorked = repairOrder.HoursWorked;
                existing.RepairEmployee = repairOrder.RepairEmployee;
                existing.BeginDate = repairOrder.BeginDate;
                existing.EndDate = repairOrder.EndDate;
            }
        }

        public RepairOrder Get(int id)
        {
            return repairOrders.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<RepairOrder> GetAll()
        {
            return repairOrders.OrderBy(r => r.Name);
        }

        public void Delete(int id)
        {
            var repairorder = Get(id);

            if (repairorder != null)
            {
                repairOrders.Remove(repairorder);
            }
        }
    }
}
