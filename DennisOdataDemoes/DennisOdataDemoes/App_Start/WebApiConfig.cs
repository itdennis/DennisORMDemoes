using System.Web.Http;
using DennisOdataDemoes.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;

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
            builder.EntitySet<Employee>("Employees").EntityType.Ignore(e => e.Title);
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
