using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCAzure.Models
{
    public class CoreContextDB : DbContext
    {
        public CoreContextDB(DbContextOptions<CoreContextDB> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employe> Employes { get; set; }
    }
}
