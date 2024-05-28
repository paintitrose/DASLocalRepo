using Microsoft.AspNetCore.Mvc;
using T2_VEGA_CHRIS.Datos;
using T2_VEGA_CHRIS.Models;

namespace T2_VEGA_CHRIS.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View(lista);
        }
    }
}
