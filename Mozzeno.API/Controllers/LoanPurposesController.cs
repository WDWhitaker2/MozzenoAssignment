using Mozzeno.Contracts.Products;
using System.Threading.Tasks;
using System.Web.Http;

namespace Mozzeno.API.Controllers
{
    [RoutePrefix("api/loan-purposes")]
    public class LoanPurposesController : ApiController
    {

        private readonly IProductService productServiceIoc;

        public LoanPurposesController(IProductService productService)
        {
            this.productServiceIoc = productService;
        }

        /// <summary>
        ///     Gets a list of all loan purposes
        /// </summary>
        [HttpGet]
        [Route("get-all-loan-purposes")]
        public async Task<IHttpActionResult> GetAllLoanPurposes()
        {
            return Json(this.productServiceIoc.GetAllAvailableLoanPurposes());
        }
    }
}
