using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Position { get; set; }
        
        public int Experience { get; set; }
        
        public int Client { get; set; }
        public bool IsDeleted { get; set; }
    }
}
