using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.Common;
using System;
using System.Linq; 

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess
{
    public class RepositoriesFactory : FactoryBase, IRepositoriesFactory
    {
        private readonly IOrganizationServiceFactory serviceFactory; 


        public RepositoriesFactory(IOrganizationServiceFactory serviceFactory)
        {
            this.serviceFactory = serviceFactory;
        }

        public T Get<T>(Guid? userId = null) where T : IRepository
        {
            var interfaceType = typeof(T); 
            var types = registrations.Where(r => r.Key == interfaceType).ToList();
            if (types.Count != 0)
            {
                return (T)Activator.CreateInstance(types[0].Value, serviceFactory, userId);
            }

            throw new InvalidOperationException($"Cannot find registration of { nameof(interfaceType)} ");
        }
    }
}
