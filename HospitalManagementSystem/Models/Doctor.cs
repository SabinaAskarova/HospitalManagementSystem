﻿namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }
        public int Client { get; set; }
    }
}
