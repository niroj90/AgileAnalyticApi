using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgileInsights.Remote
{
    public class RemoteClient : FullAuditedEntity<long>
    {
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int TenantId { get; set; }
        public string ComputerName { get; set; }
        public string ComputerMac { get; set; }
        public DateTime? LastSync { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public string AESKey { get; set; }
    }
}
