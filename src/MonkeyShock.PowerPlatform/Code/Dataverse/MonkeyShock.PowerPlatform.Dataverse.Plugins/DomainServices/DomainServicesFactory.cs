using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.Common;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices
{
    public class DomainServicesFactory : FactoryBase, IDomainServicesFactory
    {
        private readonly IRepositoriesFactory _repositoriesFactory;
        private readonly ITracingService _tracingService; 

        public DomainServicesFactory(IRepositoriesFactory repositoriesFactory, ITracingService tracingService)
        {
            _repositoriesFactory = repositoriesFactory;
            _tracingService = tracingService; 
        }
        public T Get<T>() where T : IService
        {
            var interfaceType = typeof(T); 
            var types = registrations.Where(r => r.Key == interfaceType).ToList();
            if(types.Count != 0)
            {
                return (T)Activator.CreateInstance(types[0].Value, _repositoriesFactory, _tracingService);
            }

            throw new InvalidOperationException($"Cannot find registration of { nameof(interfaceType)} "); 
        }
    }
}
