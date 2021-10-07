using FakeXrmEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using MonkeyShock.PowerPlatform.Dataverse.Common.Values;
using MonkeyShock.PowerPlatform.Dataverse.Context;
using MonkeyShock.PowerPlatform.Dataverse.Plugins.Plugins.Common;
using System;

namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.UnitTests.Plugins.Common
{
    [TestClass]
    public class SetRecordIdNamePluginTests
    {
        [TestMethod]
        public void IsContextValid_ValidContext_ReturnTrue()
        {
            var context = SetPluginContext(new Account(),
                MessageName.Create,
                (int)ProcessingMode.Synchronous,
                (int)ProcessingStage.PreOperation); 

            var plugin = new SetRecordIdNamePlugin();
            var isValid = plugin.IsContextValid(context);

            Assert.IsTrue(isValid); 
        }

        [TestMethod]
        public void IsContextValid_InvalidMode_ReturnFalse()
        {
            var context = SetPluginContext(new Account(),
                MessageName.Create,
                (int)ProcessingMode.Asynchronous,
                (int)ProcessingStage.PreOperation);

            var plugin = new SetRecordIdNamePlugin();
            var isValid = plugin.IsContextValid(context);

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsContextValid_InvalidMessage_ReturnFalse()
        {
            var context = SetPluginContext(new Account(),
                MessageName.Update,
                (int)ProcessingMode.Synchronous,
                (int)ProcessingStage.PreOperation);

            var plugin = new SetRecordIdNamePlugin();
            var isValid = plugin.IsContextValid(context);

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsContextValid_InvalidStage_ReturnFalse()
        {
            var context = SetPluginContext(new Account(),
                MessageName.Create,
                (int)ProcessingMode.Synchronous,
                (int)ProcessingStage.PreValidation);

            var plugin = new SetRecordIdNamePlugin();
            var isValid = plugin.IsContextValid(context);

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Execute_SetTargetValues()
        {
            var expectedId = Guid.NewGuid();
            var expectedName = pg_pcftest.EntityLogicalName; 

            var context = SetPluginContext(new pg_pcftest() { Id = expectedId },
                MessageName.Create,
                (int)ProcessingMode.Asynchronous,
                (int)ProcessingStage.PreOperation);

            var plugin = new SetRecordIdNamePlugin();
            plugin.Execute(context, null, null);

            var target = (Entity)context.InputParameters[ParameterName.Target];
            var pcfTest = target.ToEntity<pg_pcftest>();

            Assert.AreEqual(expectedId.ToString(), pcfTest.pg_entityidentifier);
            Assert.AreEqual(expectedName, pcfTest.pg_entityname); 


        }

        private IPluginExecutionContext SetPluginContext(Entity target, string messageName, int mode, int stage)
        {
            var context = new XrmFakedContext();

            ParameterCollection inputParameters = new ParameterCollection();
            inputParameters.Add(ParameterName.Target, target);

            var pluginContext = context.GetDefaultPluginContext();
            pluginContext.MessageName = messageName;
            pluginContext.Mode = mode;
            pluginContext.Stage = stage;
            pluginContext.InputParameters = inputParameters;

            return pluginContext; 
        }
    }
}
