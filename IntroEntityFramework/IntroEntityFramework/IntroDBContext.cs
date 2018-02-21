using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEntityFramework
{
    public class IntroDBContext : DbContext
    {
        public IntroDBContext() : base()
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Order { get; set; }
    }
}