using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3.Models
{
    public class EnrollmentDBContext : DbContext
    {
        public EnrollmentDBContext(DbContextOptions options) : base(options)
        {

        }

        protected EnrollmentDBContext()
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}