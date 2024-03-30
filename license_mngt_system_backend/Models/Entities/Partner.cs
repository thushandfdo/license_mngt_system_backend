namespace license_mngt_system_backend.Models.Entities
{
    public class Partner : User
    {
        public virtual ICollection<EndClient> EndClients { get; set; }
        public virtual ICollection<RequestKey> RequestKeys { get; set; }
    }
}