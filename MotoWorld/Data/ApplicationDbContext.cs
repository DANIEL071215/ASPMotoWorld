using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MotoWorld.Models;

namespace MotoWorld.Data
{
    public class ApplicationDbContext : IdentityDbContext<Client>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<TypeMoto> TypeMotos { get; set; }
        public DbSet<Moto> Motos { get; set; } 
        public DbSet<Order> Orders { get; set; }

    }
}
