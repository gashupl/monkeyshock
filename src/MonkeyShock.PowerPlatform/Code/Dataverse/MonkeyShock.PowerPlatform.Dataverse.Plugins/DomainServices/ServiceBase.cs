using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess;


namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices
{
    public abstract class ServiceBase : IService
    {
        protected readonly IRepositoriesFactory repositoryFactory; 
        protected readonly ITracingService tracing; 

        public ServiceBase(IRepositoriesFactory repositoryFactory, ITracingService tracing)
        {
            this.repositoryFactory = repositoryFactory;
            this.tracing = tracing; 
        }
    }
}
