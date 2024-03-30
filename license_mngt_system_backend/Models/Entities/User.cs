using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace license_mngt_system_backend.Models.Entities
{
    public class User
    {
        [Key] public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserType { get; set; }
    }
}