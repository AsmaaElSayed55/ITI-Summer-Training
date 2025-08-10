using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BrightStars.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage="You have to provide a valid full name")]
        [MinLength(8,ErrorMessage="Full name mustn't be less than 8 characters.")]
        [MaxLength(50,ErrorMessage ="Full name mustn't exceed 50 characters.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "You have to provide a valid full name")]
        [MinLength(5, ErrorMessage = "Position mustn't be less than 5 characters.")]
        [MaxLength(25, ErrorMessage = "Position mustn't exceed 25 characters.")]
        [Display(Name ="Job")]
        public string Position { get; set; }
        [Range(6000,60000 , ErrorMessage="Salary must be between 6000 EGP and 60000 EGP.")]
        public decimal Salary { get; set; }
    }
}
