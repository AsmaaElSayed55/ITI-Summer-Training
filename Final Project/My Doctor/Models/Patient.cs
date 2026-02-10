namespace My_Doctor.Models
{
    public class Patient : User
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string History { get; set; }
    }
}
