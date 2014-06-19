using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Data.Entity;

namespace RCW.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Release { get; set; }
        public decimal Price { get; set; }
    }

    public class CarDBContext : DbContext
    {
        public DbSet<Car> Movies { get; set; }
    }
}