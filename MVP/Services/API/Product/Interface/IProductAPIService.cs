using MVP.Models;

namespace MVP.Services.API.Product.Interface
{
    public interface IProductAPIService
    {
        Task<List<ProductViewModel>> GetProduts();
    }
}
