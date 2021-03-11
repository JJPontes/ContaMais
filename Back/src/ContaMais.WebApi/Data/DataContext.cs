using Back.src.ContaMais.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContaMais.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        public DbSet<Users> Users { get; set; }
    }
}