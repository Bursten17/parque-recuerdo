using System;
using System.Text;
using API.Application.Abstract;
using API.Application.Constants;
using API.Infrastructure.Services;
using API.Middleware;
using API.Persistent;
using AutoMapper;
using examen_api.Application.Abstract;
using examen_api.Infrastructure.Repository;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using morcom_api.Application.Abstract;
using morcom_api.Infrastructure.Repository;
using morcom_api.Infrastructure.Security;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //convencion de nombres si estoy en entorno de prudccion se ejecuta el metodo ConfigureProductionServices
        //sino el entorno de ConfigureDevelopmentServices
        public void ConfigureProductionServices(IServiceCollection services)
        {
            services.AddTransient<DataContext>(_ => new DataContext(Configuration.GetConnectionString("postgres")));
            ConfigureServices(services);
        }

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            services.AddTransient<DataContext>(_ => new DataContext(Configuration.GetConnectionString("postgres")));
            ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders(GlobalConstants.WWW_Authenticate)
                    .AllowAnyOrigin();
                });
            });

            services.AddControllers(
            opt =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                opt.Filters.Add(new AuthorizeFilter(policy));
            }
            ).AddNewtonsoftJson().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<Startup>());

             // Adding Automapper service
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["TokenKey"]));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
                opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = key,
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                }
            );

            services.AddAuthorization(opt =>
            {
                // opt.AddPolicy("TokenPolicy", policy =>
                // {
                //     policy.AddAuthenticationSchemes("Bearer");
                //     policy.RequireAuthenticatedUser();
                // });
                // opt.AddPolicy("GetRoleByIdPolicy", policy => policy.Requirements.Add(new RequirementsGeneral(3)));
            });

            services.AddTransient<IIdentityService, IdentityService>();
            services.AddTransient<IJwtGenerator, JwtGeneretor>();
            services.AddTransient<IRole, Role>();
            services.AddTransient<IEmpleado, Empleado>();
            services.AddTransient<IUserAccessor, UserAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseRouting();
            app.UseCors("CorsPolicy");

            // For use Authentication add this service
            app.UseAuthentication();

            // For use Authorization
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
