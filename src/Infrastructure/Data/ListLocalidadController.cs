using System.Linq;
using Microsoft.AspNetCore.Mvc;


namespace Microsoft.eShopWeb.Infrastructure.Data;
[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
public class ListLocalidadController : ControllerBase
{
    private readonly CatalogDbContext _context;

    public ListLocalidadController(CatalogDbContext context)
    {
        _context = context;
    }

    [HttpGet("{localidad}")]
    public IActionResult GetProductosPorLocalidad(string localidad)
    {
        var productos = _context.CatalogItems.Where(p => p.Localidad == localidad).ToList();
        return Ok(productos);
    }
}

