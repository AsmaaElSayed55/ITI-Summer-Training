namespace My_Doctor.Models
{
    public class RegisterViewModel
    {
        // Common fields
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        // Patient fields
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string History { get; set; }

        // Doctor fields
        public string Specialization { get; set; }
        public string AvailableTimes { get; set; }
    }
}
