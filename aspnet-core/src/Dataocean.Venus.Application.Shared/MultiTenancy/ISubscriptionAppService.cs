﻿using System.Threading.Tasks;
using Abp.Application.Services;

namespace Dataocean.Venus.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);

        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}

