using Domain.Entities;
using System.Data.Entity;

namespace Domain
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(string connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
        }
        public DbSet<IZD> IZDs { get; set; }
    }
}
