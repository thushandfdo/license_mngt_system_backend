namespace license_mngt_system_backend.Models.DTOs
{
    public struct SeverDetailsDto
    {
        public string HostUrl { get; set; }
        public string MacAddress { get; set; }
        public string[] SiteNames { get; set; }
    }
}