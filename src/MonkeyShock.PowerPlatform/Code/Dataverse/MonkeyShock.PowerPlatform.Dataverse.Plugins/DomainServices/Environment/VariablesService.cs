using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess;
using System;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess.EnvironmentVariables; 

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices.Environment
{
    public class VariablesService : ServiceBase, IVariablesService
    {
        private IEnvVariablesRepository _variablesRepository; 
        public VariablesService(IRepositoriesFactory repositoryFactory, ITracingService tracing) : base(repositoryFactory, tracing)
        {
            _variablesRepository = repositoryFactory.Get<IEnvVariablesRepository>(); 
        }

        public string GetSampleUrl()
        {
            return _variablesRepository.GetDefaultValue("pg_samplesiteurl"); 
        }
    }
}
