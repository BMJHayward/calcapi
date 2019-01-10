using System.Net.Http.Headers;
using System.Web.Http;

namespace calcApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // tracing for test/debug purposes
            // config.EnableSystemDiagnosticsTracing();
            // SystemDiagnosticsTraceWriter traceWriter = config.EnableSystemDiagnosticsTracing();
            // traceWriter.IsVerbose = true;
            // traceWriter.MinimumLevel = TraceLevel.Debug;

            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{leftOp}/{rightOp}",
                defaults: new { 
                    leftOp = RouteParameter.Optional,
                    rightOp = RouteParameter.Optional
                }
            );
            /* return JSON by default when given 'text/html' request but still
               allow xml when requested by client */
            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
