using RepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class CollectieDbContext : DbContext
    {
        public DbSet<RepairOrder> RepairOrders { get; set; }
        public DbSet<Part> Parts { get; set; }
    }
}
