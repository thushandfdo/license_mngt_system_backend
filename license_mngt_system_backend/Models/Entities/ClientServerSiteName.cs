using System.ComponentModel.DataAnnotations;

namespace license_mngt_system_backend.Models.Entities
{
    public class ClientServerSiteName
    {
        [Key] public int Id { get; set; }

        public string? SiteName { get; set; }
        public string? MacAddress { get; set; }
        public ClientServer? ClientServer { get; set; }
    }
}