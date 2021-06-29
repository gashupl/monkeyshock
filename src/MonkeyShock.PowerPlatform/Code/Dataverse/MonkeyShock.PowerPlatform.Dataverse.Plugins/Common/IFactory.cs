namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.Common
{
    public interface IFactory
    {
        void Register<I, T>() where T : class; 
    }
}
