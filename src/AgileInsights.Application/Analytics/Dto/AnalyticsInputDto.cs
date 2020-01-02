using Abp.Application.Services.Dto;
using AgileInsights.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgileInsights.Analytics.Dto
{
    public class AnalyticsInputDto:EntityDto<long>
    {
        public long RemoteClientId { get; set; }
        public long OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public long DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Periodicity Periodicity { get; set; }
        public DateTime Date { get; set; }
        public decimal Average { get; set; }
        public decimal Sum { get; set; }
        public int Count { get; set; }
        public bool IsHoliday { get; set; }
        public bool IsRainy { get; set; }
    }
}
