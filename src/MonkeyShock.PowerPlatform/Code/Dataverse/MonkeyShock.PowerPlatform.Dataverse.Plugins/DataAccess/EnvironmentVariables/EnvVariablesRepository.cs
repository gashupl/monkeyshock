using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Context;
using System;
using System.Linq;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess.EnvironmentVariables
{
    public class EnvVariablesRepository : RepositoryBase, IEnvVariablesRepository
    {
        public EnvVariablesRepository(IOrganizationServiceFactory servicesFactory, Guid? userId) : base(servicesFactory, userId)
        {
        }

        public string GetDefaultValue(string name)
        {

            using (var context = CreateContext<DataverseServiceContext>())
            {
                var query = context.EnvironmentVariableDefinitionSet
                    .Where(a => a.SchemaName == name)
                    .Select(a => a.DefaultValue); 
                   
                return query.FirstOrDefault();
            }
        }
    }
}
