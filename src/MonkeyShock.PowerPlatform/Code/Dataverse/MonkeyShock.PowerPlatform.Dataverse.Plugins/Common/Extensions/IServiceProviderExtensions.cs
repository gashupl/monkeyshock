using System;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Common.Extensions
{
    public static class IServiceProviderExtensions
    {
        public static T GetService<T>(this IServiceProvider serviceProvider) where T : class
        {
            // Validate parameter(s)
            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            if (!typeof(T).IsInterface) 
            {
                throw new ArgumentException("Invalid type. Argument needs to be interface", nameof(serviceProvider));
            } 

            return serviceProvider.GetService(typeof(T)) as T;
        }
    }
}
