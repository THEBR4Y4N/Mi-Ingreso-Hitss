using MiIngresoHitss.Models;

namespace MiIngresoHitss.Services
{
    public interface IProductoService
    {
        public IEnumerable<Product> GetAllProductos();
        public void DeleteAProduct(int id);

    }
}
