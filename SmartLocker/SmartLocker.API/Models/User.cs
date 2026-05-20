namespace SmartLocker.API.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        // Navigation
        public ICollection<UserRole> UserRoles { get; set; }
    }
}