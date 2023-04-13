using ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Domain.DependencyResolver {
    public static class ServiceCollectionExtension {
        public static void AddDatabaseContext(this IServiceCollection services) {
            services.AddDbContext<MarkingDbContext>(options => options.UseInMemoryDatabase("memory-db"));

            // SEED DATABASE
            
        }
    }
}
