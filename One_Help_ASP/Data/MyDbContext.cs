using Microsoft.EntityFrameworkCore;
using One_Help_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace One_Help_ASP.Data
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Benevole> Benevole { get; set; }
       
        public DbSet<Association> Association { get; set; }

        public DbSet<User> User { get; set; }
    }
}
