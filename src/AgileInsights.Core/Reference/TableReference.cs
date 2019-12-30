using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AgileInsights.Reference
{
    public class TableReference : FullAuditedEntity<long>
    {
        public long ConnectionStringId { get; set; }
        [Required]
        [StringLength(AgileInsightsConsts.MaxLengths.TableName)]
        public string TableName { get; set; }

        [Required]
        [StringLength(AgileInsightsConsts.MaxLengths.ColumnName)]
        public string ColumnName { get; set; }

        [Required]
        [StringLength(AgileInsightsConsts.MaxLengths.MappedColumnName)]
        public string MappedColumnName { get; set; }
    }
}
