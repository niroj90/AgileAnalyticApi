using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgileInsights.Analytics
{
    public interface IAnalyticsManager : IDomainService
    {
        Task<Analytics> CreateOrUpdateAsync(Analytics input);
       

    }
}
