using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Brinquedo> Brinquedos => Set<Brinquedo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Brinquedo>().HasData(
            new Brinquedo { IdBrinquedo = 1, NomeBrinquedo = "Carrinho", TipoBrinquedo = "Veículo", Classificacao = "Livre", Tamanho = "Pequeno", Preco = 29.90m },
            new Brinquedo { IdBrinquedo = 2, NomeBrinquedo = "Boneca",   TipoBrinquedo = "Boneca",  Classificacao = "Livre", Tamanho = "Médio",   Preco = 59.90m },
            new Brinquedo { IdBrinquedo = 3, NomeBrinquedo = "Quebra-cabeça 100 peças", TipoBrinquedo = "Puzzle", Classificacao = "+6", Tamanho = "Médio", Preco = 39.90m }
        );
    }
}
 