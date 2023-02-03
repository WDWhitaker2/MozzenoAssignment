using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozzeno.Contracts.Products
{
    public interface IProductService
    {
        List<string> GetAllAvailableLoanPurposes();
        List<Product> GetAllProducts();
        List<Product> GetAllProductsForCriteria(ProductCriteria criteria);
        Product GetProductById(Guid id);
    }
}
