using Microsoft.Xrm.Sdk; 
using MonkeyShock.PowerPlatform.Dataverse.Context;
using MonkeyShock.PowerPlatform.Dataverse.Common.Values;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices.Demo;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Plugins.TestApi
{
    //Sample URL: https://piog.api.crm4.dynamics.com/api/data/v9.2/pg_testapi(pg_name='abc')
    public class TestApiPlugin : PluginBase
    {
        public override void Execute(IPluginExecutionContext pluginExecutionContext, IDomainServicesFactory servicesFactory)
        {
            if (pluginExecutionContext.InputParameters.ContainsKey(nameof(pg_testapiRequest.pg_name)))
            {
                var name = (string)pluginExecutionContext.InputParameters[nameof(pg_testapiRequest.pg_name)];
                var service = servicesFactory.Get<IDemoService>();
                pluginExecutionContext.OutputParameters[nameof(pg_testapiResponse.pg_testaccountname)] 
                    = service.DoSomething(name, pluginExecutionContext.UserId);
            }
        }

        public override bool IsContextValid(IPluginExecutionContext pluginExecutionContext)
        {
            if (pluginExecutionContext.MessageName == (new pg_testapiRequest()).RequestName
                          && pluginExecutionContext.Mode == (int)ProcessingMode.Synchronous)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
