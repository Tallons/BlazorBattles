using System;

namespace BlazorBattles.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int Food { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;



    }
}