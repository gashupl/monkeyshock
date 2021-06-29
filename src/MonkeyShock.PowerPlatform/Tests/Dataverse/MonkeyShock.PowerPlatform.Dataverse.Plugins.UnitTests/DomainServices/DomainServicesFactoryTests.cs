using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DomainServices.Demo;
using Moq;
using System;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.UnitTests.DomainServices
{
    [TestClass]
    public class DomainServicesFactoryTests
    {
        ITracingService tracingService = new Mock<ITracingService>().Object; 

        [TestMethod]
        public void Get_RegisteredService_ReturnObject()
        {
            var repoFactoryMock = new Mock<IRepositoriesFactory>();
            var servicesFactory = new DomainServicesFactory(repoFactoryMock.Object, tracingService);
            servicesFactory.Register<IDemoService, DemoService>();

            var service = servicesFactory.Get<IDemoService>();

            Assert.IsNotNull(service);
            Assert.IsInstanceOfType(service, typeof(DemoService)); 
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetMissingRegistration_ThrowException()
        {
            var repoFactoryMock = new Mock<IRepositoriesFactory>();
            var servicesFactory = new DomainServicesFactory(repoFactoryMock.Object, tracingService);

            var service = servicesFactory.Get<IDemoService>();
        }
    }
}
