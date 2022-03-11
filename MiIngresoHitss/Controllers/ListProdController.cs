#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiIngresoHitss.Context;
using MiIngresoHitss.Models;

namespace MiIngresoHitss.Controllers
{
    public class ListProdController : Controller
    {
        private readonly MVCcontext _context;

        public ListProdController(MVCcontext context)
        {
            _context = context;
        }

        // GET: Products1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Productos.ToListAsync());
        }
    }
}
