using DBNullExtensions.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DBNullExtensions.DataAccess
{
    public class MyContext : DbContext
    {
        public MyContext() : base("DefaultConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        
    }
}