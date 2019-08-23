using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Dataocean.Venus.Authorization.Users;
using Dataocean.Venus.MultiTenancy;

namespace Dataocean.Venus.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
