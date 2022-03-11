using Microsoft.AspNetCore.Mvc;
using MiIngresoHitss.Context;
using MiIngresoHitss.Models;
using MiIngresoHitss.Services;

namespace MiIngresoHitss.Controllers
{
    public class ProductController : Controller
    {
        IProductoService ips;

        public ProductController(IProductoService _ips)
        {
            ips = _ips;
        }

        public IActionResult Index()
        {            
            return View(ips.GetAllProductos());
        }

        public IActionResult Delete(int ID)
        {
            ips.DeleteAProduct(ID);
            return RedirectToAction("Index");
            
        }
    }
}
