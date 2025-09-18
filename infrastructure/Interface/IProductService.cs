

using infrastructure.Models;

namespace infrastructure.Interface;

public interface IProductService
{
    // lägga till en product i listan 
    //visa en product i listan 
    ProductResult AddProductToList(Product product);

    ProductResult<IEnumerable<Product>> GetAllProducts();
}
