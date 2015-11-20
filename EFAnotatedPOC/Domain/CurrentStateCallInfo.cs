using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using EFGeneric.Base.Entity;

namespace EFAnotatedPOC.Domain
{
    [Table("CURRENT_STATE_CALL_INFO", Schema = "dbo")]
    public class CurrentStateCallInfo : BaseEntity<long>
    {

        [Key]
        [Column("ID")]
        public override long Id { get; set; }

        [Column("CALL_ID")]
        public string CallId { get; set; }

        [Column("AGENT_ID")]
        public string AgentId { get; set; }

        [Column("TN_CUSTOMER_ID")]
        public string TnCustomerId { get; set; }

        public CurrentStateCallInfo() { }

        public CurrentStateCallInfo(string callId, string agentId, string tnCustomerId)
        {
            CallId = callId;
            AgentId = agentId;
            TnCustomerId = tnCustomerId;
        }

    }
}
