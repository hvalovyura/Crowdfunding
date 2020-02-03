using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crowdfunding.Data;
using Crowdfunding.Data.Interfaces;
using Crowdfunding.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Crowdfunding
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IWebHostEnvironment HostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(HostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllProjects, ProjectRepository>();
            services.AddTransient<IProjectsCategory, CategoryRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent Content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(Content);
            }
        }
    }
}
