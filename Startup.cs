﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Fox.Microservices.Claims.Models.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using WebAPITools;
using WebAPITools.ErrorHandling;
using WebAPITools.Models.Configuration;

namespace Fox.Microservices.Claims
{
    public class Startup : BaseStartup
    {
        public Startup(IConfiguration configuration, ILogger<Startup> logger, ILoggerFactory loggerFactory) : base(configuration, logger, loggerFactory)
        {
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            string ConnectionString = Configuration.GetConnectionString("ConnectionString");
            DbConnectionStringBuilder ConnBuilder = new DbConnectionStringBuilder();
            ConnBuilder.ConnectionString = ConnectionString;
            _logger.LogInformation("Using database: {0}\\{1}", ConnBuilder["Data Source"], ConnBuilder["Initial Catalog"]);
            
            services.AddDbContext<ClaimsContext>(options =>
                options.UseLazyLoadingProxies()
                .EnableDetailedErrors()
                .UseSqlServer(ConnectionString));
                
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "FOX Microservices - Claims API", Version = "v1" });
                var filePath = Path.Combine(System.AppContext.BaseDirectory, "Fox.Microservices.Claims.xml");
                c.IncludeXmlComments(filePath);
            });
        }
    }
}
