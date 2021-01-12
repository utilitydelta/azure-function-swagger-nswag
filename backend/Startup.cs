using AzureFunctions.Extensions.Swashbuckle;
using FunctionAppSwagger;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

[assembly: WebJobsStartup(typeof(Startup))]
namespace FunctionAppSwagger
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            //Register the extension
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly());

        }
    }
}
