using System.ComponentModel.DataAnnotations;

namespace SD340Labs.Models
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
