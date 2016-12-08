using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Final4125.Models
{
    public class Test
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    public class TestDBContext : DbContext
    {
        public DbSet<Test> Movies { get; set; }
    }
}