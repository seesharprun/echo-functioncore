using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs.Host;

namespace CoreSolution.FunctionProject
{
    public class Greet
    {
        public static IActionResult Run(HttpRequest request, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");
            
            return new OkObjectResult("Hello!");
        }
    }
}