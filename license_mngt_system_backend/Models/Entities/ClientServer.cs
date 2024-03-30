using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace license_mngt_system_backend.Models.Entities
{
    public class ClientServer
    {
        [Key] public string? MacAddress { get; set; }

        public string? HostUrl { get; set; }
        public int ClientId { get; set; }
        public DateTime TestDate { get; set; }
        [JsonIgnore] public EndClient? Client { get; set; } = null;
        [JsonIgnore] public virtual ICollection<ClientServerSiteName>? SiteNames { get; set; }
    }
}