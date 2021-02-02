using RepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepairShop.Web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<RepairOrder> RepairOrder { get; set;}
        public IEnumerable<Part> Part { get; set; }
        public string Message { get; set;}
        public string Name { get; set;}
    }
}