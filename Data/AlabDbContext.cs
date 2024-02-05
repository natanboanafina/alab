using Microsoft.EntityFrameworkCore;
public class AlabDbContext : DbContext
{
    public DbSet<Carro> Carros { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ClienteContratoCarro> ClientesContratosCarros { get; set; }
    public DbSet<Contrato> Contratos { get; set; }
    public DbSet<ContratoPlano> ContratosPlanos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Plano> Planos { get; set; }

    public AlabDbContext() { }
    public AlabDbContext(DbContextOptions<AlabDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=alab;Username=postgres;Password=root");
        }
    }
}
