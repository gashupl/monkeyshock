namespace MonkeyShock.PowerPlatform.Dataverse.Plugins.DataAccess.EnvironmentVariables
{
    public interface IEnvVariablesRepository : IRepository
    {
        string GetDefaultValue(string name); 
    }
}
