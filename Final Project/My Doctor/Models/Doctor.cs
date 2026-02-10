namespace My_Doctor.Models
{
    public class Doctor : User
    {
        public string Specialization { get; set; }
        public string AvailableTimes { get; set; }
    }
}
