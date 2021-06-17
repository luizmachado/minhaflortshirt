using Microsoft.EntityFrameworkCore;

namespace minhaflortshirt.Models
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=minhaflor_db;Uid=minhaflor_user;Pwd=minhaflor123;");
        }

        public DbSet<Camiseta> Camisetas {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Colaborador> Colaboradores {get; set;}
        public DbSet<Fornecedor> Fornecedores {get; set;}
    }
}