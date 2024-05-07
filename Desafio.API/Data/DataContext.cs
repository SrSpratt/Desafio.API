using Desafio.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Desafio.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}