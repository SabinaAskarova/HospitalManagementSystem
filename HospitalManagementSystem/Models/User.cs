using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class User
    {
        [Required]
        
        public int Id { get; set; }

        [Required]
        public int Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        
    }
}
