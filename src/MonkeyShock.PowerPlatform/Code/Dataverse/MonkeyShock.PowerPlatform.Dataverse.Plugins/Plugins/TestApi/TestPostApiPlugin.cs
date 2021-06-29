using System;
using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.Common.Extensions;
using MonkeyShock.PowerPlatform.Dataverse.Context;
using MonkeyShock.PowerPlatform.Dataverse.Common.Values;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices.Demo;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Plugins.TestApi
{
    //POST: https://monkeyshock03.api.crm4.dynamics.com/api/data/v9.2/pg_testpostapi
    //body: 
    //{
    //    "pg_postname": "PIO"
    //}
    public class TestPostApiPlugin : PluginBase
    {

        public override void Execute(IPluginExecutionContext pluginExecutionContext, IDomainServicesFactory servicesFactory)
        {
            if (pluginExecutionContext.InputParameters.ContainsKey(nameof(pg_testpostapiRequest.pg_postname)))
            {
                var name = (string)pluginExecutionContext.InputParameters[nameof(pg_testapiRequest.pg_name)];
                var service = servicesFactory.Get<IDemoService>();
                pluginExecutionContext.OutputParameters[nameof(pg_testpostapiResponse.pg_testaccountpostname)] 
                    = service.DoSomething(name, pluginExecutionContext.UserId);
            }
        }

        public override bool IsContextValid(IPluginExecutionContext pluginExecutionContext)
        {
            if (pluginExecutionContext.MessageName == (new pg_testpostapiRequest()).RequestName
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
