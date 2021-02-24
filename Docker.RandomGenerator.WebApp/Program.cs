
namespace FocusRandonGenerator.WebApp
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;
    using System;

    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// CreateHostBuilder
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
           
            string envString =  envString = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRNOMENT");
           
            return 
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseEnvironment(envString);
                });
        }
    }
}
