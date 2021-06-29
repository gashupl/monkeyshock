using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess.Accounts;
using Moq;
using System;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.UnitTests.DataAccess
{
    [TestClass]
    public class RepositoriesFactoryTests
    {
        [TestMethod]
        public void Get_RegisteredService_ReturnObject()
        {
            var orgFactoryMock = new Mock<IOrganizationServiceFactory>(); 
            var repoFactory = new RepositoriesFactory(orgFactoryMock.Object);
            repoFactory.Register<IAccountRepository, AccountRepository>();

            var repo = repoFactory.Get<IAccountRepository>();

            Assert.IsNotNull(repo);
            Assert.IsInstanceOfType(repo, typeof(AccountRepository)); 
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetMissingRegistration_ThrowException()
        {
            var orgFactoryMock = new Mock<IOrganizationServiceFactory>();
            var repoFactory = new RepositoriesFactory(orgFactoryMock.Object);
            var repo = repoFactory.Get<IAccountRepository>();
        }
    }
}
