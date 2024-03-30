using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace license_mngt_system_backend.Models.Entities
{
    public class LicenseKey
    {
        [Key] public int KeyId { get; set; }
        public string Key { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime DeactivatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsIssued { get; set; }
        public bool IsExpired { get; set; }

        public int RequestId { get; set; }
        [JsonIgnore] public virtual RequestKey RequestKey { get; set; }
    }
}