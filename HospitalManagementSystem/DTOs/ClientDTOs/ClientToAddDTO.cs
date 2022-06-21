using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.DTOs.ClientDTOs
{
    public class ClientToAddDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Phone { get; set; }
        public DateTime Date_Time { get; set; }
    }
}
