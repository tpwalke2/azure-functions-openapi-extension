using System.Reflection;

using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.FunctionApp.InProc.Configurations
{
    public class MyOpenApiCustomUIOptions : DefaultOpenApiCustomUIOptions
    {
        public MyOpenApiCustomUIOptions(Assembly assembly)
            : base(assembly)
        {
        }

        public override Task<string> GetRequestInterceptorAsync()
        {
            return Task.FromResult("function(request) {console.log(request); return request;}");
        }

        public override Task<string> GetResponseInterceptorAsync()
        {
            return Task.FromResult("function(response) {console.log(response); return response;}");
        }

        //<!-- Uncomment if you want to use the embedded file. -->
        //public override string CustomStylesheetPath { get; set; } = "dist.my-custom.css";
        //public override string CustomJavaScriptPath { get; set; } = "dist.my-custom.js";
        //<!-- Uncomment if you want to use the embedded file. -->

        //<!-- Uncomment if you want to use the external URL. -->
        //public override string CustomStylesheetPath { get; set; } = "https://raw.githubusercontent.com/Azure/azure-functions-openapi-extension/main/samples/Microsoft.Azure.WebJobs.Extensions.OpenApi.FunctionApp.InProc/dist/my-custom.css";
        //public override string CustomJavaScriptPath { get; set; } = "https://raw.githubusercontent.com/Azure/azure-functions-openapi-extension/main/samples/Microsoft.Azure.WebJobs.Extensions.OpenApi.FunctionApp.InProc/dist/my-custom.js";
        //<!-- Uncomment if you want to use the external URL. -->
    }
}
