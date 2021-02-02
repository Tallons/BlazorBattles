using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBattles.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress] 
        public string Email { get; set; }
        
        [StringLength(16, ErrorMessage = "Your username is too long (16 characters max).")]
        public string Username { get; set; }
        
        public string Bio { get; set; }
        
        [Required, StringLength(100, MinimumLength = 8)]
        public string Password { get; set; }
        
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }
        
        public int Food { get; set; } = 500;
        
        public string StartUnitId { get; set; } = "1";
        
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        
        [Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users can play!")]
        public bool IsConfirmed { get; set; } = true;
    }
}