using Microsoft.EntityFrameworkCore;

public class VentasDbContext : DbContext
{
    public VentasDbContext(DbContextOptions<VentasDbContext> options) : base(options) { }

    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<Producto> Producto { get; set; }
    public DbSet<Venta> Venta { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración explícita de la clave primaria para Categoria, Prod. y Venta
        modelBuilder.Entity<Categoria>()
            .HasKey(c => c.CodigoCategoria);

        modelBuilder.Entity<Producto>()
            .HasKey(p => p.CodigoProducto);

        modelBuilder.Entity<Venta>()
            .HasKey(p => p.CodigoVenta);

        // Configuración de la relación entre Producto y Categoria
        modelBuilder.Entity<Producto>()
            .HasOne(p => p.Categoria)
            .WithMany(c => c.Productos)
            .HasForeignKey(p => p.CodigoCategoria);

        // Configuración de la relación entre Venta y Producto
        modelBuilder.Entity<Venta>()
            .HasOne(v => v.Producto)
            .WithMany(p => p.Ventas)
            .HasForeignKey(v => v.CodigoProducto);
    }
}
