using Microsoft.Extensions.DependencyInjection;
using System;

namespace Mind
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMindCore(this IServiceCollection collection)
        {
            int count = 0 + 1 + 2;
            int x = 5;
            int y = 8;

            return collection;
        }
    }
}
