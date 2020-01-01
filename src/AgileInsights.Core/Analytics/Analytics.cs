using Abp.Domain.Entities.Auditing;
using AgileInsights.Enums;
using AgileInsights.Remote;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AgileInsights.Analytics
{
    public class Analytics : FullAuditedEntity<long>
    {
        [ForeignKey("RemoteClient")]
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

        public virtual RemoteClient RemoteClient { get; set; }
    }
}
