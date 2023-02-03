using Mozzeno.API.Calculators;
using Mozzeno.Contracts.Products;
using Mozzeno.Services.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Mozzeno.API.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private readonly IProductService productServiceIoc;

        public ProductsController(IProductService productService)
        {
            this.productServiceIoc = productService;
        }

        /// <summary>
        ///     Gets a list of all products.
        /// </summary>
        [HttpGet]
        [Route("get-all-products")]
        public async Task<IHttpActionResult> GetAllProducts()
        {
            var products = productServiceIoc.GetAllProducts();
            return Ok(products);
        }

        /// <summary>
        ///     Gets a list of products for a given duration.
        /// </summary>
        [HttpGet]
        [Route("get-all-products-for-duration")]
        public async Task<IHttpActionResult> GetAllProductsForDuration(int duration)
        {
            var products = productServiceIoc.GetAllProductsForCriteria(new ProductCriteria { Duration = duration });
            return Ok(products);
        }

        /// <summary>
        ///     Gets a list of products for a given purpose.
        /// </summary>
        [HttpGet]
        [Route("get-all-products-for-purpose")]
        public async Task<IHttpActionResult> GetAllProductsForPurpose(string purpose)
        {
            var products = productServiceIoc.GetAllProductsForCriteria(new ProductCriteria { Reference = purpose });
            return Ok(products);
        }

        /// <summary>
        ///     Gets a list of products for a given purpose.
        /// </summary>
        [HttpGet]
        [Route("get-installment-amount-for-product-id")]
        public async Task<IHttpActionResult> GetInstallmentAmountForProductId(Guid id, decimal loanAmount)
        {
            var product = productServiceIoc.GetProductById(id);

            var installmentAmount = InstalmentAmountCalculator.Calculate(loanAmount, product.Rate, product.Duration);
            return Ok(installmentAmount);

        }

        [HttpGet]
        [Route("throw-some-error")]
        public async Task<IHttpActionResult> ThrowSomeError()
        {
            throw new Exception("An Exception was thrown");
            return NotFound();

        }
    }
}
