using Microsoft.EntityFrameworkCore;
using MiIngresoHitss.Models;

namespace MiIngresoHitss.Context
{
    public class MVCcontext:DbContext
    {
        public MVCcontext(DbContextOptions options): base(options) 
        {

        }
        public DbSet<Product> Productos { get; set; }
    }
}
