using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using System.Web.OData.Routing.Conventions;

namespace DynamicOData.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var convention = ODataRoutingConventions.CreateDefault();

            var mb = new ODataConventionModelBuilder();

            var connectionString = ConfigurationManager.ConnectionStrings["FlintfoxAzaraContext_SQL"].ConnectionString;

            //var schemaReader = new SchemaReader("rmx", connectionString);
            //var modelBuilder = new EdmModelBuilder(schemaReader);
            //var model = modelBuilder.GetEdmModel();

            ////add functions
            //modelBuilder.AddFunction(model, "GetAutoNumber", new EdmModelBuilder.FunctionParameter("Id", EdmPrimitiveTypeKind.Int32, false));
            //modelBuilder.AddFunction(model, "GetOptions", new EdmModelBuilder.FunctionParameter("groupId", EdmPrimitiveTypeKind.Int32, false));
            //modelBuilder.AddFunction(model, "GetTradeAgreementComponentPricing", new EdmModelBuilder.FunctionParameter("rmx_TradeAgreementId", EdmPrimitiveTypeKind.Int32, false));
            //modelBuilder.AddFunction(model, "GetTradeAgreementStatusSummary");

            //dummy for shared controller selector
            AssemblyService assemblyService = null;

            //odata routes
            //config.MapODataServiceRoute(
            //    routeName: "ODataRoute",
            //    routePrefix: "odata/rmx",
            //    model: model,
            //    pathHandler: new ODataPathHandler(), routingConventions: convention
            //    );
        }
    }
}
