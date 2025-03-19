public class Categoria
{
    public int CodigoCategoria { get; set; }
    public required string Nombre { get; set; }
    public List<Producto> Productos { get; set; } = new();
}
