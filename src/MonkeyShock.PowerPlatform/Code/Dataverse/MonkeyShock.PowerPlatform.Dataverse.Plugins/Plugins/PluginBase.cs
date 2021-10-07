using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Common.Values;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.Common.Extensions; 
using System;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess.Accounts;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices.Demo;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess.EnvironmentVariables;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices.Environment;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Plugins
{
    public abstract class PluginBase : IPlugin 
    {
        #region Protected properties
        protected string Name => GetType().FullName;
        protected string UnsecurePluginConfiguration { get; }
        protected string SecurePluginConfiguration { get; }
        #endregion

        #region Constructor(s)
        protected PluginBase(string unsecureString, string secureString) : this()
        {
            // Set local state
            this.UnsecurePluginConfiguration = unsecureString;
            this.SecurePluginConfiguration = secureString;
        }

        protected PluginBase()
        {
        }

        #endregion

        public DomainServicesFactory SetRegistrations(IOrganizationServiceFactory orgServiceFactory, ITracingService tracingService)
        {
            var repositoriesFactory = new RepositoriesFactory(orgServiceFactory);
            repositoriesFactory.Register<IAccountRepository, AccountRepository>();
            repositoriesFactory.Register<IEnvVariablesRepository, EnvVariablesRepository>(); 

            var servicesFactory = new DomainServicesFactory(repositoriesFactory, tracingService);
            servicesFactory.Register<IDemoService, DemoService>();
            servicesFactory.Register<IVariablesService, VariablesService>();

            return servicesFactory; 
        }

        public void Execute(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null) throw new ArgumentNullException(nameof(serviceProvider));

            ITracingService tracingService = null;
            IPluginExecutionContext pluginExecutionContext = null;

            try
            {
                tracingService = serviceProvider.GetService(typeof(ITracingService)) as ITracingService;

                tracingService.Trace("Resolving plugin execution context");
                pluginExecutionContext = serviceProvider.GetService(typeof(IPluginExecutionContext)) as IPluginExecutionContext;

                var serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));

                if (!IsContextValid(pluginExecutionContext))
                {
                    // Perform silent abort
                    tracingService.Trace($"Invalid plugin execution context detected (Plugin: {this.Name})");
                    tracingService.Trace($"Execution context: [{pluginExecutionContext?.ToFormattedString()}]");
                    tracingService.Trace("Plugin execution aborted");
                    return;
                }

                var servicesFactory = SetRegistrations(serviceFactory, tracingService); 
                Execute(pluginExecutionContext, servicesFactory, tracingService);
            }
            catch (InvalidPluginExecutionException) { throw; }
            catch (Exception e)
            {
                try
                {
                    // Trace exception
                    tracingService?.Trace($"Plugin failed unexpectedly: { this.Name }");
                    tracingService?.Trace($"Exception: {e}");
                    tracingService?.Trace($"PluginExecutionContext: { pluginExecutionContext?.ToFormattedString() }");

                    throw new InvalidPluginExecutionException(OperationStatus.Failed, "Action Failed");
                }
                catch (InvalidPluginExecutionException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(OperationStatus.Failed, $"Workflow error handling failed unexpectedly {ex.Message}\n{ex.StackTrace}");
                }
            }
        }



        protected static EntityReference GetTargetEntityReference(IPluginExecutionContext context)
        {
            return context != null && context.InputParameters != null &&
                   context.InputParameters.Contains(ParameterName.Target)
                       ? context.InputParameters[ParameterName.Target] as EntityReference
                       : null;
        }

        protected static TEntity GetTargetEntity<TEntity>(IPluginExecutionContext context) where TEntity : Entity
        {
            return GetTargetEntity(context).ToEntity<TEntity>();
        }

        protected static Entity GetTargetEntity(IPluginExecutionContext context)
        {
            return GetParameter<Entity>(context, ParameterName.Target);
        }

        protected static TParameter GetParameter<TParameter>(IPluginExecutionContext context, string parameterName) where TParameter : Entity
        {
            return context != null && context.InputParameters != null && context.InputParameters.Contains(parameterName)
                ? context.InputParameters[parameterName] as TParameter
                : null;
        }

        #region Abstract and virtual method(s)

        public abstract bool IsContextValid(IPluginExecutionContext pluginExecutionContext);

        public abstract void Execute(IPluginExecutionContext pluginExecutionContext, IDomainServicesFactory servicesFactory, ITracingService tracingService);

        #endregion
    }
}
