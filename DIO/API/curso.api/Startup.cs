using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace curso.api
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
            services.AddSwaggerGen(
                opt => {
                    opt.SwaggerDoc(
                        "apiusuarios", new Microsoft.OpenApi.Models.OpenApiInfo(){
                            Title = "Usuários API",
                            Version = "1.0"
                        }
                    );
                }
            );
            services.AddControllers()
                .ConfigureApiBehaviorOptions(
                    options => options.SuppressModelStateInvalidFilter = true
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger()
                .UseSwaggerUI(
                    opt => {
                        opt.SwaggerEndpoint(
                        "swagger/apiusuarios/swagger.json", "apiusuarios"
                        );
                        opt.RoutePrefix = string.Empty;
                    }
                );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
