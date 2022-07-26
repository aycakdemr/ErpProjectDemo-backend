using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class ERPContext : DbContext
    {
        public ERPContext()
        {

        }
        public ERPContext(DbContextOptions<ERPContext> options) : base(options) { }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
