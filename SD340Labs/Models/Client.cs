using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SD340Labs.Models
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 3)]
        [Column(TypeName = "nvarchar(25)")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        [Column(TypeName = "nvarchar(25)")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public ICollection<Credit> Credits { get; set; }

        [InverseProperty("PreviousClient")]
        public Room PreviousRoom { get; set; }

        [InverseProperty("CurrentClient")]
        public Room CurrentRoom { get; set; }
    }
}
