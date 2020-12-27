using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldService.Models;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace HelloWorldService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Addition a = new Addition(20, 11);
            string jsonstring = a.ToString();
            Console.WriteLine(jsonstring);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}