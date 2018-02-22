using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class IntroDBContext : DbContext
    {
        public IntroDBContext() : base()
        {
        }

        public virtual DbSet<Student> Student { get; set; }
    }
}