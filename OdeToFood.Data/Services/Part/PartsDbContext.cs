﻿using RepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class PartsDbContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
    }
}
