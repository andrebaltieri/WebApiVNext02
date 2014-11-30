using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using WebApplication1.Data;

namespace WebApplication1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {            
            // Add MVC services to the service container
            services.AddMvc();

            // Add EF services to the service container
            services.AddEntityFramework()
                .AddInMemoryStore()
                .AddDbContext<AppDataContext>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseWelcomePage();
        }
    }
}
