using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.Common;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess.Accounts;
using System;
using System.Linq; 
using System.Collections.Generic;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.UnitTests.Common
{
    [TestClass]
    public class FactoryBaseTests
    {
        private class TestFactory : FactoryBase
        {
            public List<KeyValuePair<Type, Type>> GetRegistrations()
            {
                return this.registrations; 
            }
        }

        [TestMethod]
        public void Register_NewRegistration_Successfull()
        {
            var testFactory = new TestFactory();
            testFactory.Register<IAccountRepository, AccountRepository>();

            var registrations = testFactory.GetRegistrations();

            var registered = registrations.Any(kp => kp.Key == typeof(IAccountRepository));
            Assert.IsTrue(registered);
        }

        [TestMethod]
        public void Register_MissingRegistration_Failed()
        {
            var testFactory = new TestFactory();
            var registrations = testFactory.GetRegistrations();

            var registered = registrations.Any(kp => kp.Key == typeof(IAccountRepository));
            Assert.IsFalse(registered);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Register_DuplicateRegistration_ThrowException()
        {
            var testFactory = new TestFactory();
            testFactory.Register<IAccountRepository, AccountRepository>();
            testFactory.Register<IAccountRepository, AccountRepository>();
        }
    }
}
