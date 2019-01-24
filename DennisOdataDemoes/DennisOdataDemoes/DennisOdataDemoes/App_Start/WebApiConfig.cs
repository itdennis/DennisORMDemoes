using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace DennisOdataDemoes
{
    public static class WebApiConfig
    {
        /// <summary>
        /// Creates an Entity Data Model(EDM).
        /// Adds a route.
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
