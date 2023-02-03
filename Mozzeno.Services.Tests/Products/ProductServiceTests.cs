using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozzeno.Contracts.Products;
using Mozzeno.Services.Products;
using Mozzeno.Services.Tests.Data;
using System;

namespace Mozzeno.Services.Tests.Products
{
    [TestClass]
    public class ProductServiceTests
    {



        [TestMethod]
        public void GetProductById()
        {
            var productService = new ProductService(new TestProductRepository(), new TestLoanPurposeRepository());

            var testid = new Guid("7f4b9077-2862-11eb-8b85-029d3961dacc");
            var product = productService.GetProductById(testid);

            Assert.IsNotNull(product);
            Assert.IsTrue(testid == product.Id);
        }

        [TestMethod]
        public void GetAllProducts()
        {
            var productService = new ProductService(new TestProductRepository(), new TestLoanPurposeRepository());

            int expectedCount = 42;

            var products = productService.GetAllProducts();
            Assert.IsTrue (products.Count == expectedCount);
        }

        [TestMethod]
        public void GetAllAvailableLoanPurposes() { 
            var productService = new ProductService(new TestProductRepository(), new TestLoanPurposeRepository());
            
            int expectedCount = 2;

            var loanPurposes = productService.GetAllAvailableLoanPurposes();
            Assert.IsTrue(loanPurposes.Count == expectedCount);
        }

        [TestMethod]
        public void GetAllProductsForDurationCriteria()
        {
            var criteria = new ProductCriteria()
            {
                Duration = 36
            };
            TestGetAllProductsForCriteria(criteria, 9);
        }

        [TestMethod]
        public void GetAllProductsForReferenceCriteria()
        {
            var criteria = new ProductCriteria()
            {
                Reference = "Renovate"
            };
            TestGetAllProductsForCriteria(criteria, 15);
        }

        [TestMethod]
        public void GetAllProductsForAllCriteria()
        {
            var criteria = new ProductCriteria()
            {
                Duration = 36,
                Reference = "Renovate"
            };
            TestGetAllProductsForCriteria(criteria, 3);
        }

        [TestMethod]
        public void GetAllProductsForNoCriteria()
        {
            TestGetAllProductsForCriteria(null, 42);
        }

        [TestMethod]
        public void GetAllProductsForEmptyCriteria()
        {
            var criteria = new ProductCriteria();
            TestGetAllProductsForCriteria(criteria, 42);
        }

        private void TestGetAllProductsForCriteria(ProductCriteria criteria, int expectedCount)
        {
            var productService = new ProductService(new TestProductRepository(), new TestLoanPurposeRepository());
            var productsByDuration = productService.GetAllProductsForCriteria(criteria);
            Assert.IsTrue(productsByDuration.Count == expectedCount);
        }
    }
}
