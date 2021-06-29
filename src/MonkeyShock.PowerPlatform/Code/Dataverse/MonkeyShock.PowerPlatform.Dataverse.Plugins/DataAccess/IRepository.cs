using Microsoft.Xrm.Sdk;
using System;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess
{
    public interface IRepository
    {
        T GetEntityById<T>(Guid entityId) where T : Entity, new();
        Guid Create(Entity entity);
        T CreateEntity<T>(T entity) where T : Entity;
        T CreateEntityWithRetrieve<T>(T entity) where T : Entity, new();
        void Update(Entity entity);
        void UpdateState(Guid entityId, string entityName, int stateCode, int statusCode);
        void Delete(Guid entityId, string entityName);
        void Delete(Entity entity);
        void Associate(string entityName, Guid entityId, string relationshipName, EntityReferenceCollection relatedEntities);
        void Associate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities);
        void DisassociateEntities(string entityName, Guid entityId, string relationshipName, EntityReferenceCollection relatedEntities);
        OrganizationResponse Execute(OrganizationRequest request);
        void SetBusinessProcess(Guid processId, EntityReference entityRef);
    }
}
