using Microsoft.AspNet.OData.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.OData;

namespace DennisOdataDemoes.Controllers
{
    public class UnboundController : ODataController
    {
        readonly ProductsContext _db = new ProductsContext();
        [HttpGet]
        [ODataRoute("AddProductAndSendEmailAsync")]
        public async Task<IHttpActionResult> AddProductAndSendEmailAsync(Product product)
        {
            try
            {
                _db.Products.Add(product);
                await _db.SaveChangesAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
            return Ok();
        }
    }
}