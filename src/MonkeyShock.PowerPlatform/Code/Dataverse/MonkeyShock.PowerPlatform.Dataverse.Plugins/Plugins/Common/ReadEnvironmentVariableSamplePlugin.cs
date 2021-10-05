using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Plugins.Common
{
    public class ReadEnvironmentVariableSamplePlugin : PluginBase
    {
        public override void Execute(IPluginExecutionContext pluginExecutionContext, IDomainServicesFactory servicesFactory, ITracingService tracingService)
        {
            var service = servicesFactory.Get<IVariablesService>();
            var value = service.GetSampleUrl();
            tracingService.Trace(value); 
        }

        public override bool IsContextValid(IPluginExecutionContext pluginExecutionContext)
        {
            return true; 
        }
    }
}
