using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.DTOs.DoctorDTOs
{
    public class DoctorToUpdateDTO
    {
        [Required]
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
    }
}
