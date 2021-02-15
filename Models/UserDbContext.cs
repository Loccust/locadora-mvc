using System.Data.Entity;
using System.Collections.Generic;

namespace locadora.Models
{
    public class UserDbContext : DbContext
    { 
        public DbSet<UserModel> Produtos { get; set; }
    }
}