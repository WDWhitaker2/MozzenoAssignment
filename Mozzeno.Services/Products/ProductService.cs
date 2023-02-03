using Mozzeno.Contracts.Data;
using Mozzeno.Contracts.Products;
using Mozzeno.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mozzeno.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly ILoanPurposeRepository loanPurposeRepository;

        public ProductService(IProductRepository productRepository, ILoanPurposeRepository loanPurposeRepository)
        {
            this.productRepository = productRepository;
            this. loanPurposeRepository = loanPurposeRepository;
        }

        public Product GetProductById(Guid id)
        {
            return productRepository.GetById(id);
        }

        public List<string> GetAllAvailableLoanPurposes()
        {
            return loanPurposeRepository.GetAll().ToList();
        }

        public List<Product> GetAllProducts()
        {
            return productRepository.GetAllAsQueryable().ToList();
        }

        public List<Product> GetAllProductsForCriteria(ProductCriteria criteria)
        {

            var products = productRepository.GetAllAsQueryable();

            if (criteria != null)
            {
                if (criteria.Duration.HasValue)
                {
                    products = products.Where(a => a.Duration == criteria.Duration.Value);
                }

                if (!string.IsNullOrWhiteSpace(criteria.Reference))
                {
                    products = products.Where(a => a.Reference == criteria.Reference);
                }

            }

            return products.ToList();
        }
    }
}
