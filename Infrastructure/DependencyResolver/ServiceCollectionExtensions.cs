using Domain.DependencyResolver;
using Microsoft.Extensions.DependencyInjection;
using RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DependencyResolver {
    public static class ServiceCollectionExtensions {
       
        public static void AddInfrastructure (this IServiceCollection services) {
            services.AddDatabaseContext();

            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();

        }

    }
}
