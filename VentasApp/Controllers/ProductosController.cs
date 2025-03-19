using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ProductosController : Controller
{
    private readonly VentasDbContext _context;

    public ProductosController(VentasDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int? categoriaId)
    {
        //Se obtienen las categorias con prod. vendido en 2019
        var categorias = await _context.Categoria
            .Where(c => c.Productos.Any(p => p.Ventas.Any(v => v.Fecha.Year == 2019)))
            .ToListAsync();

        //Filtra los prod. Vendidos en 2019
        var productos = _context.Producto
            .Where(p => p.Ventas.Any(v => v.Fecha.Year == 2019));

        if (categoriaId.HasValue)
        {
            productos = productos.Where(p => p.CodigoCategoria == categoriaId);
        }

        ViewBag.Categorias = categorias; //Enviamos las categorias a la vista
        return View(await productos.ToListAsync()); //Retornamos la lista de prod. Filtrados
    }
}
