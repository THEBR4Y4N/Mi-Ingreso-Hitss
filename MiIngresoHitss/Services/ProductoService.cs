using MiIngresoHitss.Context;
using MiIngresoHitss.Models;

namespace MiIngresoHitss.Services
{
    public class ProductoService : IProductoService
    {
        MVCcontext db;

        public ProductoService(MVCcontext _db)
        {
            db = _db;
        }
        public void DeleteAProduct(int id)
        {
            Product productos = db.Productos.FirstOrDefault(p => p.ID == ID);
            if (productos != null)
            {
                db.Remove(productos);
                db.SaveChanges();
            }            
        }

        public IEnumerable<Product> GetAllProductos()
        {            
            return(db.Productos.Select(p => p).ToList());
        }
    }
}
