using Abp.Domain.Entities.Auditing;
using AgileInsights.Connectivity;
using AgileInsights.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AgileInsights.Analytics
{
    public class Analytics : FullAuditedEntity<long>
    {
        [ForeignKey("ConnectionString")]
        public long ConnectionStringId { get; set; }
        public long OrganizationId { get; set; }
        public long DepartmentId { get; set; }
        public Periodicity Periodicity { get; set; }
        public DateTime Date { get; set; }
        public decimal Average { get; set; }
        public decimal Sum { get; set; }
        public int Count { get; set; }

        public virtual ConnectionString ConnectionString { get; set; }
    }
}
