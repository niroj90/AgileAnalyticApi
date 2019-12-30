using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AgileInsights.Connectivity
{
    public class ConnectionString : FullAuditedEntity<long>
    {
        [Required]
        [StringLength(AgileInsightsConsts.MaxLengths.DatabaseName)]
        public string DatabaseName { get; set; }

        [StringLength(AgileInsightsConsts.MaxLengths.ConnectionString)]
        public string ConnectionStringValue { get; set; }
    }
}
