using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.WebEncoders;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Site.Models;


namespace Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            #region connectionSting

            /*
            string connectionSting = Configuration.GetConnectionString("TitleOfPageContext");

            services.AddDbContext<TitleOfPageDbContext>(options => options.UseSqlServer(connectionSting));
            */

            services.AddDbContext<TitleOfPageDbContext>(options =>
               options.UseSqlServer(Configuration["ConnectionStrings:TitleOfPageContext"]));

            #endregion

            services.Configure<WebEncoderOptions>(options =>
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All));

            //services.AddTransient<ITitleOfPageRepository, FakeTitleOfPageRepository>();
            services.AddTransient<ITitleOfPageRepository, EFTitleOfPageRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();


            app.UseRouting();

            app.UseEndpoints(endpoints => endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Site}/{action=Shef}/{id:int:min(1)=1}"));

            SeedData.EnsurePopulated(app);
        }
    }
}
