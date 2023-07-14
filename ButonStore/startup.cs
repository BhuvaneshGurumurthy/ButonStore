using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ButonStore.DbEntityClasses;
using ButonStore.BusinessServices.Services;
using ButonStore.BusinessServices.Interface;
using ButonStore.DataAccessRepository.DateAccessInterfaceRepo;
using ButonStore.DataAccessRepository;

namespace ButonStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Register DbContext
            //services.AddDbContext<ButonStoreContext>(options =>
            //    options.UseNpgsql(Configuration.GetConnectionString("ButonStoreDbContext")));
            // Register services
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<PostgreSqlRepository<UserLoginDetail>>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Add appropriate error handling for production environment
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
