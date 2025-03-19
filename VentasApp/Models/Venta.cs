public class Venta
{
    public int CodigoVenta { get; set; }
    public DateTime Fecha { get; set; }
    public int CodigoProducto { get; set; }
    public required Producto Producto { get; set; }
}
