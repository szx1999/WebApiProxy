using Jawasoft.ServiceProxy.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Jawasoft.ServiceProxy.Http.Server
{
    public static class HttpServerExtensions
    {
        public static IServiceCollection AddWebApiProxyServer(this IServiceCollection services, Action<WebApiProxyOptions> optionAction)
        {
            return services;
        }
    }
}
