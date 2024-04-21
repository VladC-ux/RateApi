using Exchange.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Exchange.Data
{
    public class ExchangeDBContext : DbContext
    {
        public ExchangeDBContext(DbContextOptions<ExchangeDBContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<ExchangeProvaidor> ExchangeProvaidors { get; set; }
        public DbSet<Rate> Rates { get; set; }
    }
}