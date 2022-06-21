using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.DTOs.UserDTOs
{
    public class UserToAddDTO
    {
        [Required]
        public int Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
    }
}
