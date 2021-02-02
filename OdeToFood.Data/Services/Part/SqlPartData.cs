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
    public class SqlPartData : IPartData
    {
        private readonly CollectieDbContext db;

        public SqlPartData(CollectieDbContext db)
        {
            this.db = db;
        }
        public void Add(Part part)
        {
            db.Parts.Add(part);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var parts = db.Parts.Find(id);
            db.Parts.Remove(parts);
            db.SaveChanges();
        }

        public Part Get(int id)
        {
            return db.Parts.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Part> GetAll()
        {
            return db.Parts;
        }

        public void Update(Part part)
        {
            var entry = db.Entry(part);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
