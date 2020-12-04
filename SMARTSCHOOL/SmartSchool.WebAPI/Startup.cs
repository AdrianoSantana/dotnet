using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SmartSchool.WebAPI.Data;

namespace SmartSchool.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
         services.AddDbContext<DataContext>(options  => options.UseSqlite(Configuration.GetConnectionString("Default")));
         services.AddScoped<IRepository, Repository>();

         services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

         services.AddControllers()
            .AddNewtonsoftJson(
                opt =>  opt.SerializerSettings.ReferenceLoopHandling = 
                Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        
            services.AddSwaggerGen(
                opt => {
                    opt.SwaggerDoc(
                        "smartschoolapi",
                        new Microsoft.OpenApi.Models.OpenApiInfo(){
                            Title = "Smart School Api",
                            Version = "1.0"
                        }
                    );
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSwagger()
                .UseSwaggerUI(
                    opt => {
                        opt.SwaggerEndpoint("swagger/smartschoolapi/swagger.json", "smartschoolapi");
                        opt.RoutePrefix = "";
                    }
                );

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
