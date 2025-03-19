public class Producto
{
    public int CodigoProducto { get; set; }
    public required string Nombre { get; set; }
    public int CodigoCategoria { get; set; }
    public required Categoria Categoria { get; set; }
    public List<Venta> Ventas { get; set; } = new();
}
