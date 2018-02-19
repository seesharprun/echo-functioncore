using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs.Host;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CoreSolution.FunctionProject
{
    public class Echo
    {
        public static async Task<IActionResult> Run(HttpRequest request, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string requestBody = String.Empty;
            using (StreamReader reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
            {
                requestBody = await reader.ReadToEndAsync();
            }

            return new OkObjectResult(requestBody);
        }
    }
}