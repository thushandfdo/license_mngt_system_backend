using System.ComponentModel.DataAnnotations;

namespace license_mngt_system_backend.Models.Entities
{
    public class ClientPanel
    {
        [Key] public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Module { get; set; }
        public DateTime ActivatedDate { get; set; }
        public DateTime DeactivatedDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Website { get; set; }
        public string Industry { get; set; }
        public string AdditionalInfo { get; set; }
    }
}