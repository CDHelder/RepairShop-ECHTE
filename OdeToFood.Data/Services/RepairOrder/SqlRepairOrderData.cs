using RepairShop.Data.Models;
using RepairShop.Data.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class SqlRepairOrderData : IRepairOrderData
    {
        private readonly CollectieDbContext db;

        public SqlRepairOrderData(CollectieDbContext db)
        {
            this.db = db;
        }
        public void Add(RepairOrder repairOrder)
        {
            db.RepairOrders.Add(repairOrder);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var repairOrder = db.RepairOrders.Find(id);
            db.RepairOrders.Remove(repairOrder);
            db.SaveChanges();
        }

        public RepairOrder Get(int id)
        {
            return db.RepairOrders.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<RepairOrder> GetAll()
        {
            return from r in db.RepairOrders
                   orderby r.BeginDate
                   select r;
        }

        public void Update(RepairOrder repairOrder)
        {
            var entry = db.Entry(repairOrder);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
