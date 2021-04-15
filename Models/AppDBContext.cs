using Microsoft.EntityFrameworkCore;

namespace minhaflortshirt.Models
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=Escola;Uid=escola_user;Pwd=escola122;");
        }

        public DbSet<Camiseta> Camisetas {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Colaborador> Colaboradores {get; set;}
        public DbSet<Fornecedor> Fornecedores {get; set;}
    }
}