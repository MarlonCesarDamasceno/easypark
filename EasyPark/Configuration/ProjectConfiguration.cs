using EasyPark.EasyPark.Core.Services;
using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Domain.Interface.Services;
using EasyPark.EasyPark.Persistence.Context;
using EasyPark.EasyPark.Persistence.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.Configuration
{
    public static class ProjectConfiguration
    {

        public static IServiceCollection ConfigurarDependencias(this IServiceCollection service, IConfiguration configuration)
        {
            //Configure base de dados
            service.AddDbContext<EasyParkContext>(options => options.UseSqlServer(RecuperaConnectionString(configuration)));

            //services
            service.AddScoped<IUsuariosService, UsuariosService>();

            //repository
            service.AddScoped<IUsuariosRepository, UsuariosRepository>();
            return service;
        }



        public static string RecuperaConnectionString(IConfiguration configuration)
        {
            return configuration.GetSection("ConfigDb:ConnectionString").Value;
        }
    }
}
