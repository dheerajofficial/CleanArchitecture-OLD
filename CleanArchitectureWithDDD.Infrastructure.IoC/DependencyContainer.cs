using CleanArchitectureWithDDD.Application.Interfaces;
using CleanArchitectureWithDDD.Application.Services;
using CleanArchitectureWithDDD.Domain.Interfaces;
using CleanArchitectureWithDDD.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithDDD.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer 
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
