using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class AssignmentDbContext : DbContext
    {
        public AssignmentDbContext(DbContextOptions<AssignmentDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }
        public virtual DbSet<Data> Datas {get; set;}
        protected  override void OnModelCreating(ModelBuilder modilbuilder)
        {

        }
    }
}
