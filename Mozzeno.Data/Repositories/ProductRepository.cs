using System;
using System.Collections.Generic;
using System.Linq;
using Mozzeno.Contracts.Data;
using Mozzeno.Contracts.Products;

namespace Mozzeno.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {

        /// <summary>
        ///     Gets a product by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the product.</param>
        /// <returns>The product if found; null otherwise.</returns>
        public Product GetById(Guid id)
        {
            return Products.FirstOrDefault(a=>a.Id == id);
        }

        /// <summary>
        ///     Gets a queryable list of products.
        /// </summary>
        /// <returns>A list of products as a queryable list.</returns>
        public IQueryable<Product> GetAllAsQueryable()
        {
            return Products.AsQueryable();
        }

        private static IEnumerable<Product> Products => new List<Product>
        {
            new Product {Id = new Guid("7f4b8b69-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "A", Duration = 24, Rate = 1.99154400m},
            new Product {Id = new Guid("7f4b8e22-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "A", Duration = 30, Rate = 2.09496000m},
            new Product {Id = new Guid("7f4b9077-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "A", Duration = 36, Rate = 2.20074000m},
            new Product {Id = new Guid("7f4b9210-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "A", Duration = 42, Rate = 2.30462400m},
            new Product {Id = new Guid("7f4b9308-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "A", Duration = 48, Rate = 2.40828000m},
            new Product {Id = new Guid("7f4b9599-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "B", Duration = 24, Rate = 2.47243200m},
            new Product {Id = new Guid("7f4b9749-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "B", Duration = 30, Rate = 2.58529200m},
            new Product {Id = new Guid("7f4b9934-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "B", Duration = 36, Rate = 2.69604000m},
            new Product {Id = new Guid("7f4b9ada-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "B", Duration = 42, Rate = 2.80730400m},
            new Product {Id = new Guid("7f4b9bdd-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "B", Duration = 48, Rate = 2.91842400m},
            new Product {Id = new Guid("7f4b9e63-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "C", Duration = 24, Rate = 3.35300400m},
            new Product {Id = new Guid("7f4ba04b-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "C", Duration = 30, Rate = 3.48487200m},
            new Product {Id = new Guid("7f4ba1ea-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "C", Duration = 36, Rate = 3.61264800m},
            new Product {Id = new Guid("7f4ba3b4-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "C", Duration = 42, Rate = 3.73934400m},
            new Product {Id = new Guid("7f4ba4e2-2862-11eb-8b85-029d3961dacc"), Reference = "Renovate", RiskClassId = "C", Duration = 48, Rate = 3.86595600m},
            new Product {Id = new Guid("51223d6a-e9d8-4ba4-b3fa-7381be5b7143"), Reference = "Vehicle", RiskClassId = "A", Duration = 12, Rate = 3.01610193m},
            new Product {Id = new Guid("e6e23591-3e8f-4c22-ad69-6dec3fdc21d9"), Reference = "Vehicle", RiskClassId = "A", Duration = 24, Rate = 3.42953553m},
            new Product {Id = new Guid("7f37151b-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "A", Duration = 24, Rate = 1.99243200m},
            new Product {Id = new Guid("7f3716ea-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "A", Duration = 30, Rate = 2.09626800m},
            new Product {Id = new Guid("7f371882-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "A", Duration = 36, Rate = 2.19907200m},
            new Product {Id = new Guid("a5af3e85-d48c-4519-a4d3-a87fa516b38c"), Reference = "Vehicle", RiskClassId = "A", Duration = 36, Rate = 3.40722202m},
            new Product {Id = new Guid("7f371a0c-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "A", Duration = 42, Rate = 2.30365200m},
            new Product {Id = new Guid("7f371b37-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "A", Duration = 48, Rate = 2.50788000m},
            new Product {Id = new Guid("1a09d53b-9b19-437e-ab9a-7ddc6432611f"), Reference = "Vehicle", RiskClassId = "A", Duration = 48, Rate = 3.62917570m},
            new Product {Id = new Guid("a8aa1192-6525-438c-aa62-2cfb40ba1c75"), Reference = "Vehicle", RiskClassId = "B", Duration = 12, Rate = 3.51004061m},
            new Product {Id = new Guid("7f3726dc-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "B", Duration = 24, Rate = 2.47114800m},
            new Product {Id = new Guid("a25de5e1-e02a-4be2-8f0c-876c6cd50038"), Reference = "Vehicle", RiskClassId = "B", Duration = 24, Rate = 3.92585732m},
            new Product {Id = new Guid("7f372919-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "B", Duration = 30, Rate = 2.58452400m},
            new Product {Id = new Guid("da0a74ed-f747-4bd0-a026-43d8d5ba84eb"), Reference = "Vehicle", RiskClassId = "B", Duration = 36, Rate = 3.90264419m},
            new Product {Id = new Guid("7f372a9a-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "B", Duration = 36, Rate = 2.69743200m},
            new Product {Id = new Guid("7f372c31-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "B", Duration = 42, Rate = 2.80770000m},
            new Product {Id = new Guid("7f372d3d-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "B", Duration = 48, Rate = 3.02060400m},
            new Product {Id = new Guid("d8392979-78a5-4759-9554-853c7bd62e6a"), Reference = "Vehicle", RiskClassId = "B", Duration = 48, Rate = 4.12258336m},
            new Product {Id = new Guid("64ed761f-dbe3-4e05-98fd-95ba4d6bae6b"), Reference = "Vehicle", RiskClassId = "C", Duration = 12, Rate = 4.47247214m},
            new Product {Id = new Guid("1e3f1044-2b58-4d12-b713-b35ec38c5acc"), Reference = "Vehicle", RiskClassId = "C", Duration = 24, Rate = 4.89289476m},
            new Product {Id = new Guid("7f372fba-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "C", Duration = 24, Rate = 3.35420400m},
            new Product {Id = new Guid("7f3731c2-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "C", Duration = 30, Rate = 3.48580800m},
            new Product {Id = new Guid("1d142fc4-88b0-48c7-881c-01f59ecc6a19"), Reference = "Vehicle", RiskClassId = "C", Duration = 36, Rate = 4.86790061m},
            new Product {Id = new Guid("7f37335a-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "C", Duration = 36, Rate = 3.61332000m},
            new Product {Id = new Guid("7f3734eb-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "C", Duration = 42, Rate = 3.74049600m},
            new Product {Id = new Guid("7f37360a-2862-11eb-8b85-029d3961dacc"), Reference = "Vehicle", RiskClassId = "C", Duration = 48, Rate = 3.97068000m},
            new Product {Id = new Guid("1a7e2f21-d284-4ff3-b232-c51b6b4511ed"), Reference = "Vehicle", RiskClassId = "C", Duration = 48, Rate = 5.08390135m},
        };

    }
}
