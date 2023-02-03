using System.Collections.Generic;
using System.Linq;
using Mozzeno.Contracts.Data;

namespace Mozzeno.Data.Repositories
{
    public class LoanPurposeRepository : ILoanPurposeRepository
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
