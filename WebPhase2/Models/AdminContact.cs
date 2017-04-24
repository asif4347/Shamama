using System.ComponentModel.DataAnnotations;

namespace WebPhase2.Models
{
    public class AdminContact
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Email can not be empty!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter Valid Email Address")]
        public string Email { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }
    }
}