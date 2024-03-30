using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace license_mngt_system_backend.Models.Entities
{
    public class PartnerManager : User
    {
        [ForeignKey("RequestKey")] public int RequestId { get; set; }
        [JsonIgnore] public virtual RequestKey RequestKey { get; set; }
    }
}