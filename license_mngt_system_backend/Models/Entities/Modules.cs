using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace license_mngt_system_backend.Models.Entities
{
    public class Modules
    {
        [Key] public int ModuleId { get; set; }
        
        public string Modulename { get; set; }
        public DateTime CreatedData { get; set; }
        public string Features { get; set; }
        public string ModuleDescription { get; set; }

        [JsonIgnore] public virtual ICollection<RequestKey> RequestKeys { get; set; }
    }
}