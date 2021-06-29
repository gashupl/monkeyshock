using System;
using System.Collections.Generic;
using System.Linq;


namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Common
{
    public abstract class FactoryBase : IFactory
    {
        protected List<KeyValuePair<Type, Type>> registrations = new List<KeyValuePair<Type, Type>>();
        public void Register<I, T>() where T: class 
        {
            Type interfaceType = typeof(I);
            Type classType = typeof(T);      
            if (!registrations.Any(r => r.Key == interfaceType) && !registrations.Any(r => r.Value == classType))
            {
                registrations.Add(new KeyValuePair<Type, Type>(interfaceType, classType));
            }
            else
            {
                throw new InvalidOperationException($"The type { nameof(interfaceType) } was already registered");
            }
        }
    }
}
