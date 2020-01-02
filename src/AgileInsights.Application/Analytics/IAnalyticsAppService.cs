using Abp.Application.Services;
using AgileInsights.Analytics.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgileInsights.Analytics
{
    public interface IAnalyticsAppService:IApplicationService
    {
        Task<AnalyticsOutputDto> CreateOrUpdateAsync(AnalyticsInputDto input);

        Task BatchCreateOrUpdat(List<AnalyticsInputDto> input);
    }
}
