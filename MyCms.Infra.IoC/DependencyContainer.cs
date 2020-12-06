using Microsoft.Extensions.DependencyInjection;
using MyCms.Domain.Interfaces;
using MyCms.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCms.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            //Infra Data Layer
            service.AddTransient<IPageRepository, PageRepository>();
            service.AddTransient<IPageGroupRepository, PageGroupRepository>();
        }
    }
}
