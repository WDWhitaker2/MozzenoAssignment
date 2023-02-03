namespace Mozzeno.Contracts.Products
{
    /// <summary>
    ///     Product criteria, used to define the criteria for which a list of products should be retrieved.
    /// </summary>
    public class ProductCriteria
    {
        public int? Duration { get; set; }
        public string Reference { get; set; }

    }
}
