namespace FocusRandonGenerator.Api
{
    using Focus.RandomGenerator.Service;
    using FocusRandomGenerator.Interface;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            //var builder = new ConfigurationBuilder()
            //                    .SetBasePath(env.ContentRootPath)
            //                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            //                    .AddEnvironmentVariables();

            //Configuration = builder.Build();
        }

        /// <summary>
        /// Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IRandomNumberService, RandomNumberService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "RandomGenerator API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = new System.Uri("https://example.com/terms"),
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Rammanohar",
                        Email = "Ram@manohar.com",
                        Url = new System.Uri("https://www.Rammanohar.com"),
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new System.Uri("https://example.com/license"),
                    }
                });
            });
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
