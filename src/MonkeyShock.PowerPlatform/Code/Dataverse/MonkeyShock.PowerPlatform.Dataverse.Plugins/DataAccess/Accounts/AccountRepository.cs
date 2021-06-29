using Microsoft.Xrm.Sdk;
using System; 

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess.Accounts
{
    public class AccountRepository : RepositoryBase, IAccountRepository
    {
        public AccountRepository(IOrganizationServiceFactory servicesFactory, Guid? userId) : base(servicesFactory, userId)
        {
        }
    }
}
