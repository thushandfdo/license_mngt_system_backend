namespace license_mngt_system_backend.Models.DTOs
{
    public class RequestDto
    {
        public string To { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public string LicenseKey { get; set; } = string.Empty;
    }
}