using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AgileInsights.Remote
{
    public class RemoteToken : Entity<long>
    {
        public Guid Token { get; set; }
        public bool Active { get; set; }
        public DateTime Expires { get; set; }
        

        [ForeignKey("RemoteClient")]
        public long RemoteClientId { get; set; }
        public string IPAddress { get; set; }
        public DateTime? LastActivity { get; set; }

        public virtual RemoteClient RemoteClient { get; set; }
    }
}
