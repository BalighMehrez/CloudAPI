namespace Dataocean.Venus.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}
