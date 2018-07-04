using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Kurs.Models
{
    public class Car
    {
        public int Id { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public double Prize { get; set; }
        public DateTime Bought { get; set; }
        public DateTime Sold { get; set; }
    }

    public class CarDBCtxt : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}