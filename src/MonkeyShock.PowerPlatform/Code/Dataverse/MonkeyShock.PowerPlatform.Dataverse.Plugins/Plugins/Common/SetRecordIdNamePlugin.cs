using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Common.Values;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.Common.Values;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices;
using System.Collections.Generic;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Plugins.Common
{
    public class SetRecordIdNamePlugin : PluginBase
    {
        public override void Execute(IPluginExecutionContext pluginExecutionContext, IDomainServicesFactory servicesFactory, ITracingService tracingService)
        {
            if (pluginExecutionContext.InputParameters.ContainsKey(ParameterName.Target))
            {
                var target = (Entity)pluginExecutionContext.InputParameters[ParameterName.Target];

                if (target.Attributes.Contains(CommonAttributesName.EntityIdentifier))
                {
                    target.Attributes[CommonAttributesName.EntityIdentifier] = target.Id.ToString();
                }
                else 
                {
                    target.Attributes.Add(
                        new KeyValuePair<string, object>(CommonAttributesName.EntityIdentifier, target.Id.ToString())); 
                }

                if (target.Attributes.Contains(CommonAttributesName.EntityName))
                {
                    target.Attributes[CommonAttributesName.EntityName] = target.LogicalName; 
                }
                else
                {
                    target.Attributes.Add(
                        new KeyValuePair<string, object>(CommonAttributesName.EntityName, target.LogicalName));
                }
            }
        }

        public override bool IsContextValid(IPluginExecutionContext pluginExecutionContext)
        {
            if ( pluginExecutionContext.Mode == (int)ProcessingMode.Synchronous
                    && pluginExecutionContext.MessageName == MessageName.Create
                    && pluginExecutionContext.Stage == (int)ProcessingStage.PreOperation)
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
