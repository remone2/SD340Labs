using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SD340Labs.Models
{
    public class Credit
    {
        [Key]
        public int CreditId { get; set; }
        public bool IsValid { get; set; }

        [StringLength(20)]
        public string HolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
