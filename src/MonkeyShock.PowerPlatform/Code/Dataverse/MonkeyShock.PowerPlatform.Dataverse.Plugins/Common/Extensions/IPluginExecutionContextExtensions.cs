using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Common.Values;
using System.Linq;
using System; 


namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Common.Extensions
{
    public static class IPluginExecutionContextExtensions
    {
        public static string ToFormattedString(this IPluginExecutionContext pluginExecutionContext)
        {
            // Validate parameter(s)
            if (pluginExecutionContext == null) return string.Empty;

            // Retrieve target
            var target = pluginExecutionContext.InputParameters != null && pluginExecutionContext.InputParameters.Contains("Target") ? pluginExecutionContext.InputParameters["Target"] as Entity : null;

            // Format and return the execution context
            return string.Join("; ", new[]
            {
                $"Message: '{pluginExecutionContext.MessageName}'",
                $"Primary-Entity: '{pluginExecutionContext.PrimaryEntityName}'",
                $"Secondary-Entity: '{pluginExecutionContext.SecondaryEntityName}'",
                $"Isolation-Mode: '{pluginExecutionContext.IsolationMode.CastToEnum<IsolationMode>()}'",
                $"Execution-Mode: '{pluginExecutionContext.Mode.CastToEnum<ProcessingMode>()}'",
                $"Event-Pipeline-Stage: '{pluginExecutionContext.Stage.CastToEnum<ProcessingStage>()}'",
                $"In-Transaction: '{(pluginExecutionContext.IsInTransaction ? "Yes" : "No")}'",
                $"Offline: '{(pluginExecutionContext.IsExecutingOffline ? "Yes" : "No")}'",
                $"Depth: '{pluginExecutionContext.Depth}'",
                $"Organization-Name: '{pluginExecutionContext.OrganizationName}'",
                $"Primary-Entity-ID: '{pluginExecutionContext.PrimaryEntityId}'",
                $"Initiating-User-ID: '{pluginExecutionContext.InitiatingUserId}'",
                $"User-ID: '{pluginExecutionContext.UserId}'",
                $"Target-Entity: {(target?.Attributes?.Count > 0 ? "["+string.Join(", ", target.Attributes.Select(i => i.Key).ToArray())+"]" : "'None'")}",
                $"Shared-Variables: {(pluginExecutionContext.SharedVariables?.Count > 0 ? "["+string.Join(", ", pluginExecutionContext.SharedVariables.Select(v => v.Key).ToArray())+"]" : "'None'")}",
                $"Input-Parameters: {(pluginExecutionContext.InputParameters?.Count > 0 ? "["+string.Join(", ", pluginExecutionContext.InputParameters.Select(i => i.Key).ToArray())+"]" : "'None'")}",
                $"Output-Parameters: {(pluginExecutionContext.OutputParameters?.Count > 0 ? "["+string.Join(", ", pluginExecutionContext.OutputParameters.Select(o => o.Key).ToArray())+"]" : "'None'")}",
                $"Pre-Entity-Images: {(pluginExecutionContext.PreEntityImages?.Count > 0 ? "["+string.Join(", ", pluginExecutionContext.PreEntityImages.Select(img => img.Key + ": [" + string.Join(", ", pluginExecutionContext.PreEntityImages[img.Key].Attributes.Select(a => a.Key).ToArray()) + "}").ToArray())+"]" : "'None'")}",
                $"Post-Entity-Images: {(pluginExecutionContext.PostEntityImages?.Count > 0 ? "["+string.Join(", ", pluginExecutionContext.PostEntityImages.Select(img => img.Key + ": [" + string.Join(", ", pluginExecutionContext.PostEntityImages[img.Key].Attributes.Select(a => a.Key).ToArray()) + "}").ToArray())+"]" : "'None'")}"
            });
        }
    }
}
