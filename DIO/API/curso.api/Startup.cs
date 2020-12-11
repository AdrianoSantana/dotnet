using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso.api.Business.Repository;
using curso.api.Configurations;
using curso.api.Infraestruture;
using curso.api.Infraestruture.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
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
             //var optionsBuilder = new DbContextOptionsBuilder<CursoDBContext>();
            //optionsBuilder.UseSqlite();
            //CursoDBContext context = new CursoDBContext(optionsBuilder.Options);
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
            var secret = Encoding.ASCII.GetBytes(Configuration.GetSection("JwtConfigurations:Secret").Value);
            services.AddAuthentication(x => {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x => {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(secret),
                        ValidateIssuer = false,
                        ValidateAudience = false                      
                    }; 
                }  
                );

            services.AddControllers()
                .ConfigureApiBehaviorOptions(
                    options => options.SuppressModelStateInvalidFilter = true
                );

            services.AddDbContext<CursoDBContext>(options => {
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IAuthenticationService, JwtService>();
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
            app.UseAuthentication();
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
