using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        public bool IsDeleted { get; set; }

    }
}
