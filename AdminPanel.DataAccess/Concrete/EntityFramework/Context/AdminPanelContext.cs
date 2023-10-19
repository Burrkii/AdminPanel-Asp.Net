using AdminPanel.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdminPanel.DataAccess.Concrete.EntityFramework.Context
{
    public class AdminPanelContext:DbContext
    {

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                // UseSqlServer yöntemi ile SQL Server bağlantısını ayarlayın.
                optionsBuilder.UseSqlServer(connectionString:@"Server=DESKTOP-7V9UF6O\TIZER;Database=AdminPanel;Trusted_Connection=true");
          
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim>OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
