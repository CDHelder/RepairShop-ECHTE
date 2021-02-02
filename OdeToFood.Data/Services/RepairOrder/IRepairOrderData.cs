using RepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Data.Services
{
    public interface IRepairOrderData
    {
        IEnumerable<RepairOrder> GetAll();
        RepairOrder Get(int id);
        void Add(RepairOrder repairOrder);
        void Update(RepairOrder repairOrder);
        void Delete(int id);
    }
}
