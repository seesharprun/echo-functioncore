using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Linq;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;

namespace CoreSolution.FunctionProject
{
    public class Echo
    {
        public static IActionResult Run(HttpRequest request, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            if (request.Query.TryGetValue("name", out StringValues value)) {
                return new OkObjectResult($"Hello, {value.First()}");
            }
        }
    }
}
