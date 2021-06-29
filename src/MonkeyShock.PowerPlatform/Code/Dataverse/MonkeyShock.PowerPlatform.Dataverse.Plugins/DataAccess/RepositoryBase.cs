using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using MonkeyShock.PowerPlatform.Dataverse.Context;
using System;
using XrmSdk = Microsoft.Xrm.Sdk; 

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess
{
    public class RepositoryBase : IRepository
    {
        protected IOrganizationService organizationService;

        public RepositoryBase(IOrganizationServiceFactory servicesFactory, Guid? userId = null)
        {
            organizationService = servicesFactory.CreateOrganizationService(userId);
        }

        protected TContext CreateContext<TContext>() where TContext : DataverseServiceContext =>
            (TContext)Activator.CreateInstance(typeof(TContext), organizationService);


        public virtual void Update(XrmSdk.Entity entity)
        {
            if (entity != null)
            {
                entity.EntityState = EntityState.Changed;
                organizationService.Update(entity);
            }
        }

        public virtual void UpdateState(Guid entityId, string entityName, int stateCode, int statusCode)
        {
            var entity = new XrmSdk.Entity
            {
                Id = entityId,
                LogicalName = entityName
            };
            entity.Attributes.Add("statecode", new OptionSetValue(stateCode));
            entity.Attributes.Add("statuscode", new OptionSetValue(statusCode));
            organizationService.Update(entity);
        }

        public virtual Guid Create(XrmSdk.Entity entity)
        {
            if (entity != null)
            {
                return organizationService.Create(entity);
            }
            else
            {
                throw new ArgumentException($"{nameof(entity)} cannot be null");
            }

        }

        public virtual T CreateEntity<T>(T entity) where T : XrmSdk.Entity
        {
            if (entity != null)
            {
                entity.Id = organizationService.Create(entity);
                return entity.ToEntity<T>();
            }
            else
            {
                throw new ArgumentException($"{nameof(entity)} cannot be null");
            }
        }

        public T CreateEntityWithRetrieve<T>(T entity) where T : XrmSdk.Entity, new()
        {
            var tempEntity = CreateEntity(entity);
            return GetEntityById<T>(tempEntity.Id);
        }

        public virtual void Delete(Guid entityId, string entityName)
        {
            organizationService.Delete(entityName, entityId);
        }

        public void Delete(XrmSdk.Entity entity)
        {
            if (entity != null)
            {
                Delete(entity.Id, entity.LogicalName);
            }
            else
            {
                throw new ArgumentException($"{nameof(entity)} cannot be null");
            }
        }

        public virtual void Associate(string entityName, Guid entityId, string relationshipName, EntityReferenceCollection relatedEntities)
        {
            Associate(entityName, entityId, new XrmSdk.Relationship(relationshipName), relatedEntities);
        }

        public virtual void Associate(string entityName, Guid entityId, XrmSdk.Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            organizationService.Associate(entityName, entityId, relationship, relatedEntities);
        }

        public virtual void DisassociateEntities(string entityName, Guid entityId, string relationshipName, EntityReferenceCollection relatedEntities)
        {
            var relationship = new XrmSdk.Relationship(relationshipName);
            organizationService.Disassociate(entityName, entityId, relationship, relatedEntities);
        }

        public virtual OrganizationResponse Execute(OrganizationRequest request)
        {
            return organizationService.Execute(request);
        }

        public virtual T GetEntityById<T>(Guid entityId) where T : XrmSdk.Entity, new()
        {
            var logicalName = new T().LogicalName;
            return organizationService.Retrieve(logicalName, entityId, new ColumnSet(true))?.ToEntity<T>();
        }

        public void SetBusinessProcess(Guid processId, EntityReference entityRef)
        {
            organizationService.Execute(new SetProcessRequest
            {
                Target = entityRef,
                NewProcess = new EntityReference("process", processId)
            });
        }
    }
}
