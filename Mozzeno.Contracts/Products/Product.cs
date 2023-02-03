using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozzeno.Contracts.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Reference { get; set; }
        public string RiskClassId { get; set; }
        public int Duration { get; set; }
        public decimal Rate { get; set; }
    }
}
