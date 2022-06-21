namespace HospitalManagementSystem.DTOs.UserDTOs
{
    public class UserToListDTO
    {
        public int Id { get; set; }
        public int Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
