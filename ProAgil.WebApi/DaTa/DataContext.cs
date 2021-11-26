using Microsoft.EntityFrameworkCore;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.DaTa
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Evento> Eventos { get; set; }
    }
}