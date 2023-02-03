using System;
using System.Collections.Generic;
using System.Linq;
using Mozzeno.Contracts.Products;

namespace Mozzeno.Contracts.Data
{
    public interface IProductRepository
    {
        /// <summary>
        ///     Gets a product by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the product.</param>
        /// <returns>The product if found; null otherwise.</returns>
        Product GetById(Guid id);

        
        IQueryable<Product> GetAllAsQueryable();
    }
}
