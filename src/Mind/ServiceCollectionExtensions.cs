using Microsoft.Extensions.DependencyInjection;
using System;

namespace Mind
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMindCore(this IServiceCollection collection)
        {
            var a = 0;
            a = 2;
            a = 3;
            a = 4;


            return collection;
        }
    }
}
