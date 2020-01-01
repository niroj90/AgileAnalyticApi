using Abp.Application.Services;
using Abp.ObjectMapping;
using AgileInsights.Analytics.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgileInsights.Analytics
{
    public class AnalyticsAppService : ApplicationService, IAnalyticsAppService
    {
        private readonly IAnalyticsManager _analyticsManager;
        private readonly IObjectMapper _objectMapper;
        public AnalyticsAppService(IAnalyticsManager analyticsManager,
            IObjectMapper objectMapper)
        {
            _analyticsManager = analyticsManager;
            _objectMapper = ObjectMapper;
        }
        public async Task<AnalyticsOutputDto> CreateOrUpdateAsync(AnalyticsInputDto input)
        {
            try
            {
                var analytics = _objectMapper.Map<Analytics>(input);
                return _objectMapper.Map<AnalyticsOutputDto>(await _analyticsManager.CreateOrUpdateAsync(analytics));
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
