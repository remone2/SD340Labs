using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SD340Labs.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        
        public enum Section
        {
            First,
            Second,
            Third
        };

        public int? PreviousClientId { get; set; }
        [ForeignKey("PreviousClientId")]
        public Client? PreviousClient { get; set; }
        public int? CurrentClientId { get; set; }
        [ForeignKey("CurrentClientId")]
        public Client? CurrentClient { get; set; }
    }
}
