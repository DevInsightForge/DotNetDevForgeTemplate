﻿using DevInsightForge.Application.Common.Interfaces.DataAccess;
using DevInsightForge.Application.Common.Interfaces.DataAccess.Repositories;
using DevInsightForge.Infrastructure.DataAccess;
using DevInsightForge.Infrastructure.DataAccess.Repositories;
using DevInsightForge.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevInsightForge.Infrastructure;

public static class InfrastructureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Configure DbContext provider
        services.AddDbContext<DatabaseContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("DatabaseServer")));

        // Register data-access services
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
