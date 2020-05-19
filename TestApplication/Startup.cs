using Convey;
using Convey.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestApplication.Exceptions;
using TestApplication.Exceptions.ExceptionMapper;

namespace TestApplication
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
            => Configuration = configuration;
        

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //mandatory convey packages
            services.AddConvey()
                .AddWebApi()
                //registers the custom mapper 
                .AddErrorHandler<ExceptionToResponseMapper>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //mandatory convey package
            app.UseConvey()
                //middleware usage
                .UseErrorHandler();
            
            app.UseRouting();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }

       
    }
}