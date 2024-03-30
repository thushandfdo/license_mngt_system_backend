using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace license_mngt_system_backend.Models.Entities
{
    public class EndClient
    {
        [Key] public int clientId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string Industry { get; set; }
        public string AdditionalInfo { get; set; }
        public string HostURL { get; set; }

        [JsonIgnore] public ClientServer? ClientServer { get; set; }
        public string? MacAddress { get; set; }
        [JsonIgnore] public virtual ICollection<RequestKey> RequestKeys { get; set; }

        [ForeignKey("Partner")] public int PartnerId { get; set; }
        [JsonIgnore] public virtual Partner Partner { get; set; }
    }
}