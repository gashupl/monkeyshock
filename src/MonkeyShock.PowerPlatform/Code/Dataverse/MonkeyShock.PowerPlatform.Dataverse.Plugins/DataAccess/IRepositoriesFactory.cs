using MonkeyShock.PowerPlatform.Dataverse.Plugins.Common;
using System;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess
{
    public interface IRepositoriesFactory : IFactory
    {
        T Get<T>(Guid? userId = null) where T : IRepository; 
    }
}