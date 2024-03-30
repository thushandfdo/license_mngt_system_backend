using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace license_mngt_system_backend.Models.Entities
{
    public class RequestKey
    {
        [Key] public int RequestId { get; set; }

        public string Key { get; set; }
        public DateTime RequiredTime { get; set; }
        public bool IsFinanceApproval { get; set; } = false;
        public bool IsPartnerMgrApproval { get; set; } = false;
        public string? CommentFinanceMgt { get; set; } = null;
        public string? CommentPartnerMgt { get; set; } = null;
        public string Status { get; set; }

        [JsonIgnore] public virtual ICollection<Modules> Modules { get; set; }

        [JsonIgnore] public virtual ICollection<EndClient> EndClients { get; set; }

        [JsonIgnore] public virtual LicenseKey LicenseKey { get; set; }

        [ForeignKey("Partner")] public int PartnerId { get; set; }

        [JsonIgnore] public virtual Partner Partner { get; set; }

        public virtual ICollection<PartnerManager> PartnerManagers { get; set; }
        public virtual ICollection<FinanceManager> FinaceManagers { get; set; }
    }
}