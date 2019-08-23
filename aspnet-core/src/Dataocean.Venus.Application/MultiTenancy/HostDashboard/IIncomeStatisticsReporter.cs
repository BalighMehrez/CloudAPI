using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dataocean.Venus.MultiTenancy.HostDashboard.Dto;

namespace Dataocean.Venus.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}
