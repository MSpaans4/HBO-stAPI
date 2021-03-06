﻿using Microsoft.Extensions.DependencyInjection;

namespace PoohAPI.Application
{
    public static class DependencyInit
    {
        public static void Init(IServiceCollection services)
        {
            Logic.Common.Init.DIComponentsConfig.RegisterComponents(services);
            Logic.Users.Init.DIComponentsConfig.RegisterComponents(services);
            Logic.Companies.Init.DIComponentsConfig.RegisterComponents(services);
            Logic.Reviews.Init.DIComponentsConfig.RegisterComponents(services);
            Logic.MapAPI.Init.DIComponentsConfig.RegisterComponents(services);
            Logic.Vacancies.Init.DIComponentsConfig.RegisterComponents(services);
            Logic.Options.Init.DIComponentsConfig.RegisterComponents(services);
        }
    }
}
