using Mozzeno.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozzeno.Services.Tests.Data
{
    internal class TestLoanPurposeRepository : ILoanPurposeRepository
    {
        private static IEnumerable<string> LoanPurposes => new List<string>
        {
            "Renovate", "Vehicle"
        };

        /// <summary>
        ///     Retrieves the list of all available loan purposes.
        /// </summary>
        /// <returns>A list of all available loan purpose references.</returns>
        public ICollection<string> GetAll()
        {
            return LoanPurposes.ToList();
        }
    }
}
