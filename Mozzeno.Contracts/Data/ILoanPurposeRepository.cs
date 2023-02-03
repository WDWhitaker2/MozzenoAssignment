using System.Collections.Generic;

namespace Mozzeno.Contracts.Data
{
    public interface ILoanPurposeRepository
    {
        /// <summary>
        ///     Retrieves the list of all available loan purposes.
        /// </summary>
        /// <returns>A list of all available loan purpose references.</returns>
        ICollection<string> GetAll();
    }
}
