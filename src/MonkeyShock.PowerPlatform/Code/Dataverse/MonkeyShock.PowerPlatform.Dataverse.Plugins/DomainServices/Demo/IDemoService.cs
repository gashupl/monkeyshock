using System;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices.Demo
{
    public interface IDemoService : IService
    {
        string DoSomething(string name, Guid userId); 
    }
}
